using AutoRepair.Structs;
using AutoRepair.Enums;
using AutoRepair.Util;
using System.Collections.Generic;
using System;

namespace AutoRepair.Catalogs {
    public class Musics {

        internal static Musics instance;
        public static Musics Instance => instance ?? (instance = new Musics());

        public Dictionary<ulong, ItemDetails> Lookup = new Dictionary<ulong, ItemDetails> { };

        Musics() {
            Log.Info("[Musics.ctor] Instantiating.");
            try {
                Populate();
                Log.Info($"[Musics.Lookup] {Lookup.Count} items defined");
            }
            catch (Exception e) {
                Log.Error($"ERROR [Musics.ctor] {e.Message}");
            }
        }

        internal static readonly ItemFlags flags = ItemFlags.Verified;
        internal static readonly string[] gameVer = { "1.11", "1.12" };
        internal static readonly ulong[] reqItems = { 422934383u }; // CSL Music mod required item
        internal static readonly string[] noCats = { };

        internal void Add(ItemDetails info) {
            //Log.Info($"[Catalog.AddMod] {info.WorkshopId} = {info.Name}");
            if (info.WorkshopId == 0u) {
                Log.Info($"ERROR [Musics.Add] Workshop ID is missing: 0u ({info.WorkshopName})");
                return;
            }
            if (Lookup.ContainsKey(info.WorkshopId)) {
                Log.Info($"ERROR [Musics.Add] Duplicate key: {info.WorkshopId} ({info.WorkshopName})");
                return;
            }
            if (Mods.Instance.Lookup.ContainsKey(info.WorkshopId)) {
                Log.Info($"ERROR [Musics.Add] Music is must not be in Mods lookup: {info.WorkshopId} ({info.WorkshopName})");
                return;
            }
            if (info.Categories != null) {
                Log.Info($"WARNING [Musics.Add] Do not define categories for music: {info.WorkshopId} ({info.WorkshopName})");
            }

            info.ItemType = ItemTypes.Music;
            info.Flags = info.Flags == 0 ? flags : info.Flags;
            info.Categories = noCats;
            info.GameVersion = gameVer;
            info.RequiredItems = reqItems;

            Lookup.Add(info.WorkshopId, info);
        }

