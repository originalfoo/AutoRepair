using AutoRepair.Structs;
using AutoRepair.Enums;
using AutoRepair.Util;
using System.Collections.Generic;
using System;

namespace AutoRepair.Catalogs {
    public class Mods {

        internal static Mods instance;
        public static Mods Instance => instance ?? (instance = new Mods());

        public Dictionary<ulong, ItemDetails> Lookup = new Dictionary<ulong, ItemDetails> { };

        Mods() {
            Log.Info("[Mods.ctor] Instantiating.");
            try {
                Populate();
                Validate();
                Log.Info($"[Mods.Lookup] {Lookup.Count} items defined");
            }
            catch (Exception e) {
                Log.Error($"ERROR [Mods.ctor] {e.Message}");
            }
        }

        internal void Add(ItemDetails info) {
            //Log.Info($"[Catalog.AddMod] {info.WorkshopId} = {info.Name}");
            if (info.WorkshopId == 0u) {
                Log.Info($"ERROR [Mods.Add] Workshop ID is missing: 0u ({info.WorkshopName})");
                return;
            }
            if (Lookup.ContainsKey(info.WorkshopId)) {
                Log.Info($"ERROR [Mods.Add] Duplicate key: {info.WorkshopId} ({info.WorkshopName})");
                return;
            }
            if (!Categories.Instance.ValidateItem(info)) {
                return;
            }
            info.ItemType = ItemTypes.Mod;
            Lookup.Add(info.WorkshopId, info);
        }

        internal void Validate() {
            Log.Info("[Mods.Validate] Validating contents of lookup dictionary.");
            foreach (KeyValuePair<ulong, ItemDetails> entry in Lookup) {
                ItemDetails currentMod = entry.Value;
                //Log.Info($"[Catalog.ValidateMods] {currentMod.WorkshopId} = {currentMod.Name}");

                // check reciprocal `.CompatibleWith`
                if (currentMod.CompatibleWith != null) {
                    foreach (ulong targetMod in currentMod.CompatibleWith) {
                        if (Lookup.TryGetValue(targetMod, out ItemDetails otherMod) && otherMod.CompatibleWith != null) {
                            List<ulong> reciprocates = new List<ulong>(otherMod.CompatibleWith);
                            if (!reciprocates.Contains(currentMod.WorkshopId)) {
                                Log.Info($"ERROR [Mods.Validate] {currentMod.WorkshopId} ({currentMod.WorkshopName}) .CompatibleWith {targetMod} but not reciprocated.");
                            }
                        } else {
                            Log.Info($"ERROR [Mods.Validate] {currentMod.WorkshopId} ({currentMod.WorkshopName}) .CompatibleWith {targetMod} but not found.");
                        }
                    }
                }
            }
        }


        internal void Populate() {
            Log.Info("[Mods.Populate] Populating lookup dictionary.");

            #region Game breaking - No reliable replacement

            Add(new ItemDetails {
                WorkshopId = 418216826,
                WorkshopName = "Alternative Siren Sound",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                Notes = new string[] { "This mod contains a computer virus!" },
            });

            Add(new ItemDetails {
                WorkshopId = 420230361,
                WorkshopName = "Moving Sun",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Real Time" },
            });

            Add(new ItemDetails {
                WorkshopId = 703971825,
                WorkshopName = "Billboard Animator",
                Flags =  ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
            });

            Add(new ItemDetails {
                WorkshopId = 886603352,
                WorkshopName = "Prop Unlimiter",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking | ItemFlags.ChangesSavegame,
            });

            Add(new ItemDetails {
                WorkshopId = 439582006,
                WorkshopName = "[ARIS] Enhanced Garbage Truck AI",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 421028969 }, // overwatch 1
                Categories = new string[] { "Garbage AI", "TMPE" },
            });

            Add(new ItemDetails {
                WorkshopId = 583552152,
                WorkshopName = "Enhanced Garbage Truck AI [Fixed for v1.4 +]",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 583538182 }, // overwatch 1.3
                Categories = new string[] { "Garbage AI", "TMPE" },
            });

