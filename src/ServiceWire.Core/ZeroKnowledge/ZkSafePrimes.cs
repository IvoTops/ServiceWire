﻿namespace ServiceWire.ZeroKnowledge
{
    public static class ZkSafePrimes
    {
        public static byte[] N4
        {
            get { return Safe4096BitPrime; }
        }

        private static byte[] Safe4096BitPrime = new byte[]
        {
            0xaf,0x0c,0x85,0x8d,0xf6,0xf0,0x8f,0xdf,0x9c,0x65,0xc4,0x6b,0x86,0x2b,0x8a,0x49,0xa8,0x96,0x43,0xbc,0x8b,0xeb,0x69,0xd4,0xfe,0xca,0xd6,0xde,0xa6,0xaf,0x8d,0xc3, 
            0x94,0x38,0x12,0xbc,0x93,0x78,0x9d,0xba,0x86,0x11,0x3a,0xd7,0x9a,0xbf,0x48,0xbf,0x46,0x09,0x89,0x47,0xe7,0x1e,0x41,0xa1,0x36,0x53,0x3f,0x60,0x43,0x6f,0x90,0xb8, 
            0x9d,0x53,0x5d,0xc3,0x54,0xeb,0xd9,0xcb,0x6c,0xf5,0x7f,0x55,0x06,0xd5,0xb1,0x8b,0xbc,0xaa,0x86,0x19,0x98,0xf4,0x05,0x5b,0x9e,0xc3,0x58,0x2f,0xa6,0xc2,0x16,0x1f, 
            0x75,0xd0,0x55,0x42,0xba,0x4b,0x2d,0x54,0x96,0xb4,0x11,0x38,0x54,0xc6,0xd1,0x4f,0xb8,0xbb,0x93,0x37,0x05,0x79,0xba,0xe0,0xe1,0xe6,0x07,0x7f,0xd6,0xef,0xe6,0x2e, 
            0xd7,0x44,0xf6,0x5a,0x19,0x12,0xf7,0x30,0x59,0x2e,0x62,0x1e,0xc7,0xd4,0x59,0x3c,0x1f,0xf4,0x16,0x94,0xac,0xf6,0x1b,0xe2,0x7b,0xa5,0xd2,0x5e,0xdf,0x5e,0xbf,0xe3, 
            0x33,0x34,0x61,0x7a,0x31,0xb0,0x89,0xaa,0x8a,0xc8,0xb8,0xf9,0x17,0xf0,0xd8,0x18,0x53,0x62,0x57,0x4c,0x7c,0xdf,0xaf,0x64,0x62,0x41,0x49,0xae,0xc5,0xc1,0xa3,0x97, 
            0x28,0x96,0x14,0xa9,0xef,0xdc,0x52,0x9f,0x40,0x84,0xb0,0x97,0x83,0x60,0xec,0xe1,0x0d,0xd6,0xeb,0x9a,0xd8,0xbe,0x04,0x6f,0xe7,0xc9,0x35,0x76,0x9a,0x06,0x8a,0xf8, 
            0xbf,0x72,0x56,0x9e,0x6e,0x5b,0x45,0x4b,0x58,0x75,0x4f,0x35,0x89,0x2b,0x91,0x8f,0xa7,0x30,0xfe,0xfa,0x1e,0xf4,0x06,0x7d,0x64,0xf3,0x65,0xdb,0x72,0x53,0xd4,0x9e, 
            0xd9,0xf0,0x91,0x93,0xc8,0x89,0xb4,0xa0,0x78,0xe6,0x2b,0xf5,0x6b,0x91,0x04,0xf9,0xac,0xac,0x2e,0x2a,0x38,0x03,0xdb,0xbd,0xf4,0xd7,0x69,0x6e,0x1a,0x26,0xf8,0xb4, 
            0x71,0x59,0xaf,0x14,0xf8,0x55,0x0c,0x70,0xd0,0xdc,0x9b,0x1c,0x36,0x35,0x32,0x86,0xa2,0x01,0xe0,0x42,0x47,0x4f,0x2d,0x46,0x67,0x37,0xbb,0x35,0xc3,0xb6,0xa7,0x54, 
            0x41,0x3e,0xaa,0xd1,0x90,0xdd,0x3d,0x09,0x08,0x17,0xbc,0x32,0xf6,0xe7,0xba,0x41,0x3f,0xf9,0xf9,0x4b,0xf6,0x5b,0xa8,0x76,0x54,0x5a,0x4a,0x1e,0x0c,0xe5,0x44,0x30, 
            0x84,0xf7,0x04,0x94,0x22,0x24,0xee,0x79,0xf0,0x67,0xd8,0x51,0x86,0x52,0xb6,0x1d,0x59,0x1a,0xa1,0xbe,0x7a,0x35,0xac,0xd3,0xd9,0x6b,0x31,0x44,0x3d,0x30,0x46,0xb6, 
            0x1c,0x73,0xd2,0xa4,0x13,0x05,0x84,0x8a,0xcc,0xe6,0x4d,0x83,0x04,0x54,0xf1,0xa9,0x47,0x60,0x4b,0x57,0x62,0x59,0x90,0x05,0x9b,0x23,0xa2,0xc3,0xf3,0x3c,0xca,0xcf, 
            0x0a,0x91,0x85,0xbf,0x9e,0x6b,0xbf,0x9c,0xcc,0x7e,0xd0,0x5e,0xcc,0xbe,0xe8,0xed,0xa9,0x37,0x5a,0x96,0x4f,0xd1,0xf0,0xc4,0xe0,0xfb,0x25,0xe6,0x4a,0xf1,0x90,0x89, 
            0xfd,0xb9,0xa3,0x5a,0xbc,0xb1,0x7e,0x8c,0x4b,0xfd,0xfd,0x60,0x29,0x48,0x31,0x94,0x28,0x51,0xcd,0x22,0x7a,0x0c,0x0f,0x40,0x5a,0x84,0xdb,0xb4,0x37,0x90,0x91,0x90, 
            0x18,0x1b,0x3e,0xf7,0x79,0x1b,0x47,0x37,0x02,0x0f,0xf1,0x2a,0x0d,0xef,0x48,0x0b,0x78,0x08,0x40,0xce,0xde,0x5f,0x62,0x4c,0xf8,0xf3,0xbe,0xf5,0xfd,0x44,0xf5,0x73        
        };


        public static int GetSafePrime(int index)
        {
            if (index < 1) index = 1;
            else if (index > 2047) index = 2047;
            else if (index % 2 == 0) index++;
            return _safePrimes[index];
        }

        //2048 values, even numbered values are safe primes, odds are their q in N = 2q+1
        private static int[] _safePrimes = new[]
        {
            5903,11807,8741,17483,11909,23819,6053,12107,8951,17903,11939,23879,6101,12203,8969,17939,12011,
            24023,6113,12227,9029,18059,12041,24083,6131,12263,9059,18119,12101,24203,6173,12347,9221,18443,
            12119,24239,6263,12527,9293,18587,12203,24407,6269,12539,9371,18743,12263,24527,6323,12647,9419,
            18839,12329,24659,6329,12659,9473,18947,12653,25307,6449,12899,9479,18959,12671,25343,6491,12983,
            9539,19079,12791,25583,6521,13043,9629,19259,12821,25643,6551,13103,9689,19379,12899,25799,6563,
            13127,9791,19583,12923,25847,6581,13163,10061,20123,12959,25919,6761,13523,10091,20183,13001,26003,
            6899,13799,10163,20327,13049,26099,6983,13967,10253,20507,13229,26459,7043,14087,10271,20543,13313,
            26627,7079,14159,10313,20627,13451,26903,7103,14207,10331,20663,13463,26927,7121,14243,10529,21059,
            13553,27107,7151,14303,10589,21179,13619,27239,7193,14387,10613,21227,13649,27299,7211,14423,10691,
            21383,13763,27527,7349,14699,10709,21419,13883,27767,7433,14867,10733,21467,13901,27803,7541,15083,
            10781,21563,13913,27827,7643,15287,10799,21599,14009,28019,7649,15299,10883,21767,14081,28163,7691,
            15383,11171,22343,14153,28307,7823,15647,11321,22643,14159,28319,7841,15683,11369,22739,14249,28499,
            7883,15767,11393,22787,14303,28607,7901,15803,11471,22943,14321,28643,14489,28979,18041,36083,21149,
            42299,14561,29123,18131,36263,21179,42359,14621,29243,18149,36299,21221,42443,14669,29339,18191,36383,
            21341,42683,14699,29399,18233,36467,21383,42767,14741,29483,18341,36683,21419,42839,14783,29567,18443,
            36887,21611,43223,14831,29663,18461,36923,21701,43403,14879,29759,18731,37463,21713,43427,14939,29879,
            18773,37547,21803,43607,15101,30203,18803,37607,21893,43787,15161,30323,18899,37799,22013,44027,15173,
            30347,19163,38327,22079,44159,15233,30467,19301,38603,22133,44267,15269,30539,19319,38639,22259,44519,
            15401,30803,19373,38747,22271,44543,15569,31139,19391,38783,22343,44687,15629,31259,19433,38867,22349,
            44699,15773,31547,19553,39107,22409,44819,15791,31583,19559,39119,22433,44867,15803,31607,19661,39323,
            22469,44939,15923,31847,19709,39419,22481,44963,16001,32003,19751,39503,22541,45083,16091,32183,19889,
            39779,22751,45503,16253,32507,19913,39827,22853,45707,16301,32603,19919,39839,22943,45887,16421,32843,
            19991,39983,23099,46199,16493,32987,20063,40127,23279,46559,16553,33107,20249,40499,23321,46643,16673,
            33347,20369,40739,23339,46679,16811,33623,20393,40787,23459,46919,16823,33647,20411,40823,23561,47123,
            16883,33767,20441,40883,23603,47207,16931,33863,20693,41387,23669,47339,17159,34319,20753,41507,23753,
            47507,17183,34367,20759,41519,23819,47639,17291,34583,20771,41543,23909,47819,17333,34667,20789,41579,
            23981,47963,17351,34703,20879,41759,24203,48407,17579,35159,20921,41843,24239,48479,17669,35339,20939,
            41879,24281,48563,17681,35363,20963,41927,24473,48947,17939,35879,21011,42023,24509,49019,17981,35963,
            21089,42179,24551,49103,24611,49223,28793,57587,32789,65579,24683,49367,28859,57719,32843,65687,24749,
            49499,28901,57803,32933,65867,24971,49943,28949,57899,33023,66047,25073,50147,28961,57923,33053,66107,
            25229,50459,29021,58043,33119,66239,25523,51047,29033,58067,33179,66359,25601,51203,29201,58403,33191,
            66383,25643,51287,29339,58679,33461,66923,25673,51347,29363,58727,33479,66959,25703,51407,29453,58907,
            33521,67043,25799,51599,29483,58967,33569,67139,25841,51683,29531,59063,33623,67247,25913,51827,29723,
            59447,33713,67427,25919,51839,29873,59747,33749,67499,26111,52223,30269,60539,33773,67547,26189,52379,
            30323,60647,33809,67619,26459,52919,30389,60779,33941,67883,26501,53003,30449,60899,34253,68507,26573,
            53147,30671,61343,34283,68567,26633,53267,30689,61379,34319,68639,26849,53699,30773,61547,34439,68879,
            26879,53759,30851,61703,34631,69263,26891,53783,30983,61967,34883,69767,26993,53987,31019,62039,34913,
            69827,27143,54287,31151,62303,34949,69899,27281,54563,31253,62507,35069,70139,27479,54959,31319,62639,
            35081,70163,27539,55079,31469,62939,35099,70199,27551,55103,31649,63299,35111,70223,27581,55163,31721,
            63443,35291,70583,27743,55487,31793,63587,35573,71147,27773,55547,31799,63599,35831,71663,27809,55619,
            31859,63719,35933,71867,27893,55787,32003,64007,35993,71987,27983,55967,32009,64019,35999,71999,28001,
            56003,32141,64283,36083,72167,28019,56039,32159,64319,36191,72383,28403,56807,32381,64763,36251,72503,
            28499,56999,32531,65063,36353,72707,28559,57119,32561,65123,36383,72767,28571,57143,32573,65147,36479,
            72959,28643,57287,32633,65267,36563,73127,28751,57503,32771,65543,36629,73259,36761,73523,39983,79967,
            44129,88259,36791,73583,39989,79979,44189,88379,36821,73643,40193,80387,44249,88499,36923,73847,40283,
            80567,44273,88547,36929,73859,40343,80687,44501,89003,37013,74027,40559,81119,44543,89087,37049,74099,
            40763,81527,44651,89303,37139,74279,40823,81647,44699,89399,37181,74363,40853,81707,44729,89459,37253,
            74507,40949,81899,44879,89759,37379,74759,41081,82163,44909,89819,37619,75239,41231,82463,45053,90107,
            37853,75707,41243,82487,45119,90239,37871,75743,41381,82763,45131,90263,37991,75983,41399,82799,45179,
            90359,38039,76079,41603,83207,45263,90527,38183,76367,41609,83219,45329,90659,38189,76379,41621,83243,
            45569,91139,38201,76403,41669,83339,45599,91199,38231,76463,41729,83459,45641,91283,38303,76607,41969,
            83939,45971,91943,38333,76667,42023,84047,46181,92363,38453,76907,42071,84143,46199,92399,38459,76919,
            42089,84179,46229,92459,38501,77003,42131,84263,46349,92699,38639,77279,42221,84443,46523,93047,38669,
            77339,42359,84719,46589,93179,38723,77447,42473,84947,46619,93239,38861,77723,42611,85223,46643,93287,
            38873,77747,42719,85439,46691,93383,38891,77783,42743,85487,46703,93407,38933,77867,42821,85643,46751,
            93503,39089,78179,42923,85847,47189,94379,39233,78467,43013,86027,47279,94559,39239,78479,43313,86627,
            47363,94727,39419,78839,43391,86783,47501,95003,39443,78887,43541,87083,47513,95027,39521,79043,43649,
            87299,47543,95087,39551,79103,43661,87323,47609,95219,39569,79139,43691,87383,47639,95279,39659,79319,
            43721,87443,47741,95483,39779,79559,43793,87587,48029,96059,39953,79907,43943,87887,48131,96263,39971,
            79943,44111,88223,48221,96443,48239,96479,52553,105107,56519,113039,48413,96827,52571,105143,56531,113063,
            48479,96959,52583,105167,56663,113327,48563,97127,52631,105263,56681,113363,48593,97187,52733,105467,56783,
            113567,48731,97463,52883,105767,56891,113783,48761,97523,53051,106103,56909,113819,49103,98207,53093,106187,
            56921,113843,49193,98387,53309,106619,56951,113903,49253,98507,53411,106823,57041,114083,49331,98663,53453,
            106907,57149,114299,49433,98867,53549,107099,57203,114407,49463,98927,53591,107183,57329,114659,49481,98963,
            53639,107279,57413,114827,49499,98999,53849,107699,57773,115547,49559,99119,53951,107903,57839,115679,49811,
            99623,54011,108023,57881,115763,49853,99707,54101,108203,58013,116027,49919,99839,54251,108503,58049,116099,
            50021,100043,54293,108587,58193,116387,50051,100103,54401,108803,58211,116423,50261,100523,54413,108827,58451,
            116903,50273,100547,54443,108887,58511,117023,50411,100823,54773,109547,58601,117203,50423,100847,54941,109883,
            58889,117779,50513,101027,54959,109919,58979,117959,50591,101183,55229,110459,59021,118043,50741,101483,55439,
            110879,59063,118127,50873,101747,55469,110939,59123,118247,50969,101939,55631,111263,59369,118739,50993,101987,
            55661,111323,59393,118787,51203,102407,55673,111347,59399,118799,51503,103007,55721,111443,59453,118907,51521,
            103043,55733,111467,59513,119027,51539,103079,55799,111599,59621,119243,51659,103319,55829,111659,59723,119447,
            51893,103787,55889,111779,59879,119759,52103,104207,55931,111863,59981,119963,52121,104243,56009,112019,60083,
            120167,52163,104327,56081,112163,60149,120299,52289,104579,56099,112199,60251,120503,52361,104723,56123,112247,
            60293,120587,52379,104759,56393,112787,60383,120767,52511,105023,56489,112979,60449,120899,60509,121019,65099,
            130199,69203,138407,60689,121379,65111,130223,69341,138683,60719,121439,65129,130259,69431,138863,60761,121523,
            65171,130343,69539,139079,60773,121547,65183,130367,69593,139187,60779,121559,65309,130619,69809,139619,61331,
            122663,65393,130787,69941,139883,61409,122819,65633,131267,70061,140123,61469,122939,65651,131303,70079,140159,
            61703,123407,65843,131687,70181,140363,61751,123503,65963,131927,70313,140627,61961,123923,66029,132059,70379,
            140759,61991,123983,66173,132347,70589,141179,62099,124199,66191,132383,70769,141539,62171,124343,66431,132863,
            70793,141587,62213,124427,66593,133187,70853,141707,62351,124703,66701,133403,70901,141803,62423,124847,66749,
            133499,70979,141959,62459,124919,66791,133583,71399,142799,62501,125003,66959,133919,71453,142907,62591,125183,
            67043,134087,71693,143387,62603,125207,67103,134207,71741,143483,62753,125507,67121,134243,71843,143687,62819,
            125639,67169,134339,71849,143699,62981,125963,67181,134363,71999,143999,63113,126227,67349,134699,72101,144203,
            63179,126359,67433,134867,72161,144323,63419,126839,67499,134999,72269,144539,63671,127343,67559,135119,72503,
            145007,63743,127487,67733,135467,72911,145823,63803,127607,67943,135887,73259,146519,63839,127679,68111,136223,
            73421,146843,63863,127727,68171,136343,73523,147047,63929,127859,68261,136523,73553,147107,64301,128603,68279,
            136559,73589,147179,64373,128747,68489,136979,73613,147227,64439,128879,68543,137087,73673,147347,64451,128903,
            68639,137279,73709,147419,64709,129419,68669,137339,73751,147503,64763,129527,68699,137399,73823,147647,64793,
            129587,68819,137639,74099,148199,64853,129707,68963,137927,74201,148403,64901,129803,69029,138059,74219,148439,
            65063,130127,69119,138239,74363,148727,74381,148763,78623,157247,82721,165443,74699,149399,78653,157307,82763,
            165527,74729,149459,78713,157427,82793,165587,74759,149519,78779,157559,82889,165779,74771,149543,78839,157679,
            83243,166487,74933,149867,79151,158303,83339,166679,75041,150083,79181,158363,83399,166799,75149,150299,79259,
            158519,83423,166847,75161,150323,79283,158567,83459,166919,75329,150659,79349,158699,83579,167159,75353,150707,
            79379,158759,83813,167627,75389,150779,79433,158867,83873,167747,75479,150959,79559,159119,83939,167879,75503,
            151007,79589,159179,84011,168023,75689,151379,79613,159227,84131,168263,75821,151643,79769,159539,84263,168527,
            75833,151667,79811,159623,84299,168599,75941,151883,79841,159683,84401,168803,75983,151967,79889,159779,84431,
            168863,76001,152003,80039,160079,84443,168887,76031,152063,80309,160619,84449,168899,76091,152183,80369,160739,
            84503,169007,76259,152519,80651,161303,84509,169019,76283,152567,80669,161339,84533,169067,76421,152843,80681,
            161363,84629,169259,76679,153359,80819,161639,84653,169307,76781,153563,81071,162143,84659,169319,76871,153743,
            81131,162263,84713,169427,76943,153887,81281,162563,84761,169523,77243,154487,81509,163019,85049,170099,77261,
            154523,81563,163127,85061,170123,77471,154943,81611,163223,85103,170207,77513,155027,81629,163259,85121,170243,
            77543,155087,81701,163403,85133,170267,77699,155399,81839,163679,85223,170447,77711,155423,81929,163859,85313,
            170627,77813,155627,82073,164147,85523,171047,77849,155699,82139,164279,85601,171203,78059,156119,82193,164387,
            85691,171383,78173,156347,82223,164447,85733,171467,78233,156467,82493,164987,85829,171659,78311,156623,82499,
            164999,85853,171707,78341,156683,82529,165059,85931,171863,78509,157019,82601,165203,86111,172223,86171,172343,
            91631,183263,96731,193463,86291,172583,91691,183383,96779,193559,86441,172883,91841,183683,96851,193703,86771,
            173543,92003,184007,96989,193979,86843,173687,92243,184487,97001,194003,87071,174143,92363,184727,97241,194483,
            87149,174299,92681,185363,97511,195023,87221,174443,92849,185699,97523,195047,87299,174599,92861,185723,97829,
            195659,87383,174767,92951,185903,97871,195743,87539,175079,92993,185987,97931,195863,87701,175403,93053,186107,
            97943,195887,87959,175919,93059,186119,98123,196247,88079,176159,93113,186227,98321,196643,88463,176927,93239,
            186479,98369,196739,88661,177323,93323,186647,98453,196907,88811,177623,93371,186743,98459,196919,88919,177839,
            93479,186959,98561,197123,89051,178103,93563,187127,98573,197147,89123,178247,93581,187163,98621,197243,89153,
            178307,93683,187367,98639,197279,89399,178799,93893,187787,98669,197339,89759,179519,93911,187823,98711,197423,
            89909,179819,93941,187883,98849,197699,90011,180023,94079,188159,98963,197927,90089,180179,94151,188303,98981,
            197963,90173,180347,94229,188459,99023,198047,90281,180563,94343,188687,99041,198083,90599,181199,94421,188843,
            99089,198179,90641,181283,94463,188927,99173,198347,90749,181499,95261,190523,99251,198503,90803,181607,95393,
            190787,99551,199103,90833,181667,95549,191099,99623,199247,90971,181943,95561,191123,99689,199379,91079,182159,
            95723,191447,99761,199523,91121,182243,95789,191579,99839,199679,91139,182279,95813,191627,91193,182387,95873,
            191747,91373,182747,95891,191783,91433,182867,96269,192539,91463,182927,96293,192587,91499,182999,96443,192887,
            91529,183059,96461,192923,91583,183167,96581,193163        };
    }
}