        internal void Populate() {
            Log.Info("[Musics.Populate] Populating lookup dictionary.");

            // most recent first

            Add(new ItemDetails {
                WorkshopId = 1860387063,
                WorkshopName = "Metropolis FM - Curated Electronic Music Radio",
                //Flags = flags, GameVersion = gameVer, RequiredItems = CslMusicId,
            });

            Add(new ItemDetails {
                WorkshopId = 1849251185,
                WorkshopName = "메이플 스토리 브금 MapleStory Music pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1849248489,
                WorkshopName = "NEED FOR SPEED Most Wanted 2012 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1836790997,
                WorkshopName = "Ninety9Lives FM (A Custom CSL Music Station with ‭296 songs!‬)",
            });

            Add(new ItemDetails {
                WorkshopId = 1836775697,
                WorkshopName = "Arcadia Bay Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1831829697,
                WorkshopName = "The Easy Listening Station",
            });

            Add(new ItemDetails {
                WorkshopId = 1830608003,
                WorkshopName = "The Sims 4 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1822078418,
                WorkshopName = "Music Pack: Chillhop Essentials - Summer 2019",
            });

            Add(new ItemDetails {
                WorkshopId = 1814563985,
                WorkshopName = "AfroBeat4CSL",
            });

            Add(new ItemDetails {
                WorkshopId = 1794625110,
                WorkshopName = "Music Pack: JazzHop Cafe - Spring Mix 2019",
            });

            Add(new ItemDetails {
                WorkshopId = 1791020927,
                WorkshopName = "SimCity (2013) + Cities of Tomorrow Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1787333298,
                WorkshopName = "Lil Peep Music pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1780166508,
                WorkshopName = "Ace Combat Music",
            });

            Add(new ItemDetails {
                WorkshopId = 1774745517,
                WorkshopName = "Classics",
            });

            Add(new ItemDetails {
                WorkshopId = 1771297364,
                WorkshopName = "Mr. Monday's Metal Mania Mix Vol. 11",
            });

            Add(new ItemDetails {
                WorkshopId = 1764607719,
                WorkshopName = "Mr. Monday's Metal Mania Mix Vol. 10",
            });

            Add(new ItemDetails {
                WorkshopId = 1764430171,
                WorkshopName = "Shostakovich_Symphoneies_Music_Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1764130877,
                WorkshopName = "Shostakovich_String_Quartets_Music_Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1762692942,
                WorkshopName = "Mr. Monday's Metal Mania Mix Vol. 9",
            });

            Add(new ItemDetails {
                WorkshopId = 1761203207,
                WorkshopName = "Mr. Monday's Metal Mania Mix Vol. 8",
            });

            Add(new ItemDetails {
                WorkshopId = 1758033583,
                WorkshopName = "Soviet Music FM CSL Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1749984376,
                WorkshopName = "Mr. Monday's Metal Mania Mix Vol. 7",
            });

            Add(new ItemDetails {
                WorkshopId = 1749674478,
                WorkshopName = "Mr. Monday's Metal Mania Mix Vol. 6",
            });

            Add(new ItemDetails {
                WorkshopId = 1747687461,
                WorkshopName = "Mr. Monday's Metal Mania Vol. 5",
            });

            Add(new ItemDetails {
                WorkshopId = 1746755744,
                WorkshopName = "Mr. Monday's Metal Mania Vol. 4",
            });

            Add(new ItemDetails {
                WorkshopId = 1745927147,
                WorkshopName = "Music Pack - Crash FM: Burnout Paradise",
            });

            Add(new ItemDetails {
                WorkshopId = 1745924501,
                WorkshopName = "Music Pack - Crash FM: Burnout Revenge",
            });

            Add(new ItemDetails {
                WorkshopId = 1745921826,
                WorkshopName = "Music Pack - Crash FM - Burnout 3",
            });

            Add(new ItemDetails {
                WorkshopId = 1745918041,
                WorkshopName = "Music Pack - Fallout 76 - Appalachia Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1745397514,
                WorkshopName = "Mr. Monday's Metal Mania Mix Vol. 3",
            });

            Add(new ItemDetails {
                WorkshopId = 1744768948,
                WorkshopName = "Tsargrad Russian Imperial radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1744288199,
                WorkshopName = "Blast Corps",
            });

            Add(new ItemDetails {
                WorkshopId = 1744275985,
                WorkshopName = "Mr. Monday's Metal Mania Mix Vol. 2",
            });

            Add(new ItemDetails {
                WorkshopId = 1744060785,
                WorkshopName = "C&C Red Alert Retaliation Music",
            });

            Add(new ItemDetails {
                WorkshopId = 1743852125,
                WorkshopName = "Mr. Monday's Metal Mania Mix Vol. 1",
            });

            Add(new ItemDetails {
                WorkshopId = 1740593354,
                WorkshopName = "BABYMETAL Radio (Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1737797719,
                WorkshopName = "Opeth Radio (Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1716463067,
                WorkshopName = "Stardew Valley: CSL Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1695888523,
                WorkshopName = "Gutter Radio Station - Metal Music",
            });

            Add(new ItemDetails {
                WorkshopId = 1693073075,
                WorkshopName = "Morioh Cho Radio(Jojo Radio Station)",
            });

            Add(new ItemDetails {
                WorkshopId = 1676346063,
                WorkshopName = "R4: Ridge Racer Type 4 OST Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1667955065,
                WorkshopName = "Starcraft Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1667954427,
                WorkshopName = "Starcraft Vol 1 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1666843975,
                WorkshopName = "DarkAmbient_rythmical_",
            });

            Add(new ItemDetails {
                WorkshopId = 1666828843,
                WorkshopName = "DarkAmbient_calming_",
            });

            Add(new ItemDetails {
                WorkshopId = 1662935352,
                WorkshopName = "Your Local on The 98.8's",
            });

            Add(new ItemDetails {
                WorkshopId = 1656737510,
                WorkshopName = "YIMBY Radio (Yes In My Backyard)",
            });

            Add(new ItemDetails {
                WorkshopId = 1608576363,
                WorkshopName = "OpenTTD Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1599088128,
                WorkshopName = "Mayor Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1588118049,
                WorkshopName = "Music Pack: Free For Use Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1583013403,
                WorkshopName = "Music Pack: LineageII Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1582786251,
                WorkshopName = "Music Pack: ShenzhenIO Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1581924890,
                WorkshopName = "Music Pack: Spyro Reignited Trilogy - Complete OST",
            });

            Add(new ItemDetails {
                WorkshopId = 1581529605,
                WorkshopName = "Spotify - All Out 00s",
            });

            Add(new ItemDetails {
                WorkshopId = 1581222201,
                WorkshopName = "Music Pack: Laura Brehm (Progressive House)",
            });

            Add(new ItemDetails {
                WorkshopId = 1580837351,
                WorkshopName = "Music Pack: Club MTV - Dance Anthems",
            });

            Add(new ItemDetails {
                WorkshopId = 1578138249,
                WorkshopName = "Music Pack: Minecraft Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1577301964,
                WorkshopName = "Music Pack: Chillhop Essentials Fall 2018",
            });

            Add(new ItemDetails {
                WorkshopId = 1574901147,
                WorkshopName = "Only Anistep for CSL MUSIC",
            });

            Add(new ItemDetails {
                WorkshopId = 1574616741,
                WorkshopName = "Music Pack: The Jazz Hop Cafe - Jazzhop Christmas",
            });

            Add(new ItemDetails {
                WorkshopId = 1574204018,
                WorkshopName = "Music Pack: The Jazz Hop Cafe - Lofi Christmas",
            });

            Add(new ItemDetails {
                WorkshopId = 1573686513,
                WorkshopName = "Music Pack: Vladivostok FM (TBOGT)",
            });

            Add(new ItemDetails {
                WorkshopId = 1573683382,
                WorkshopName = "Music Pack: Electro-Choc (TBOGT)",
            });

            Add(new ItemDetails {
                WorkshopId = 1569009943,
                WorkshopName = "Faith Radio - Радио Вера",
            });

            Add(new ItemDetails {
                WorkshopId = 1568910950,
                WorkshopName = "Zone radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1566293203,
                WorkshopName = "NIGHTFALL RADIO",
            });

            Add(new ItemDetails {
                WorkshopId = 1565992217,
                WorkshopName = "Mirror's Edge Catalyst Ambience Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1564632871,
                WorkshopName = "Los Santos Rock Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1563236161,
                WorkshopName = "Non Stop Pop FM",
            });

            Add(new ItemDetails {
                WorkshopId = 1562159034,
                WorkshopName = "Pokemon Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1551413082,
                WorkshopName = "Sunless Radio - CSL Music Mod",
            });

            Add(new ItemDetails {
                WorkshopId = 1551254449,
                WorkshopName = "Factorio Radio - CSL Music Mod",
            });

            Add(new ItemDetails {
                WorkshopId = 1549204922,
                WorkshopName = "Liberty Rock Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1549159888,
                WorkshopName = "K-Rose Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1544343001,
                WorkshopName = "Evil Needle Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1533463444,
                WorkshopName = "[CSLMM] Wave City Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1527318643,
                WorkshopName = "K-ZUN Touhou Jazz CSL Music Station",
            });

            Add(new ItemDetails {
                WorkshopId = 1521439327,
                WorkshopName = "Need For Speed Hot Pursuit II Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1521382830,
                WorkshopName = "Need For Speed Porsche Unleashed Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1521316560,
                WorkshopName = "Need For Speed High Stakes Soundtrack Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1521193646,
                WorkshopName = "Need For Speed III Hot Pursuit Soundtrack Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1520526038,
                WorkshopName = "Need For Speed II SE Soundtrack Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1520422010,
                WorkshopName = "Need For Speed SE (1994) Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1515080990,
                WorkshopName = "The Sims 2 Music Mod",
            });

            Add(new ItemDetails {
                WorkshopId = 1468593438,
                WorkshopName = "Simcity Cities of Tomorrow music pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1448884662,
                WorkshopName = "ROCK FM",
            });

            Add(new ItemDetails {
                WorkshopId = 1412112969,
                WorkshopName = "Granado Espada Music Pack 2",
            });

            Add(new ItemDetails {
                WorkshopId = 1412098032,
                WorkshopName = "Granado Espada Music Pack 3",
            });

            Add(new ItemDetails {
                WorkshopId = 1411460758,
                WorkshopName = "Granado Espada Music Pack 1",
            });

            Add(new ItemDetails {
                WorkshopId = 1400137014,
                WorkshopName = "Music pack: Everyone's Music",
            });

            Add(new ItemDetails {
                WorkshopId = 1394707020,
                WorkshopName = "SimCity 4 Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1372895052,
                WorkshopName = "The Soviet Music Pack (Советский музыкальный пакет)",
            });

            Add(new ItemDetails {
                WorkshopId = 1364831709,
                WorkshopName = "CSL Music Mod - Alledion's Mega Electronic Mix",
            });

            Add(new ItemDetails {
                WorkshopId = 1363527827,
                WorkshopName = "Eurodance Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1357175278,
                WorkshopName = "Music Pack: College Music",
            });

            Add(new ItemDetails {
                WorkshopId = 1351895231,
                WorkshopName = "Little Witch Academia OST (Music pack)",
            });

            Add(new ItemDetails {
                WorkshopId = 1347144721,
                WorkshopName = "Music Pack: DiscoverTheVibes",
            });

            Add(new ItemDetails {
                WorkshopId = 1344820938,
                WorkshopName = "Music Pack: Sonic Heroes OST",
            });

            Add(new ItemDetails {
                WorkshopId = 1342303998,
                WorkshopName = "Music Pack: SoundBucket - Good Vibes",
            });

            Add(new ItemDetails {
                WorkshopId = 1339803856,
                WorkshopName = "Music Pack: Monstercat - Glitch Hop",
            });

            Add(new ItemDetails {
                WorkshopId = 1338802022,
                WorkshopName = "Music Pack: Proximity",
            });

            Add(new ItemDetails {
                WorkshopId = 1336375564,
                WorkshopName = "Music Pack: 70s, 80s & 90s",
            });

            Add(new ItemDetails {
                WorkshopId = 1336014597,
                WorkshopName = "Music Pack: Selected Summer",
            });

            Add(new ItemDetails {
                WorkshopId = 1335338525,
                WorkshopName = "Music Pack: Back To The 80s - Retro/Synthwave",
            });

            Add(new ItemDetails {
                WorkshopId = 1326517757,
                WorkshopName = "Anno 2205 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1316514636,
                WorkshopName = "Malt Shop Mayhem CSL Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1312768486,
                WorkshopName = "SC2K Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1303848789,
                WorkshopName = "Sim City 3000 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1301578707,
                WorkshopName = "Need For Speed ProStreet Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1301453082,
                WorkshopName = "Need For Speed Carbon Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1301340848,
                WorkshopName = "Need for Speed Most Wanted Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1301203414,
                WorkshopName = "Need for Speed Underground 2 Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1300220114,
                WorkshopName = "Need for Speed: Underground Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299598752,
                WorkshopName = "The Sims Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299543983,
                WorkshopName = "Spyro 2: Ripto's Rage Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299482532,
                WorkshopName = "Spyro the Dragon Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299441079,
                WorkshopName = "Fallout 4 Soundtrack ft. Lynda Carter Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299341271,
                WorkshopName = "Fallout 4 Music from Far Harbor & Nuka World Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299305365,
                WorkshopName = "Fallout 4 Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299264263,
                WorkshopName = "Fallout New Vegas Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1299154413,
                WorkshopName = "Fallout 3 Soundtrack Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1295761551,
                WorkshopName = "Hardstyle Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1295091678,
                WorkshopName = "The Sims 3 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1289991722,
                WorkshopName = "Vault Archives Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1286392160,
                WorkshopName = "Thievery Corporation FM",
            });

            Add(new ItemDetails {
                WorkshopId = 1251036114,
                WorkshopName = "Variety Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1235243107,
                WorkshopName = "Victoria II Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1217204348,
                WorkshopName = "SimCity2000 (DOS) Soundtrack (CSL Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1207856769,
                WorkshopName = "Cafe Ambient Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1207763962,
                WorkshopName = "SimCity SNES Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1175184387,
                WorkshopName = "CSL Music Pack:More-Beats-Album",
            });

            Add(new ItemDetails {
                WorkshopId = 1169775083,
                WorkshopName = "Bolbbalgan4 - Red Diary Page.1 (CSL Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1162154876,
                WorkshopName = "Final Fantasy VII music soundtrack",
            });

            Add(new ItemDetails {
                WorkshopId = 1156097512,
                WorkshopName = "CSL Music Mod: Michael Jackson Greatest Hits!",
            });

            Add(new ItemDetails {
                WorkshopId = 1151983896,
                WorkshopName = "KMVS 121.5",
            });

            Add(new ItemDetails {
                WorkshopId = 1136663754,
                WorkshopName = "[CSLMM] Bean City Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1134666165,
                WorkshopName = "Fox River Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1133209057,
                WorkshopName = "NCS House Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 1126230172,
                WorkshopName = "CSL Music Mod - MusicPack : GNR",
            });

            Add(new ItemDetails {
                WorkshopId = 1116749094,
                WorkshopName = "Bolbbalgan4 - Tell Me You Love Me (CSL Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1115835934,
                WorkshopName = "Bolbbalgan4 - Red Planet (CSL Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 1112471996,
                WorkshopName = "Kevin MacLeod Music pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1112338965,
                WorkshopName = "Chillhop Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1111498300,
                WorkshopName = "Soviet music pack",
            });

            Add(new ItemDetails {
                WorkshopId = 1081461443,
                WorkshopName = "Music Pack: Sapporossive",
            });

            Add(new ItemDetails {
                WorkshopId = 1081195940,
                WorkshopName = "CSL Music Pack: Wallbass FM",
            });

            Add(new ItemDetails {
                WorkshopId = 972594063,
                WorkshopName = "Hotline Miami Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 971298487,
                WorkshopName = "GTA5 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 933535612,
                WorkshopName = "JOUKINAMI FM (Music Mod)",
            });

            Add(new ItemDetails {
                WorkshopId = 927548915,
                WorkshopName = "CSL Music Pack: NCS by PHTN Gaming",
            });

            Add(new ItemDetails {
                WorkshopId = 887074370,
                WorkshopName = "Music Pack: CitiesSynthPop (NEW SONGS)",
            });

            Add(new ItemDetails {
                WorkshopId = 883413573,
                WorkshopName = "CSL Music Pack: Vibrance Radio",
            });

            Add(new ItemDetails {
                WorkshopId = 835379029,
                WorkshopName = "SimCopter Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 769222865,
                WorkshopName = "World of Warships Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 718886717,
                WorkshopName = "Anno 2070 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 718788719,
                WorkshopName = "Playstation Sim City 2000 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 638395703,
                WorkshopName = "Sim City Societies Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 636461221,
                WorkshopName = "Music from Transport Tycoon Deluxe (Fixed)",
            });

            Add(new ItemDetails {
                WorkshopId = 634216395,
                WorkshopName = "Sim City (2013) Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 634143359,
                WorkshopName = "Sim City 2000 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 634046315,
                WorkshopName = "Sim City 3000 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 633993845,
                WorkshopName = "Sim City 4 Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 476141470,
                WorkshopName = "MusicPack: 80s Synthwave",
            });

            Add(new ItemDetails {
                WorkshopId = 464840482,
                WorkshopName = "epic city building song",
            });

            Add(new ItemDetails {
                WorkshopId = 462938240,
                WorkshopName = "Banjo Kazooie CSL Music Pack pt.2",
            });

            Add(new ItemDetails {
                WorkshopId = 462924840,
                WorkshopName = "KOGNITIF-Soul Food",
            });

            Add(new ItemDetails {
                WorkshopId = 458117789,
                WorkshopName = "Mozart Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 457496789,
                WorkshopName = "Zak McCracken Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 457493834,
                WorkshopName = "Romeo & Juliet Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 457317144,
                WorkshopName = "Beethoven Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 457184378,
                WorkshopName = "Hipster Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 456200016,
                WorkshopName = "Bach Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 456044944,
                WorkshopName = "Banjo Kazooie CSL Music Pack pt.1",
            });

            Add(new ItemDetails {
                WorkshopId = 455729185,
                WorkshopName = "Green~T Music Pack",
            });

            Add(new ItemDetails {
                WorkshopId = 453161669,
                WorkshopName = "TH RemasteredMusicPack",
            });

            Add(new ItemDetails {
                WorkshopId = 429241674,
                WorkshopName = "MusicPack: Experimental Collection 2",
            });

            Add(new ItemDetails {
                WorkshopId = 425299246,
                WorkshopName = "Music Pack: Experimental Collection 1",
            });

        }
    }
}
