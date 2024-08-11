﻿using System;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceWire.NamedPipes
{
    public class NpListener
    {
        private bool running;
        private EventWaitHandle terminateHandle = new EventWaitHandle(false, EventResetMode.AutoReset);
        private int _maxConnections = 254;
        private ILog _log = new NullLogger();
        private IStats _stats = new NullStats();

        public string PipeName { get; set; }
        public event EventHandler<PipeClientConnectionEventArgs> RequestRecieved;

        public NpListener(string pipeName, int maxConnections = 254, ILog log = null, IStats stats = null)
        {
            _log = log ?? _log;
            _stats = stats ?? _stats;
            if (maxConnections > 254) maxConnections = 254;
            _maxConnections = maxConnections;
            this.PipeName = pipeName;
        }

        public void Start()
        {
            running = true;
            Task.Factory.StartNew(() => ServerLoop(), TaskCreationOptions.LongRunning);
        }

        public void Stop()
        {
            if (running)
            {
                running = false;
                //make fake connection to terminate the waiting stream
                try
                {
                    using (var client = new NamedPipeClientStream(PipeName))
                    {
                        client.Connect(50);
                    }
                }
                catch (Exception e)
                {
                    _log.Error("Stop error: {0}", e.ToString().Flatten());
                }
                terminateHandle.WaitOne();
            }
        }

        private void ServerLoop()
        {
            try
            {
                while (running)
                {
                    ProcessNextClient();
                }
            }
            catch (Exception e)
            {
                _log.Fatal("ServerLoop fatal error: {0}", e.ToString().Flatten());
            }
            finally
            {
                terminateHandle.Set();
            }
        }

        private void ProcessClientThread(NamedPipeServerStream pipeStream)
        {
            try
            {
                if (this.RequestRecieved != null && pipeStream.IsConnected) //has event subscribers
                {
                    var args = new PipeClientConnectionEventArgs(pipeStream);
                    RequestRecieved(this, args);
                }
            }
            catch (Exception e)
            {
                _log.Error("ProcessClientThread error: {0}", e.ToString().Flatten());
            }
            finally
            {
                try
                {
                    if (pipeStream.IsConnected) pipeStream.Close();
                    pipeStream.Dispose();
                }
                catch { } // ignore errors on closing and disposing because those woudl kill our pp
            }
        }

        public void ProcessNextClient()
        {
            try
            {
                var pipeStream = new NamedPipeServerStream(PipeName, PipeDirection.InOut, _maxConnections, PipeTransmissionMode.Byte, PipeOptions.None, 512, 512);
                pipeStream.WaitForConnection();
                //Task.Factory.StartNew(() => ProcessClientThread(pipeStream), TaskCreationOptions.LongRunning);
                Task.Factory.StartNew(() => ProcessClientThread(pipeStream));
            }
            catch (Exception e)
            {
                //If there are no more avail connections (254 is in use already) then just keep looping until one is avail
                _log.Error("ProcessNextClient error: {0}", e.ToString().Flatten());
            }
        }
    }

    // Defines the data protocol for reading and writing strings on our stream

    // Contains the method executed in the context of the impersonated user
}