            Add(new ItemDetails {
                WorkshopId = 813835391,
                WorkshopName = "Enhanced Garbage Truck AI [1.6]",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 813833476 }, // overwatch 1.6
                Categories = new string[] { "Garbage AI", "TMPE" },
            });

            Add(new ItemDetails {
                WorkshopId = 433249875,
                WorkshopName = "[ARIS] Enhanced Hearse AI",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 421028969 }, // overwatch 1
                Categories = new string[] { "Hearse AI", "TMPE" },
            });

            Add(new ItemDetails {
                WorkshopId = 583556014,
                WorkshopName = "Enhanced Hearse AI [Fixed for v1.4 +]",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 583538182 }, // overwatch 1.3
                Categories = new string[] { "Hearse AI", "TMPE" },
            });

            Add(new ItemDetails {
                WorkshopId = 813835241,
                WorkshopName = "Enhanced Hearse AI [1.6]",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 813833476 }, // overwatch 1.6
                Categories = new string[] { "Hearse AI", "TMPE" },
            });

            Add(new ItemDetails {
                WorkshopId = 421028969, // overwatch 1
                WorkshopName = "[ARIS] Skylines Overwatch",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Overwatch" },
            });

            Add(new ItemDetails {
                WorkshopId = 583538182, // overwach 1.3
                WorkshopName = "Skylines Overwatch [Fixed for v1.3 +]",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Overwatch" },
            });

            Add(new ItemDetails {
                WorkshopId = 813833476, // overwatch 1.6
                WorkshopName = "Skylines Overwatch [1.6]",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                Categories = new string[] { "Overwatch" },
            });

            #endregion Broken - No viable replacement

            #region Fine Road Anarchy & Fine Road Tool

            // Verified

            Add(new ItemDetails {
                WorkshopId = 1844440354, // Klyte
                WorkshopName = "Fine Road Anarchy 2",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Road Anarchy" },
                CompatibleWith = new ulong[] { 1844442251 }, // frt2
            });

            Add(new ItemDetails {
                WorkshopId = 1844442251, // Klyte
                WorkshopName = "Fine Road Tool 2",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Road Anarchy" },
                CompatibleWith = new ulong[] { 1844440354 }, // fra2
            });

            Add(new ItemDetails {
                WorkshopId = 802066100, // BoogieManSam
                WorkshopName = "Fine Road Anarchy",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.10", "1.11", "1.12" },
                Categories = new string[] { "Road Anarchy" },
                CompatibleWith = new ulong[] { 651322972 }, // frt1
            });

            Add(new ItemDetails {
                WorkshopId = 651322972, // BoogieManSam
                WorkshopName = "Fine Road Tool",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.10", "1.11", "1.12" },
                Categories = new string[] { "Road Anarchy" },
                CompatibleWith = new ulong[] { 802066100 }, // fra1
            });

            Add(new ItemDetails {
                WorkshopId = 1840448750,
                WorkshopName = "FineRoadTool 汉化版",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Road Anarchy" },
            });

            // Unmaintained

            Add(new ItemDetails {
                WorkshopId = 1362508329,
                WorkshopName = "TC01 - FineRoadAnarchy! (2018)",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Road Anarchy" },
            });

            // Game breaking

            Add(new ItemDetails {
                WorkshopId = 1436255148,
                WorkshopName = "Fine Road Anarchy 汉化版 1.3.5",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Road Anarchy" },
            });

            Add(new ItemDetails {
                WorkshopId = 553184329,
                WorkshopName = "Sharp Junction Angles",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Road Anarchy" },
            });

            Add(new ItemDetails {
                WorkshopId = 418556522,
                WorkshopName = "Road Anarchy",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Road Anarchy" },
            });

            Add(new ItemDetails {
                WorkshopId = 954034590,
                WorkshopName = "Road Anarchy V2",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Road Anarchy" },
            });

            Add(new ItemDetails {
                WorkshopId = 448434637,
                WorkshopName = "Enhanced Road Heights",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Road Anarchy" },
            });

            Add(new ItemDetails {
                WorkshopId = 433567230,
                WorkshopName = "Advanced Road Anarchy",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                Categories = new string[] { "Road Anarchy" },
            });

            #endregion Fine Road Anarchy & Fine Road Tool

            #region 81 Tiles

            // Verified

            Add(new ItemDetails {
                WorkshopId = 576327847, // BloodyPenguin
                WorkshopName = "81 Tiles (Fixed for 1.2+)",
                Flags = ItemFlags.Verified | ItemFlags.MinorBugs | ItemFlags.Laggy | ItemFlags.ChangesSavegame,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "81 Tiles", "25 Tiles" },
                Notes = new string[] {
                    "Glitches if disaster detection buildings are placed outside central 25 Tiles.",
                    "Not suitable for potato (slow) computers."
                },
            });

            // Game Breaking

            Add(new ItemDetails {
                WorkshopId = 1361478243u,
                WorkshopName = "81 Tiles",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking | ItemFlags.Laggy | ItemFlags.ChangesSavegame,
                Categories = new string[] { "81 Tiles", "25 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 1575247594u,
                WorkshopName = "81 Tiles Fixed for 1",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking | ItemFlags.Laggy | ItemFlags.ChangesSavegame,
                Categories = new string[] { "81 Tiles", "25 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 1560122066u,
                WorkshopName = "81MOD",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking | ItemFlags.Laggy | ItemFlags.ChangesSavegame,
                Categories = new string[] { "81 Tiles", "25 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 548208563u,
                WorkshopName = "81 Tiles",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking | ItemFlags.Laggy | ItemFlags.ChangesSavegame,
                Categories = new string[] { "81 Tiles", "25 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 422554572u,
                WorkshopName = "81 Tiles Updated",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking | ItemFlags.Laggy | ItemFlags.ChangesSavegame,
                Categories = new string[] { "81 Tiles", "25 Tiles" },
            });

            #endregion 81 Tiles

            #region 25 Tiles

            // Verified

            Add(new ItemDetails { // keallu
                WorkshopId = 1612287735,
                WorkshopName = "Purchase It!",
                Flags = ItemFlags.Verified,
                RequiredItems = new ulong[] { 446764406 }, // no border cam
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 412191763, // Xandor9
                WorkshopName = "DistantAreasMod",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                RequiredItems = new ulong[] { 446764406 }, // no border cam
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 405810376, // tomdotio
                WorkshopName = "All 25 Areas purchasable",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 403798635, // Klyte
                WorkshopName = "All Spaces Unlockable",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 1270675750, // Saeleko
                WorkshopName = "BigCity (25 tiles mod)",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 413498678, // Klyte
                WorkshopName = "All Spaces Unlockable - With Right Price",
                Flags = ItemFlags.Verified | ItemFlags.Unreliable,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            // Unmaintained

            Add(new ItemDetails {
                WorkshopId = 406187734,
                WorkshopName = "Corner Tile Unlocker",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 477574890,
                WorkshopName = "UnlockAreaCountLimit",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 477615230,
                WorkshopName = "UnlockAreaCountLimit",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 709765899,
                WorkshopName = "UnlockAreaCountLimit",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 477574991,
                WorkshopName = "UnlockAreaCountLimitAndFree",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 477615068,
                WorkshopName = "UnlockAreaCountLimitAndFree",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            // Unreliable

            Add(new ItemDetails {
                WorkshopId = 1268806334,
                WorkshopName = "UnlockAreaCountLimitAndFree",
                Flags = ItemFlags.Unmaintained | ItemFlags.Unreliable,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 872129984,
                WorkshopName = "KazExtraAreas",
                Flags = ItemFlags.Unmaintained | ItemFlags.Unreliable,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 406451121,
                WorkshopName = "UnlockFreeArea",
                Flags = ItemFlags.Unmaintained | ItemFlags.Unreliable,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            // Broken

            Add(new ItemDetails {
                WorkshopId = 1265292380,
                WorkshopName = "UnlockAreaCountLimit",
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken | ItemFlags.ForceMigration,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 417629854,
                WorkshopName = "AreaAutoUnlock",
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken | ItemFlags.ForceMigration,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 1138679561,
                WorkshopName = "AllSpacesUnlock",
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken | ItemFlags.ForceMigration,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            // Game breaking

            Add(new ItemDetails {
                WorkshopId = 405904895,
                WorkshopName = "OpenAllTiles",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 616078328,
                WorkshopName = "All Tile Start",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            Add(new ItemDetails {
                WorkshopId = 425057208,
                WorkshopName = "Area Enabler",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "25 Tiles", "81 Tiles" },
            });

            #endregion 25 Tiles

            #region Building Info

            // Verified

            Add(new ItemDetails {
                WorkshopId = 1556715327, // Keallu
                WorkshopName = "Show It!",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Building Info" },
            });

            // Game breaking

            Add(new ItemDetails {
                WorkshopId = 414469593,
                WorkshopName = "Extended Building Information",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Building Info" },
            });

            Add(new ItemDetails {
                WorkshopId = 670422128,
                WorkshopName = "Extended Building Information",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Building Info" },
            });

            Add(new ItemDetails {
                WorkshopId = 928988785,
                WorkshopName = "Extended Building Information",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Building Info" },
            });

            Add(new ItemDetails {
                WorkshopId = 1133108993,
                WorkshopName = "Extended Building Information (1.10+)",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Building Info" },
            });

            Add(new ItemDetails {
                WorkshopId = 767809751,
                WorkshopName = "Extended Building Information (Chinese)",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                Categories = new string[] { "Building Info" },
            });

            #endregion Building Information

            #region Auto Empty

            // Verified

            Add(new ItemDetails {
                WorkshopId = 1661072176, // Keallu
                WorkshopName = "Empty It!",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Auto Empty" },
            });

            // Unmaintained

            Add(new ItemDetails {
                WorkshopId = 1182722930,
                WorkshopName = "Automatic Empty",
                Flags = ItemFlags.Unmaintained | ItemFlags.Unreliable,
                Categories = new string[] { "Auto Empty" },
            });

            // Game breaking

            Add(new ItemDetails {
                WorkshopId = 896806060,
                WorkshopName = "Automatic Emptying",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Auto Empty" },
            });

            Add(new ItemDetails {
                WorkshopId = 407873631,
                WorkshopName = "Automatic Emptying",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Auto Empty" },
            });

            Add(new ItemDetails {
                WorkshopId = 686588890,
                WorkshopName = "Automatic Emptying: Extended",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Auto Empty" },
            });

            #endregion Auto Empty

            #region Unlimited Money

            // Verified

            Add(new ItemDetails {
                WorkshopId = Vanilla.UnlimitedMoney,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Unlimited Money" },
            });

            // Unmaintained

            Add(new ItemDetails {
                WorkshopId = 438378612u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 428608882u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 427997113u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 427901620u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 424026003u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 422901712u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 420911882u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 420550550u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 419484397u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 419333753u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 418153488u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            Add(new ItemDetails {
                WorkshopId = 417187838u,
                WorkshopName = "Unlimited Money",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Money" },
            });

            // Broken

            Add(new ItemDetails {
                WorkshopId = 555375742,
                WorkshopName = "Improved unlimited money",
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlimited Money" },
            });

            #endregion Unlimited Money

            // todo
            #region Value Tweakers
            //1237383751 - Extended Game Options

            //1498036881 - UltimateMod 2.1 ( Higher Income and More Options )

            //519781146 - Difficulty Tuning
            #endregion Value Tweakers

            #region Hard Mode

            Add(new ItemDetails {
                WorkshopId = Vanilla.HardMode, // CO
                WorkshopName = "Hard Mode",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Hard Mode" },
            });

            #endregion Hard Mode

            //todo
            #region Unlock All / Milestones

            // - 

            //627047745 - Winter Buildings Unlocker (+vice versa)

            //597981885 - Zen Garden Cherry Blossom Unlocker

            //456408505 - European Buildings Unlocker (+vice versa) [ DEPRECATED ]

            //466834228 - Not So Unique Buildings
            // tweaks

            // Verified

            Add(new ItemDetails {
                WorkshopId = Vanilla.UnlockAll, // CO
                WorkshopName = "Unlock All",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Uniques" },
                CompatibleWith = new ulong[] { 534440333, 406522876, 527499893 }
                // custom milestones, no money, unlock track+metro
            });

            Add(new ItemDetails {
                WorkshopId = 458519223, // BloodyPenguin
                WorkshopName = "Unlock All + Wonders & Landmarks",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Wonders", "Unlock Uniques" },
                CompatibleWith = new ulong[] { 406522876, 527499893 },
                // no money, unlock track+metro
            });

            Add(new ItemDetails {
                WorkshopId = 1840481380, // 竹叶子兄
                WorkshopName = "Unlock All + Wonders & Landmarks 汉化版",
                Flags = ItemFlags.Verified | ItemFlags.Translation,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Wonders", "Unlock Uniques" },
                CompatibleWith = new ulong[] { 406522876, 527499893 },
            });

            Add(new ItemDetails {
                WorkshopId = 534440333, // AndyDaMage
                WorkshopName = "Custom Milestones",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Milestone Tweaks" },
                CompatibleWith = new ulong[] { Vanilla.UnlockAll },
            });

            Add(new ItemDetails {
                WorkshopId = 1614062928, // pcfantasy
                WorkshopName = "Unlock LandScaping",
                Flags = ItemFlags.Unmaintained | ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Unlock Landscape" },
                CompatibleWith = new ulong[] { 447789816, 527499893, 406522876, 406280169, 532070982 },
                // unlock all roads, unlock track+metro, no money, smooth prog, swap metro/train
            });

            Add(new ItemDetails {
                WorkshopId = 447789816, // zexel
                WorkshopName = "Unlock All Roads",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Unlock Roads" },
                CompatibleWith = new ulong[] { 1614062928, 527499893, 406522876, 406280169, 532070982 },
                // unlock landscaping, unlock track+metro, no money, smooth prog, swap metro/train
            });

            Add(new ItemDetails {
                WorkshopId = 527499893, // TPB
                WorkshopName = "Unlock Tracks + Metro Tunnels", // no need to place station first
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Milestone Tweaks", "Unlock Tracks" },
                CompatibleWith = new ulong[] { Vanilla.UnlockAll, 406522876, 1614062928, 447789816, 406280169, 532070982, 458519223, 1840481380 },
                // no money, unlock landscaping, unlock all roads, smooth prog, swap metro/train, unlock+wonders x 2
            });

            Add(new ItemDetails {
                WorkshopId = 532070982, // AndyDaMage
                WorkshopName = "Metro/Train Swap", // train before metro
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Milestone Tweaks" },
                CompatibleWith = new ulong[] { 527499893, 406522876, 1614062928, 447789816, 406280169 },
                // unlock track+metro, no money, unlock landscaping, unlock all roads, smooth prog
            });

            Add(new ItemDetails {
                WorkshopId = 406522876, // DifferentLevelDan
                WorkshopName = "No Money From Milestones",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Milestone Tweaks" },
                CompatibleWith = new ulong[] { Vanilla.UnlockAll, 527499893, 1614062928, 447789816, 1424264814, 406280169, 532070982, 458519223, 1840481380 },
                // unlock track+metro, unlock landscaping, unlock all roads, yafu, smooth prog, swap metro/train, unlock+wonders x 2
            });

            Add(new ItemDetails {
                WorkshopId = 1424264814, // C#
                WorkshopName = "YAFU - Yet Another Feature Unlocker",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Landscape", "Unlock Districts", "Unlock Transport", "Unlock Monuments", "Unlock Wonders" },
                CompatibleWith = new ulong[] { 406522876, 406280169 },
                // no money, smooth prog
            });

            Add(new ItemDetails {
                WorkshopId = 406280169,
                WorkshopName = "Smooth Progression",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Milestone Tweaks" },
                CompatibleWith = new ulong[] { 406522876, 1614062928, 447789816, 527499893, 1424264814, 532070982 },
                // no money, unlock landscape, unlock all roads, unlock track+metro, yafu, swap metro/train
            });

            // Unmaintained

            Add(new ItemDetails {
                WorkshopId = 480726641,
                WorkshopName = "New Game +++",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Hard Mode", "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Uniques", "Unlock Wonders" },
            });

            Add(new ItemDetails {
                WorkshopId = 438378843,
                WorkshopName = "Unlock All",
                Flags = ItemFlags.Unmaintained | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Uniques", "Unlock Wonders" },
            });

            Add(new ItemDetails {
                WorkshopId = 431993428,
                WorkshopName = "Unlock All",
                Flags = ItemFlags.Unmaintained | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Uniques", "Unlock Wonders" },
            });

            Add(new ItemDetails {
                WorkshopId = 428555989,
                WorkshopName = "Unlock All",
                Flags = ItemFlags.Unmaintained | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Uniques", "Unlock Wonders" },
            });

            Add(new ItemDetails {
                WorkshopId = 428555664,
                WorkshopName = "Unlock All",
                Flags = ItemFlags.Unmaintained | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Uniques", "Unlock Wonders" },
            });

            Add(new ItemDetails {
                WorkshopId = 419329713,
                WorkshopName = "Unlock All",
                Flags = ItemFlags.Unmaintained | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Uniques", "Unlock Wonders" },
            });

            Add(new ItemDetails {
                WorkshopId = 418975267,
                WorkshopName = "Unlock All",
                Flags = ItemFlags.Unmaintained | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Uniques", "Unlock Wonders" },
            });

            // Unreliable

            Add(new ItemDetails {
                WorkshopId = 635093438,
                WorkshopName = "Unlock Public Transport",
                Flags = ItemFlags.Unmaintained | ItemFlags.Unreliable,
                Categories = new string[] { "Unlock Transport", "Unlock Roads", "Unlock Tracks" },
            });

            Add(new ItemDetails {
                WorkshopId = 407162294,
                WorkshopName = "All basic unlocks at the start", // Boom town
                Flags = ItemFlags.Unmaintained | ItemFlags.Unreliable,
                Categories = new string[] { "Unlock Roads", "Unlock Tracks", "Unlock Transport", "Unlock Districts", "Unlock Landscape" },
            });

            Add(new ItemDetails {
                WorkshopId = 1242879105,
                WorkshopName = "Unlock Any Milestone",
                Flags = ItemFlags.Unmaintained | ItemFlags.Unreliable,
                Categories = new string[] { "Unlock All", "Unlock Landscape", "Unlock Roads", "Unlock Tracks", "Unlock Buildings", "Unlock Districts", "Unlock Monuments", "Unlock Transport", "Unlock Uniques", "Unlock Wonders" },
            });

            // Broken

            Add(new ItemDetails {
                WorkshopId = 410614868,
                WorkshopName = "EarlyUnlock", // Boom town
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken,
                Categories = new string[] { "Unlock Roads", "Unlock Tracks", "Unlock Transport", "Unlock Districts", "Unlock Landscape" },
            });

            Add(new ItemDetails {
                WorkshopId = 446662510,
                WorkshopName = "New Game Plus (NG+1.1.0)",
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlock Roads", "Unlock Transport", "Unlock Districts" },
            });

            Add(new ItemDetails {
                WorkshopId = 408881255,
                WorkshopName = "Unlock Basic Roads",
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlock Roads" },
            });

            Add(new ItemDetails {
                WorkshopId = 421320224,
                WorkshopName = "Unlock Districts (deprecated)",
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlock Districts" },
            });

            #endregion Unlock All

            #region Unlimited Soil

            // Verified

            Add(new ItemDetails {
                WorkshopId = Vanilla.UnlimitedSoil, // CO
                WorkshopName = "Unlimited Soil",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Unlimited Soil" },
            });

            // Unmaintained

            Add(new ItemDetails {
                WorkshopId = 654586812u,
                WorkshopName = "No Soil Limit",
                Flags = ItemFlags.Unmaintained | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlimited Soil" },
            });

            #endregion

            #region Unlimited Oil & Ore

            // Verified

            Add(new ItemDetails {
                WorkshopId = Vanilla.UnlimitedOilOre, // CO
                WorkshopName = "Unlimited Oil and Ore",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Unlimited Oil & Ore" },
            });

            Add(new ItemDetails {
                WorkshopId = 580335918u, // BloodyPenguin
                WorkshopName = "Infinite Oil And Ore Redux [DEPRECATED]",
                Flags = ItemFlags.Unmaintained | ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Unlimited Oil & Ore" },
            });

            // Unmaintained

            Add(new ItemDetails {
                WorkshopId = 852103955u,
                WorkshopName = "InfiniteOilAndOre",
                Flags = ItemFlags.Unmaintained,
                Categories = new string[] { "Unlimited Oil & Ore" },
            });

            Add(new ItemDetails {
                WorkshopId = 409644467u,
                WorkshopName = "InfiniteOilAndOre",
                Flags = ItemFlags.NoWorkshop | ItemFlags.ForceMigration,
                Categories = new string[] { "Unlimited Oil & Ore" },
            });

            #endregion Unlimited Oil & Ore

            #region Bulldoze

            Add(new ItemDetails {
                WorkshopId = 503147777,
                WorkshopName = "Moledozer",
                Flags = ItemFlags.Unmaintained | ItemFlags.Unreliable,
                Categories = new string[] { "Bulldoze" },
            });

            #endregion Bulldoze

            #region Auto Bulldoze (& Rebuild)

            // Verified

            Add(new ItemDetails {
                WorkshopId = 1656549865, // Keallu
                WorkshopName = "Rebuild It!",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Auto Bulldoze" },
                CompatibleWith = new ulong[] { 1627986403 }, // bulldoze it
            });

            Add(new ItemDetails {
                WorkshopId = 1627986403, // Keallu
                WorkshopName = "Bulldoze It!",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Auto Bulldoze" },
                CompatibleWith = new ulong[] { 1656549865 }, // rebuild it
            });

            Add(new ItemDetails {
                WorkshopId = 1628521230, // chosen one
                WorkshopName = "Bulldoze Everything *Campus Compatible*",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Auto Bulldoze" },
            });

            Add(new ItemDetails {
                WorkshopId = 1507233911, // 1507233911
                WorkshopName = "Automatic Bulldoze *Campus Compatible*",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Auto Bulldoze" },
            });

            // Broken

            Add(new ItemDetails { // author states dev is on pause, and it requires game breaking mod
                WorkshopId = 445799544,
                WorkshopName = "V10Bulldoze",
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken | ItemFlags.ForceMigration,
                RequiredItems = new ulong[] { 421028969 }, // overwatch 1
                Categories = new string[] { "Auto Bulldoze" },
            });

            // Game breaking

            Add(new ItemDetails {
                WorkshopId = 406132323,
                WorkshopName = "Automatic Bulldoze",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Auto Bulldoze" },
            });

            Add(new ItemDetails {
                WorkshopId = 1393966192,
                WorkshopName = "Automatic Bulldoze Simple Edition v1.1.3",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Auto Bulldoze" },
            });

            Add(new ItemDetails {
                WorkshopId = 639486063,
                WorkshopName = "Automatic Bulldoze v2",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Auto Bulldoze" },
            });

            #endregion Auto Bulldoze / Rebuild

            #region Remove Animals

            // Verified

            Add(new ItemDetails {
                WorkshopId = 564141599,
                WorkshopName = "No Seagulls",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.2" },
                Categories = new string[] { "Remove Seagulls" },
            });

            Add(new ItemDetails {
                WorkshopId = 1706704781,
                WorkshopName = "Remove All Animals",
                Flags = ItemFlags.Unmaintained | ItemFlags.Unreliable,
                Categories = new string[] { "Remove Cows", "Remove Pigs", "Remove Seagulls", "Remove Wildlife" },
            });

            // Cows

            Add(new ItemDetails {
                WorkshopId = 421050717,
                WorkshopName = "[ARIS] Remove Cows",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 421028969 }, // overwatch 1
                Categories = new string[] { "Remove Cows" },
            });

            Add(new ItemDetails {
                WorkshopId = 587545554,
                WorkshopName = "Remove Cows [Fixed for v1.4 +]",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 583538182 }, // overwatch 1.3
                Categories = new string[] { "Remove Cows" },
            });

            Add(new ItemDetails {
                WorkshopId = 813835951,
                WorkshopName = "Remove Cows [1.6]",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 813833476 }, // overwatch 1.6
                Categories = new string[] { "Remove Cows" },
            });

            // Pigs

            Add(new ItemDetails {
                WorkshopId = 421052798,
                WorkshopName = "[ARIS] Remove Pigs",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 421028969 }, // overwatch 1
                Categories = new string[] { "Remove Pigs" },
            });

            Add(new ItemDetails {
                WorkshopId = 587549083,
                WorkshopName = "Remove Pigs [Fixed for v1.4+]",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 583538182 }, // overwatch 1.3
                Categories = new string[] { "Remove Pigs" },
            });

            Add(new ItemDetails {
                WorkshopId = 813835851,
                WorkshopName = "Remove Pigs [1.6]",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 813833476 }, // overwatch 1.6
                Categories = new string[] { "Remove Pigs" },
            });

            // Seagulls

            Add(new ItemDetails {
                WorkshopId = 417145328,
                WorkshopName = "[Deprecated] Kill the Seagulls!",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Remove Seagulls" },
            });

            Add(new ItemDetails {
                WorkshopId = 421041154,
                WorkshopName = "[ARIS] Remove Seagulls",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 421028969 }, // overwatch 1
                Categories = new string[] { "Remove Seagulls" },
            });

            Add(new ItemDetails {
                WorkshopId = 587536931,
                WorkshopName = "Remove Seagulls [Fixed for v1.4 +]",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 583538182 }, // overwatch 1.3
                Categories = new string[] { "Remove Seagulls" },
            });

            Add(new ItemDetails {
                WorkshopId = 813835673,
                WorkshopName = "Remove Seagulls [1.6]",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                RequiredItems = new ulong[] { 813833476 }, // overwatch 1.6
                Categories = new string[] { "Remove Seagulls" },
            });

            #endregion Remove Animals

            #region Content Manager / Options

            // Verified

            Add(new ItemDetails {
                WorkshopId = 814498849,
                WorkshopName = "Improved Content Manager",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.10", "1.11", "1.12" },
                Categories = new string[] { "Assets Panel", "Mods Panel" },
            });

            Add(new ItemDetails {
                WorkshopId = 632951976,
                WorkshopName = "Improved Mod Upload Panel",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.6", "1.12" },
                Categories = new string[] { "Mod Upload Panel" },
            });

            // Options screens

            Add(new ItemDetails {
                WorkshopId = 1762394554,
                WorkshopName = "Wider OptionsPanel",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Options Panel" },
            });

            Add(new ItemDetails {
                WorkshopId = 1773106708,
                WorkshopName = "More Advanced OptionsPanel",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Options Panel" },
            });

            Add(new ItemDetails {
                WorkshopId = 973512634,
                WorkshopName = "Sort Mod Settings",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Options Panel" },
            });

            // Improved assets panel

            Add(new ItemDetails {
                WorkshopId = 417430545,
                WorkshopName = "Improved Assets Panel",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Assets Panel" },
            });

            Add(new ItemDetails {
                WorkshopId = 449020940,
                WorkshopName = "Improved Assets Panel",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                Categories = new string[] { "Assets Panel" },
            });

            Add(new ItemDetails {
                WorkshopId = 448687553,
                WorkshopName = "Improved Assets Panel",
                Flags = ItemFlags.NoWorkshop | ItemFlags.GameBreaking,
                Categories = new string[] { "Assets Panel" },
            });

            // Improved mods panel

            Add(new ItemDetails {
                WorkshopId = 416033610,
                WorkshopName = "Improved Mods Panel",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Mods Panel" },
            });

            #endregion Content Manager / Options

            #region Real Time

            // Verified

            Add(new ItemDetails {
                WorkshopId = 1420955187, // dymanoid
                WorkshopName = "Real Time",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Real Time" },
            });

            Add(new ItemDetails {
                WorkshopId = 1749971558,
                WorkshopName = "Real Time Offline",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Real Time" },
            });

            // Broken

            Add(new ItemDetails {
                WorkshopId = 605590542,
                WorkshopName = "Rush Hour II",
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken | ItemFlags.ForceMigration | ItemFlags.Laggy,
                Categories = new string[] { "Real Time" },
            });

            // Game breaking

            // TODO: Find ID of Rush Hour I and add to list

            #endregion Real Time

            // todo
            #region Asset Editor

            // Game breaking

            // 443489442 - Custom Milestone Unlocker [Deprecated]

            Add(new ItemDetails {
                WorkshopId = 443489442, // gamebreaking since 1.1.0 game update
                WorkshopName = "Custom Asset Milestone Unlocker [Deprecated]",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking | ItemFlags.BreaksEditors,
                Categories = new string[] { "Asset Editor" },
            });

            #endregion

            #region Measurement

            // Verified

            Add(new ItemDetails {
                WorkshopId = 445589127,
                WorkshopName = "Precision Engineering",
                Flags = ItemFlags.Unmaintained | ItemFlags.Verified,
                GameVersion = new string[] { "1.11", "1.12" },
                Categories = new string[] { "Measurement" },
                CompatibleWith = new ulong[] { 1768810491 }, // measure it
            });

            Add(new ItemDetails {
                WorkshopId = 1768810491,
                WorkshopName = "Measure It!",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Measurement" },
                CompatibleWith = new ulong[] { 445589127 }, // precision engineering
            });

            // Game breaking

            Add(new ItemDetails {
                WorkshopId = 436253779,
                WorkshopName = "Road Protractor",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Measurement" },
            });

            #endregion Measurement

            #region Vehicle Options

            // Verified

            Add(new ItemDetails {
                WorkshopId = 1548831935, // Tim
                WorkshopName = "Advanced Vehicle Options AVO (Industries DLC ready)",
                Flags = ItemFlags.Verified,
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Vehicle Options" },
            });

            // Unmaintained

            Add(new ItemDetails {
                WorkshopId = 442167376, // BoogieManSam
                WorkshopName = "Advanced Vehicle Options (AVO)",
                Flags = ItemFlags.Unmaintained | ItemFlags.ForceMigration, // never going to be updated
                GameVersion = new string[] { "1.12" },
                Categories = new string[] { "Vehicle Options" },
            });

            // Broken

            Add(new ItemDetails {
                WorkshopId = 1228424498,
                WorkshopName = "Bzimage VehicleCapacity",
                Flags = ItemFlags.Unmaintained | ItemFlags.LongBroken | ItemFlags.ForceMigration,
                Categories = new string[] { "Vehicle Options" },
            });

            // Game breaking

            Add(new ItemDetails {
                // Field '.PassengerTrainAI.m_ticketPrice' not found. [System.MissingFieldException]
                WorkshopId = 414326578,
                WorkshopName = "Configurable Transport Capacity",
                Flags = ItemFlags.Unmaintained | ItemFlags.GameBreaking,
                Categories = new string[] { "Vehicle Options" },
            });

            #endregion Vehicle Options

        }
    }
}
