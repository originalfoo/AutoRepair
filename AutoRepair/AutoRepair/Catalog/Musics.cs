namespace AutoRepair.Catalog {
    using Structs;
    using Enums;
    using Util;
    using System.Collections.Generic;
    using System;

    public class Musics {

        internal static Musics instance;
        public static Musics Instance => instance ?? (instance = new Musics());

        public Dictionary<ulong, ItemDetails> Lookup = new Dictionary<ulong, ItemDetails> { };

        Musics() {
            Log.Info("[Musics.ctor] Instantiating.");
            try {
                Populate();
            }
            catch (Exception e) {
                Log.Error($"ERROR [Musics.ctor] {e.Message}");
            }
        }

        internal static readonly ItemFlags flags = ItemFlags.Verified;
        internal static readonly string[] gameVer = { "1.11", "1.12" };
        internal static readonly ulong[] reqItems = { 422934383u }; // CSL Music mod required item

        internal void Add(ItemDetails info) {
            //Log.Info($"[Catalog.AddMod] {info.WorkshopId} = {info.Name}");
            if (info.WorkshopId == 0u) {
                Log.Info($"ERROR [Musics.Add] Workshop ID is missing: 0u ({info.Name})");
                return;
            }
            if (Lookup.ContainsKey(info.WorkshopId)) {
                Log.Info($"ERROR [Musics.Add] Duplicate key: {info.WorkshopId} ({info.Name})");
                return;
            }
            if (info.Categories != null) {
                Log.Info($"ERROR [Musics.Add] Do not define categories for music: {info.WorkshopId} ({info.Name})");
                return;
            }
            if (Mods.Instance.Lookup.ContainsKey(info.WorkshopId)) {
                Log.Info($"ERROR [Musics.Add] Music is must not be in Mods lookup: {info.WorkshopId} ({info.Name})");
                return;
            }

            info.Flags = info.Flags == 0 ? flags : info.Flags;
            info.GameVersion = gameVer;
            info.RequiredItems = reqItems;

            Lookup.Add(info.WorkshopId, info);
        }

        internal void Populate() {
            Log.Info("[Musics.Populate] Populating lookup dictionary.");

            // most recent first

            Add(new ItemDetails {
                WorkshopId = 1860387063,
                Name = "Metropolis FM - Curated Electronic Music Radio",
                //Flags = flags, GameVersion = gameVer, RequiredItems = CslMusicId,
            });

            Add(new ItemDetails {
                WorkshopId = 1849251185,
                Name = "메이플 스토리 브금 MapleStory Music pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1849248489,
                Name = "NEED FOR SPEED Most Wanted 2012 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1836790997,
                Name = "Ninety9Lives FM (A Custom CSL Music Station with ‭296 songs!‬)",
            });

            Add(new ItemDetails {
                WorkshopId = 1836775697,
                Name = "Arcadia Bay Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1831829697,
                Name = "The Easy Listening Station",
            });

            Add(new ItemDetails {
                WorkshopId = 1830608003,
                Name = "The Sims 4 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1822078418,
                Name = "Music Pack: Chillhop Essentials - Summer 2019",
            });

            Add(new ItemDetails {
                WorkshopId = 1814563985,
                Name = "AfroBeat4CSL",
            });

            Add(new ItemDetails {
                WorkshopId = 1794625110,
                Name = "Music Pack: JazzHop Cafe - Spring Mix 2019",
            });

            Add(new ItemDetails {
                WorkshopId = 1791020927,
                Name = "SimCity (2013) + Cities of Tomorrow Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1787333298,
                Name = "Lil Peep Music pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1780166508,
                Name = "Ace Combat Music",
            });

            Add(new ItemDetails {
                WorkshopId = 1774745517,
                Name = "Classics",
            });

            Add(new ItemDetails {
                WorkshopId = 1771297364,
                Name = "Mr. Monday's Metal Mania Mix Vol. 11",
            });

            Add(new ItemDetails {
                WorkshopId = 1764607719,
                Name = "Mr. Monday's Metal Mania Mix Vol. 10",
            });

            Add(new ItemDetails {
                WorkshopId = 1764430171,
                Name = "Shostakovich_Symphoneies_Music_Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1764130877,
                Name = "Shostakovich_String_Quartets_Music_Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1762692942,
                Name = "Mr. Monday's Metal Mania Mix Vol. 9",
            });

            Add(new ItemDetails {
                WorkshopId = 1761203207,
                Name = "Mr. Monday's Metal Mania Mix Vol. 8",
            });

            Add(new ItemDetails {
                WorkshopId = 1758033583,
                Name = "Soviet Music FM CSL Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1749984376,
                Name = "Mr. Monday's Metal Mania Mix Vol. 7",
            });

            Add(new ItemDetails {
                WorkshopId = 1749674478,
                Name = "Mr. Monday's Metal Mania Mix Vol. 6",
            });

            Add(new ItemDetails {
                WorkshopId = 1747687461,
                Name = "Mr. Monday's Metal Mania Vol. 5",
            });

            Add(new ItemDetails {
                WorkshopId = 1746755744,
                Name = "Mr. Monday's Metal Mania Vol. 4",
            });

            Add(new ItemDetails {
                WorkshopId = 1745927147,
                Name = "Music Pack - Crash FM: Burnout Paradise",
            });

            Add(new ItemDetails {
                WorkshopId = 1745924501,
                Name = "Music Pack - Crash FM: Burnout Revenge",
            });

            Add(new ItemDetails {
                WorkshopId = 1745921826,
                Name = "Music Pack - Crash FM - Burnout 3",
            });

            Add(new ItemDetails {
                WorkshopId = 1745918041,
                Name = "Music Pack - Fallout 76 - Appalachia Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1745397514,
                Name = "Mr. Monday's Metal Mania Mix Vol. 3",
            });

            Add(new ItemDetails {
                WorkshopId = 1744768948,
                Name = "Tsargrad Russian Imperial radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1744288199,
                Name = "Blast Corps",
            });

            Add(new ItemDetails {
                WorkshopId = 1744275985,
                Name = "Mr. Monday's Metal Mania Mix Vol. 2",
            });

            Add(new ItemDetails {
                WorkshopId = 1744060785,
                Name = "C&C Red Alert Retaliation Music",
            });

            Add(new ItemDetails {
                WorkshopId = 1743852125,
                Name = "Mr. Monday's Metal Mania Mix Vol. 1",
            });

            Add(new ItemDetails {
                WorkshopId = 1740593354,
                Name = "BABYMETAL Radio (Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1737797719,
                Name = "Opeth Radio (Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1716463067,
                Name = "Stardew Valley: CSL Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1695888523,
                Name = "Gutter Radio Station - Metal Music",
            });

            Add(new ItemDetails {
                WorkshopId = 1693073075,
                Name = "Morioh Cho Radio(Jojo Radio Station)",
            });

            Add(new ItemDetails {
                WorkshopId = 1676346063,
                Name = "R4: Ridge Racer Type 4 OST Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1667955065,
                Name = "Starcraft Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1667954427,
                Name = "Starcraft Vol 1 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1666843975,
                Name = "DarkAmbient_rythmical_",
            });

            Add(new ItemDetails {
                WorkshopId = 1666828843,
                Name = "DarkAmbient_calming_",
            });

            Add(new ItemDetails {
                WorkshopId = 1662935352,
                Name = "Your Local on The 98.8's",
            });

            Add(new ItemDetails {
                WorkshopId = 1656737510,
                Name = "YIMBY Radio (Yes In My Backyard)",
            });

            Add(new ItemDetails {
                WorkshopId = 1608576363,
                Name = "OpenTTD Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1599088128,
                Name = "Mayor Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1588118049,
                Name = "Music Pack: Free For Use Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1583013403,
                Name = "Music Pack: LineageII Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1582786251,
                Name = "Music Pack: ShenzhenIO Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1581924890,
                Name = "Music Pack: Spyro Reignited Trilogy - Complete OST",
            });

            Add(new ItemDetails {
                WorkshopId = 1581529605,
                Name = "Spotify - All Out 00s",
            });

            Add(new ItemDetails {
                WorkshopId = 1581222201,
                Name = "Music Pack: Laura Brehm (Progressive House)",
            });

            Add(new ItemDetails {
                WorkshopId = 1580837351,
                Name = "Music Pack: Club MTV - Dance Anthems",
            });

            Add(new ItemDetails {
                WorkshopId = 1578138249,
                Name = "Music Pack: Minecraft Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1577301964,
                Name = "Music Pack: Chillhop Essentials Fall 2018",
            });

            Add(new ItemDetails {
                WorkshopId = 1574901147,
                Name = "Only Anistep for CSL MUSIC",
            });

            Add(new ItemDetails {
                WorkshopId = 1574616741,
                Name = "Music Pack: The Jazz Hop Cafe - Jazzhop Christmas",
            });

            Add(new ItemDetails {
                WorkshopId = 1574204018,
                Name = "Music Pack: The Jazz Hop Cafe - Lofi Christmas",
            });

            Add(new ItemDetails {
                WorkshopId = 1573686513,
                Name = "Music Pack: Vladivostok FM (TBOGT)",
            });

            Add(new ItemDetails {
                WorkshopId = 1573683382,
                Name = "Music Pack: Electro-Choc (TBOGT)",
            });

            Add(new ItemDetails {
                WorkshopId = 1569009943,
                Name = "Faith Radio - Радио Вера",
            });

            Add(new ItemDetails {
                WorkshopId = 1568910950,
                Name = "Zone radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1566293203,
                Name = "NIGHTFALL RADIO",
            });

            Add(new ItemDetails {
                WorkshopId = 1565992217,
                Name = "Mirror's Edge Catalyst Ambience Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1564632871,
                Name = "Los Santos Rock Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1563236161,
                Name = "Non Stop Pop FM",
            });

            Add(new ItemDetails {
                WorkshopId = 1562159034,
                Name = "Pokemon Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1551413082,
                Name = "Sunless Radio - CSL Music Mod",
            });

            Add(new ItemDetails {
                WorkshopId = 1551254449,
                Name = "Factorio Radio - CSL Music Mod",
            });

            Add(new ItemDetails {
                WorkshopId = 1549204922,
                Name = "Liberty Rock Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1549159888,
                Name = "K-Rose Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1544343001,
                Name = "Evil Needle Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1533463444,
                Name = "[CSLMM] Wave City Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1527318643,
                Name = "K-ZUN Touhou Jazz CSL Music Station",
            });

            Add(new ItemDetails {
                WorkshopId = 1521439327,
                Name = "Need For Speed Hot Pursuit II Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1521382830,
                Name = "Need For Speed Porsche Unleashed Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1521316560,
                Name = "Need For Speed High Stakes Soundtrack Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1521193646,
                Name = "Need For Speed III Hot Pursuit Soundtrack Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1520526038,
                Name = "Need For Speed II SE Soundtrack Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1520422010,
                Name = "Need For Speed SE (1994) Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1515080990,
                Name = "The Sims 2 Music Mod",
            });

            Add(new ItemDetails {
                WorkshopId = 1468593438,
                Name = "Simcity Cities of Tomorrow music pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1448884662,
                Name = "ROCK FM",
            });

            Add(new ItemDetails {
                WorkshopId = 1412112969,
                Name = "Granado Espada Music Pack 2",
            });

            Add(new ItemDetails {
                WorkshopId = 1412098032,
                Name = "Granado Espada Music Pack 3",
            });

            Add(new ItemDetails {
                WorkshopId = 1411460758,
                Name = "Granado Espada Music Pack 1",
            });

            Add(new ItemDetails {
                WorkshopId = 1400137014,
                Name = "Music pack: Everyone's Music",
            });

            Add(new ItemDetails {
                WorkshopId = 1394707020,
                Name = "SimCity 4 Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1372895052,
                Name = "The Soviet Music Pack (Советский музыкальный пакет)",
            });

            Add(new ItemDetails {
                WorkshopId = 1364831709,
                Name = "CSL Music Mod - Alledion's Mega Electronic Mix",
            });

            Add(new ItemDetails {
                WorkshopId = 1363527827,
                Name = "Eurodance Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1357175278,
                Name = "Music Pack: College Music",
            });

            Add(new ItemDetails {
                WorkshopId = 1351895231,
                Name = "Little Witch Academia OST (Music pack)",
            });

            Add(new ItemDetails {
                WorkshopId = 1347144721,
                Name = "Music Pack: DiscoverTheVibes",
            });

            Add(new ItemDetails {
                WorkshopId = 1344820938,
                Name = "Music Pack: Sonic Heroes OST",
            });

            Add(new ItemDetails {
                WorkshopId = 1342303998,
                Name = "Music Pack: SoundBucket - Good Vibes",
            });

            Add(new ItemDetails {
                WorkshopId = 1339803856,
                Name = "Music Pack: Monstercat - Glitch Hop",
            });

            Add(new ItemDetails {
                WorkshopId = 1338802022,
                Name = "Music Pack: Proximity",
            });

            Add(new ItemDetails {
                WorkshopId = 1336375564,
                Name = "Music Pack: 70s, 80s & 90s",
            });

            Add(new ItemDetails {
                WorkshopId = 1336014597,
                Name = "Music Pack: Selected Summer",
            });

            Add(new ItemDetails {
                WorkshopId = 1335338525,
                Name = "Music Pack: Back To The 80s - Retro/Synthwave",
            });

            Add(new ItemDetails {
                WorkshopId = 1326517757,
                Name = "Anno 2205 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1316514636,
                Name = "Malt Shop Mayhem CSL Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1312768486,
                Name = "SC2K Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1303848789,
                Name = "Sim City 3000 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1301578707,
                Name = "Need For Speed ProStreet Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1301453082,
                Name = "Need For Speed Carbon Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1301340848,
                Name = "Need for Speed Most Wanted Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1301203414,
                Name = "Need for Speed Underground 2 Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1300220114,
                Name = "Need for Speed: Underground Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299598752,
                Name = "The Sims Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299543983,
                Name = "Spyro 2: Ripto's Rage Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299482532,
                Name = "Spyro the Dragon Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299441079,
                Name = "Fallout 4 Soundtrack ft. Lynda Carter Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299341271,
                Name = "Fallout 4 Music from Far Harbor & Nuka World Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299305365,
                Name = "Fallout 4 Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299264263,
                Name = "Fallout New Vegas Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299154413,
                Name = "Fallout 3 Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1295761551,
                Name = "Hardstyle Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1295091678,
                Name = "The Sims 3 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1289991722,
                Name = "Vault Archives Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1286392160,
                Name = "Thievery Corporation FM",
            });

            Add(new ItemDetails {
                WorkshopId = 1251036114,
                Name = "Variety Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1235243107,
                Name = "Victoria II Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1217204348,
                Name = "SimCity2000 (DOS) Soundtrack (CSL Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1207856769,
                Name = "Cafe Ambient Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1207763962,
                Name = "SimCity SNES Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1175184387,
                Name = "CSL Music Pack:More-Beats-Album",
            });

            Add(new ItemDetails {
                WorkshopId = 1169775083,
                Name = "Bolbbalgan4 - Red Diary Page.1 (CSL Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1162154876,
                Name = "Final Fantasy VII music soundtrack",
            });

            Add(new ItemDetails {
                WorkshopId = 1156097512,
                Name = "CSL Music Mod: Michael Jackson Greatest Hits!",
            });

            Add(new ItemDetails {
                WorkshopId = 1151983896,
                Name = "KMVS 121.5",
            });

            Add(new ItemDetails {
                WorkshopId = 1136663754,
                Name = "[CSLMM] Bean City Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1134666165,
                Name = "Fox River Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1133209057,
                Name = "NCS House Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1126230172,
                Name = "CSL Music Mod - MusicPack : GNR",
            });

            Add(new ItemDetails {
                WorkshopId = 1116749094,
                Name = "Bolbbalgan4 - Tell Me You Love Me (CSL Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1115835934,
                Name = "Bolbbalgan4 - Red Planet (CSL Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1112471996,
                Name = "Kevin MacLeod Music pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1112338965,
                Name = "Chillhop Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1111498300,
                Name = "Soviet music pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1081461443,
                Name = "Music Pack: Sapporossive",
            });

            Add(new ItemDetails {
                WorkshopId = 1081195940,
                Name = "CSL Music Pack: Wallbass FM",
            });

            Add(new ItemDetails {
                WorkshopId = 972594063,
                Name = "Hotline Miami Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 971298487,
                Name = "GTA5 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 933535612,
                Name = "JOUKINAMI FM (Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 927548915,
                Name = "CSL Music Pack: NCS by PHTN Gaming",
            });

            Add(new ItemDetails {
                WorkshopId = 887074370,
                Name = "Music Pack: CitiesSynthPop (NEW SONGS)",
            });

            Add(new ItemDetails {
                WorkshopId = 883413573,
                Name = "CSL Music Pack: Vibrance Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 835379029,
                Name = "SimCopter Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 769222865,
                Name = "World of Warships Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 718886717,
                Name = "Anno 2070 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 718788719,
                Name = "Playstation Sim City 2000 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 638395703,
                Name = "Sim City Societies Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 636461221,
                Name = "Music from Transport Tycoon Deluxe (Fixed)",
            });

            Add(new ItemDetails {
                WorkshopId = 634216395,
                Name = "Sim City (2013) Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 634143359,
                Name = "Sim City 2000 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 634046315,
                Name = "Sim City 3000 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 633993845,
                Name = "Sim City 4 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 476141470,
                Name = "MusicPack: 80s Synthwave",
            });

            Add(new ItemDetails {
                WorkshopId = 464840482,
                Name = "epic city building song",
            });

            Add(new ItemDetails {
                WorkshopId = 462938240,
                Name = "Banjo Kazooie CSL Music Pack pt.2",
            });

            Add(new ItemDetails {
                WorkshopId = 462924840,
                Name = "KOGNITIF-Soul Food",
            });

            Add(new ItemDetails {
                WorkshopId = 458117789,
                Name = "Mozart Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 457496789,
                Name = "Zak McCracken Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 457493834,
                Name = "Romeo & Juliet Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 457317144,
                Name = "Beethoven Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 457184378,
                Name = "Hipster Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 456200016,
                Name = "Bach Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 456044944,
                Name = "Banjo Kazooie CSL Music Pack pt.1",
            });

            Add(new ItemDetails {
                WorkshopId = 455729185,
                Name = "Green~T Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 453161669,
                Name = "TH RemasteredMusicPack",
            });

            Add(new ItemDetails {
                WorkshopId = 429241674,
                Name = "MusicPack: Experimental Collection 2",
            });

            Add(new ItemDetails {
                WorkshopId = 425299246,
                Name = "Music Pack: Experimental Collection 1",
            });

        }
    }
}
