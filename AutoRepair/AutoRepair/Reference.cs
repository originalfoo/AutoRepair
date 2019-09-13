

namespace AutoRepair {
    using System.Collections.Generic;
    using AutoRepair.Struct;
    using AutoRepair.Enums;
    using AutoRepair.Util;
    public class Reference {

        private static Reference instance;
        public static Reference Instance => instance ?? (instance = new Reference());

        public Dictionary<ulong, ModDetails> ModsList { get; set; } = new Dictionary<ulong, ModDetails> { };

        public Reference() {

            #region Broken - No reliable replacement

            Add(new ModDetails {
                WorkshopId = 703971825u,
                Name = "Billboard Animator",
                Flags = ModFlags.GameBreaking | ModFlags.NoWorkshop | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] }
            });

            Add(new ModDetails {
                WorkshopId = 886603352u,
                Name = "Prop Unlimiter",
                Flags = ModFlags.GameBreaking | ModFlags.ChangesSavegame | ModFlags.NoWorkshop | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] }
            });

            Add(new ModDetails {
                WorkshopId = 439582006u,
                Name = "[ARIS] Enhanced Garbage Truck AI",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"], Common["TMPE_LinuxFan"], Common["TMPE_Krzychu"], Common["TMPE_Aubergine"] }
            });

            Add(new ModDetails {
                WorkshopId = 583552152u,
                Name = "Enhanced Garbage Truck AI [Fixed for v1.4 +]",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"], Common["TMPE_LinuxFan"], Common["TMPE_Krzychu"], Common["TMPE_Aubergine"] }
            });

            Add(new ModDetails {
                WorkshopId = 813835391u,
                Name = "Enhanced Garbage Truck AI [1.6]",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"], Common["TMPE_LinuxFan"], Common["TMPE_Krzychu"], Common["TMPE_Aubergine"] }
            });

            Add(new ModDetails {
                WorkshopId = 433249875u,
                Name = "[ARIS] Enhanced Hearse AI",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"], Common["TMPE_LinuxFan"], Common["TMPE_Krzychu"], Common["TMPE_Aubergine"] }
            });

            Add(new ModDetails {
                WorkshopId = 583556014u,
                Name = "Enhanced Hearse AI [Fixed for v1.4 +]",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"], Common["TMPE_LinuxFan"], Common["TMPE_Krzychu"], Common["TMPE_Aubergine"] }
            });

            Add(new ModDetails {
                WorkshopId = 813835241u,
                Name = "Enhanced Hearse AI [1.6]",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"], Common["TMPE_LinuxFan"], Common["TMPE_Krzychu"], Common["TMPE_Aubergine"] }
            });

            Add(new ModDetails {
                WorkshopId = 421028969u,
                Name = "[ARIS] Skylines Overwatch",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] }
            });

            Add(new ModDetails {
                WorkshopId = 583538182u,
                Name = "Skylines Overwatch [Fixed for v1.3 +]",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] }
            });

            Add(new ModDetails {
                WorkshopId = 813833476u,
                Name = "Skylines Overwatch [1.6]",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] }
            });

            #endregion Broken - No viable replacement

            #region Fine Road Anarchy & Fine Road Tool

            // Conflict lists updated later

            Add(new ModDetails {
                WorkshopId = 433567230u,
                Name = "Advanced Road Anarchy",
                Flags = ModFlags.GameBreaking | ModFlags.NoWorkshop | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["FineRoadAnarchy"], Common["FineRoadTool"] },
                NeedAllReplacements = true
            });

            Add(new ModDetails {
                WorkshopId = 1362508329u,
                Name = "Fine Road Anarchy 2018",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["FineRoadAnarchy"], Common["FineRoadTool"] },
                NeedAllReplacements = true
            });

            Add(new ModDetails {
                WorkshopId = 1436255148u,
                Name = "Fine Road Anarchy 汉化版 1.3.5",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["FineRoadAnarchy"], Common["FineRoadTool"] },
                NeedAllReplacements = true
            });

            Add(new ModDetails {
                WorkshopId = 553184329u,
                Name = "Sharp Junction Angles",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["FineRoadAnarchy"], Common["FineRoadTool"] },
                NeedAllReplacements = true
            });

            Add(new ModDetails {
                WorkshopId = 418556522u,
                Name = "Road Anarchy",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["FineRoadAnarchy"], Common["FineRoadTool"] },
                NeedAllReplacements = true
            });

            Add(new ModDetails {
                WorkshopId = 954034590u,
                Name = "Road Anarchy V2",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["FineRoadAnarchy"], Common["FineRoadTool"] },
                NeedAllReplacements = true
            });

            Add(new ModDetails {
                WorkshopId = 448434637u,
                Name = "Enhanced Road Heights",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["FineRoadAnarchy"], Common["FineRoadTool"] },
                NeedAllReplacements = true
            });

            // Fine Road Anarchy (BoogieManSam)
            Add(new ModDetails {
                WorkshopId = Common["FineRoadAnarchy"],
                Name = "Fine Road Anarchy",
                Flags = ModFlags.Verified,
                GameVersion = { "1.12" },
                Conflicts = { }
            }, true);

            // Fine Road Tool (BoogieManSam)
            Add(new ModDetails {
                WorkshopId = Common["FineRoadTool"],
                Name = "Fine Road Tool",
                Flags = ModFlags.Verified,
                GameVersion = { "1.12" },
                Conflicts = { }
            }, true);

            #endregion Fine Road Anarchy & Fine Road Tool

            #region 81 Tiles

            // Conflcit lists updated later

            Add(new ModDetails {
                WorkshopId = 1361478243u,
                Name = "81 Tiles",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained | ModFlags.ChangesSavegame,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["Tiles81"] }
            });

            Add(new ModDetails {
                WorkshopId = 1575247594u,
                Name = "81 Tiles Fixed for 1",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained | ModFlags.ChangesSavegame,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["Tiles81"] }
            });

            Add(new ModDetails {
                WorkshopId = 1560122066u,
                Name = "81MOD",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained | ModFlags.ChangesSavegame,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["Tiles81"] }
            });

            Add(new ModDetails {
                WorkshopId = 548208563u,
                Name = "81 Tiles",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained | ModFlags.ChangesSavegame,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["Tiles81"] }
            });

            Add(new ModDetails {
                WorkshopId = 422554572u,
                Name = "81 Tiles Updated",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained | ModFlags.ChangesSavegame,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["Tiles81"] }
            });

            // 81 tiles
            Add(new ModDetails {
                WorkshopId = Common["Tiles81"], // BloodyPenguin
                Name = "81 Tiles (Fixed for 1.2+)",
                Flags = ModFlags.MinorBugs | ModFlags.Laggy | ModFlags.ChangesSavegame | ModFlags.Verified,
                Warnings = { "Glitches if disaster detection buildings are placed outside central 25 Tiles." },
                GameVersion = { "1.12" },
                Conflicts = { }
            }, true);

            #endregion 81 Tiles

            #region Show It!

            // Conflict lists updated later

            Add(new ModDetails {
                WorkshopId = 1133108993u,
                Name = "Extended Building Information (1.10+)",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["ShowIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 767809751u,
                Name = "Extended Building Information (Chinese)",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["ShowIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 414469593u,
                Name = "Extended Building Information",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["ShowIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 670422128u,
                Name = "Extended Building Information",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["ShowIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 928988785u,
                Name = "Extended Building Information",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["ShowIt"] }
            });

            // Show It
            Add(new ModDetails {
                WorkshopId = Common["ShowIt"],
                Name = "Show It!",
                Flags = ModFlags.Verified,
                GameVersion = { "1.12" },
                Conflicts = { }
            }, true);

            #endregion Show It!

            #region Purchase It!

            // Conflict lists updated later

            Add(new ModDetails {
                WorkshopId = 405904895u,
                Name = "OpenAllTiles",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 406187734u,
                Name = "Corner Tile Unlocker",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 1270675750u,
                Name = "BigCity (25 tiles mod)",
                Flags = ModFlags.Conflicts,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 403798635u, // Klyte
                Name = "All Spaces Unlockable",
                Flags = ModFlags.Conflicts | ModFlags.Verified,
                Conflicts = { },
                GameVersion = { "1.12" },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 413498678u, // Klyte
                Name = "All Spaces Unlockable - With Right Price",
                Flags = ModFlags.Conflicts | ModFlags.Unreliable | ModFlags.Verified,
                Conflicts = { },
                GameVersion = { "1.12" },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 1268806334u,
                Name = "UnlockAreaCountLimitAndFree",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained | ModFlags.Unreliable,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 1265292380u,
                Name = "UnlockAreaCountLimit",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained | ModFlags.LongBroken | ModFlags.ForceMigration,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 405810376u, // tomdotio
                Name = "All 25 Areas purchasable",
                Flags = ModFlags.Conflicts | ModFlags.Verified,
                Conflicts = { },
                GameVersion = { "1.12" },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 872129984u,
                Name = "KazExtraAreas",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained | ModFlags.Unreliable,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 417629854u,
                Name = "AreaAutoUnlock",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained | ModFlags.LongBroken | ModFlags.ForceMigration,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 412191763u,
                Name = "DistantAreasMod",
                Flags = ModFlags.Conflicts | ModFlags.Verified | ModFlags.RequiredItems,
                Conflicts = { },
                GameVersion = { "1.12" },
                RequiredItems = { Common["NoBorderCamera"] },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 406451121u,
                Name = "UnlockFreeArea",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained | ModFlags.Unreliable,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 1138679561u,
                Name = "AllSpacesUnlock",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained | ModFlags.LongBroken | ModFlags.ForceMigration,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 616078328u,
                Name = "All Tile Start",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained | ModFlags.LongBroken | ModFlags.GameBreaking,
                Conflicts = { Vanilla["UnlockAll"] },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 425057208u,
                Name = "Area Enabler",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained | ModFlags.GameBreaking | ModFlags.LongBroken,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 477574890u,
                Name = "UnlockAreaCountLimit",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 477615230u,
                Name = "UnlockAreaCountLimit",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 709765899u,
                Name = "UnlockAreaCountLimit",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 477574991,
                Name = "UnlockAreaCountLimitAndFree",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 477615068u,
                Name = "UnlockAreaCountLimitAndFree",
                Flags = ModFlags.Conflicts | ModFlags.Unmaintained,
                Conflicts = { },
                Replacements = { Common["PurchaseIt"] }
            });

            // Purchsae It
            Add(new ModDetails { // keallu
                WorkshopId = Common["PurchaseIt"],
                Name = "Purchase It!",
                Flags = ModFlags.Conflicts | ModFlags.Verified,
                Conflicts = { },
                GameVersion = { "1.12" },
                RequiredItems = { Common["NoBorderCamera"] },
                Replacements = { }
            }, true);

            #endregion Purchase It!

            #region Empty It!

            // Conflict lists updated later

            Add(new ModDetails {
                WorkshopId = 896806060,
                Name = "Automatic Emptying",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["EmptyIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 407873631,
                Name = "Automatic Emptying",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["EmptyIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 686588890,
                Name = "Automatic Emptying: Extended",
                Flags = ModFlags.GameBreaking | ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["EmptyIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 1182722930,
                Name = "Automatic Empty",
                Flags = ModFlags.Unreliable | ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["EmptyIt"] }
            });

            // Empty It!
            Add(new ModDetails {
                WorkshopId = Common["EmptyIt"],
                Name = "Empty It!",
                Flags = ModFlags.Verified,
                GameVersion = { "1.12" },
                Conflicts = { }
            }, true);

            #endregion Empty It!

            #region Unlimited Money

            Add(new ModDetails {
                WorkshopId = 438378612u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 428608882u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 427997113u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 427901620u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 424026003u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 422901712u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 420911882u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 420550550u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 419484397u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 419333753u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 418153488u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            Add(new ModDetails {
                WorkshopId = 417187838u,
                Name = "Unlimited Money",
                Flags = ModFlags.Unmaintained,
                Conflicts = { Vanilla["UnlimitedMoney"] },
                Replacements = { Vanilla["UnlimitedMoney"] }
            });

            #endregion Unlimited Money

            #region Unlock All

            Add(new ModDetails {
                WorkshopId = 438378843u,
                Name = "Unlock All",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["UnlockAll"] },
                Replacements = { Vanilla["UnlockAll"] }
            });

            Add(new ModDetails {
                WorkshopId = 431993428u,
                Name = "Unlock All",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["UnlockAll"] },
                Replacements = { Vanilla["UnlockAll"] }
            });

            Add(new ModDetails {
                WorkshopId = 428555989u,
                Name = "Unlock All",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["UnlockAll"] },
                Replacements = { Vanilla["UnlockAll"]l }
            });

            Add(new ModDetails {
                WorkshopId = 428555664u,
                Name = "Unlock All",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["UnlockAll"] },
                Replacements = { Vanilla["UnlockAll"] }
            });

            Add(new ModDetails {
                WorkshopId = 419329713u,
                Name = "Unlock All",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["UnlockAll"] },
                Replacements = { Vanilla["UnlockAll"] }
            });

            Add(new ModDetails {
                WorkshopId = 418975267u,
                Name = "Unlock All",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts,
                Conflicts = { Vanilla["UnlockAll"] },
                Replacements = { Vanilla["UnlockAll"] }
            });

            #endregion Unlock All

            #region Unlimited Soil

            Add(new ModDetails {
                WorkshopId = 654586812u,
                Name = "No Soil Limit",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts | ModFlags.ForceMigration,
                Conflicts = { Vanilla["UnlimitedSoil"] },
                Replacements = { Vanilla["UnlimitedSoil"] }
            });

            #endregion

            #region Unlimited Oil & Ore

            Add(new ModDetails {
                WorkshopId = 852103955u,
                Name = "InfiniteOilAndOre",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts | ModFlags.ForceMigration,
                Conflicts = { Vanilla["UnlimitedOilOre"] },
                Replacements = { Vanilla["UnlimitedOilOre"], 580335918u }
            });

            Add(new ModDetails {
                WorkshopId = 409644467u,
                Name = "InfiniteOilAndOre",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts | ModFlags.NoWorkshop | ModFlags.ForceMigration,
                Conflicts = { Vanilla["UnlimitedOilOre"] },
                Replacements = { Vanilla["UnlimitedOilOre"], 580335918u }
            });

            Add(new ModDetails {
                WorkshopId = 580335918u, // BloodyPenguin
                Name = "Infinite Oil And Ore Redux [DEPRECATED]",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts | ModFlags.Verified,
                Conflicts = { Vanilla["UnlimitedOilOre"] },
                GameVersion = { "1.12" },
                Replacements = { Vanilla["UnlimitedOilOre"] }
            });

            #endregion Unlimited Oil & Ore

            #region Bulldoze It! / Rebuild It!

            // Conflict lists updated later

            Add(new ModDetails {
                WorkshopId = 1628521230u,
                Name = "Bulldoze Everything *Campus Compatible*",
                Flags = ModFlags.Conflicts | ModFlags.Verified,
                Conflicts = { },
                GameVersion = { "1.12" },
                Replacements = { Common["BulldozeIt"], Common["RebuildIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 1507233911u,
                Name = "Automatic Bulldoze *Campus Compatible*",
                Flags = ModFlags.Conflicts | ModFlags.Verified,
                Conflicts = { },
                GameVersion = { "1.12" },
                Replacements = { Common["BulldozeIt"], Common["RebuildIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 445799544, // author states dev is on pause, and it requires game breaking mod
                Name = "V10Bulldoze",
                Flags = ModFlags.Unmaintained | ModFlags.RequiredItems | ModFlags.Conflicts | ModFlags.LongBroken | ModFlags.ForceMigration,
                RequiredItems = { 421028969u },
                Conflicts = { },
                Replacements = { Common["BulldozeIt"], Common["RebuildIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 406132323,
                Name = "Automatic Bulldoze",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts | ModFlags.GameBreaking,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["BulldozeIt"], Common["RebuildIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 1393966192,
                Name = "Automatic Bulldoze Simple Edition v1.1.3",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts | ModFlags.GameBreaking,
                Conflicts = { Vanilla["BaseGame"] },
                Replacements = { Common["BulldozeIt"], Common["RebuildIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 639486063,
                Name = "Automatic Bulldoze v2",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts | ModFlags.GameBreaking,
                Conflicts = { },
                Replacements = { Common["BulldozeIt"], Common["RebuildIt"] }
            });

            Add(new ModDetails {
                WorkshopId = 503147777,
                Name = "Moledozer",
                Flags = ModFlags.Unmaintained | ModFlags.Conflicts | ModFlags.Unreliable,
                Conflicts = { },
                Replacements = { Vanilla["BaseGame"] }
            });

            Add(new ModDetails {
                WorkshopId = Common["BulldozeIt"],
                Name = "Bulldoze It!",
                Flags = ModFlags.Conflicts | ModFlags.Verified,
                Conflicts = { },
                GameVersion = { "1.12" }
            }, true);

            Add(new ModDetails {
                WorkshopId = Common["RebuildIt"],
                Name = "Rebuild It!",
                Flags = ModFlags.Conflicts | ModFlags.Verified,
                Conflicts = { },
                GameVersion = { "1.12" }
            }, true);

            #endregion Bulldoze It! / Rebuild It!

        }

        internal void Add(ModDetails info, bool autoConflict = false) {
#if DEBUG
            if (info.WorkshopId == 0u) {
                Log.Error("[Reference.Add] A workshop ID is missing.");
                return;
            }
            if (ModsList.ContainsKey(info.WorkshopId)) {
                Log.Error($"[Reference.Add] Duplicate key: {info.WorkshopId} '{info.Name}'");
                return;
            }
#endif
            if (autoConflict) {
                if (info.Conflicts == null) {
                    Log.Error($"[Reference.Add] Initialise the .Conflicts list of {info.WorkshopId} '{info.Name}' before calling .Add");
                    return;
                }

                // add all the mods replaced by this mod to this mods list of conflicts
                foreach (KeyValuePair<ulong, ModDetails> entry in ModsList) {
                    if (entry.Value.Replacements != null && entry.Value.Replacements.Contains(info.WorkshopId)) {
                        info.Conflicts.Add(entry.Value.WorkshopId);
                    }
                }

                // now go through each of the listed conflicts and fill in their missing conflicts
            }

            ModsList.Add(info.WorkshopId, info);
        }

        /// <summary>
        /// Fake workshop id used to denote vanilla game feature.
        /// Can be used in <see cref="ModDetails.Replacements"/> and <see cref="ModDetails.Conflicts"/>
        ///
        /// Do not ever use <c>0</c> for the <c>ulong</c>, as it is default <c>ulong</c> value and we don't want
        /// weird errors happening in future.
        ///
        /// In code, a quick check to see if a <c>ulong</c> is one of these entries is to test for
        /// <c>SomeId <= Vanilla.Count()</c>.
        /// </summary>
        public readonly Dictionary<string, ulong> Vanilla = new Dictionary<string, ulong> {
            { "BaseGame", 1u },
            { "UnlockAll", 2u },
            { "UnlimitedMoney", 3u },
            { "UnlimitedSoil", 4u },
            { "UnlimitedOilOre", 5u },
        };

        /// <summary>
        /// Named references for commonly referred-to mods.
        /// </summary>
        public readonly Dictionary<string, ulong> Common = new Dictionary<string, ulong> {
            { "BulldozeIt", 1627986403 },
            { "EmptyIt", 1661072176u },
            { "FineRoadAnarchy", 802066100u }, // BoogieManSam
            { "FineRoadTool", 651322972u }, // BoogieManSam
            { "HideIt", 1591417160u },
            { "NoBorderCamera", 446764406u },
            { "PurchaseIt", 1612287735u },
            { "RebuildIt", 1656549865 },
            { "ShowIt", 1556715327u },
            { "Tiles81", 576327847u },
            { "TMPE_LinuxFan", 583429740u },
            { "TMPE_Krzychu", 1637663252u },
            { "TMPE_Aubergine", 1806963141 },
        };
    }
}
