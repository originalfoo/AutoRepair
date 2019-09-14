namespace AutoRepair {
    using System.Collections.Generic;
    using Struct;
    using Enums;
    using Util;
    public partial class Catalog {

        internal static Catalog instance;
        public static Catalog Instance => instance ?? (instance = new Catalog());

        public Dictionary<ulong, ItemDetails> Mods { get; set; } = new Dictionary<ulong, ItemDetails> { };

        //public Dictionary<ulong, ItemDetails> Assets { get; set; } = new Dictionary<ulong, ItemDetails> { };

        private Catalog() {

            Log.Info("[Catalog.ctor] Initialising catalog.");

            PopulateMods();
            if (!ValidateMods()) {
                return;
            }

        }

        internal void AddMod(ItemDetails info) {
            Log.Info($"[Catalog.AddMod] {info.WorkshopId} = {info.Name}");
            if (info.WorkshopId == 0u) {
                Log.Info($"ERROR [Catalog.AddMod] Workshop ID is missing: 0u ({info.Name})");
                return;
            }
            if (Mods.ContainsKey(info.WorkshopId)) {
                Log.Info($"ERROR [Catalog.AddMod] Duplicate key: {info.WorkshopId} ({info.Name})");
                return;
            }
            if (info.CompatibleWith == null) {
                Log.Info($"ERROR [Catalog.AddMod] Missing .CompatibleWith: {info.WorkshopId} ({info.Name})");
                return;
            }
            if (info.Categories == null) {
                Log.Info($"ERROR [Catalog.AddMod] Missing .Categories: {info.WorkshopId} ({info.Name})");
                return;
            }
            if (!ValidateItemCategories(info)) {
                return;
            }
            Mods.Add(info.WorkshopId, info);
        }

        internal bool ValidateItemCategories(ItemDetails info) {
            Log.Info($"[Catalog.ValidateItemCategories] {info.WorkshopId} = {info.Name}");
            bool success = true;
            foreach (string category in info.Categories) {
                if (!CategoryModes.ContainsKey(category)) {
                    Log.Info($"ERROR [Catalog.ValidateCategories] '{info.WorkshopId}' ({info.Name}) invalid category: {category}");
                    success = false;
                }
            }
            return success;
        }

        internal bool ValidateMods() {
            Log.Info("[Catalog.ValidateMods] Validating.");
            bool success = true;
            foreach (KeyValuePair<ulong,ItemDetails> entry in Mods) {
                ItemDetails currentMod = entry.Value;
                Log.Info($"[Catalog.ValidateMods] {currentMod.WorkshopId} = {currentMod.Name}");
                // check reciprocal `.CompatibleWith`
                foreach (ulong targetMod in currentMod.CompatibleWith) {
                    if (Mods.TryGetValue(targetMod, out ItemDetails otherMod)) {
                        if (!otherMod.CompatibleWith.Contains(currentMod.WorkshopId)) {
                            Log.Info($"ERROR [ValidateMods] Mod {currentMod.WorkshopId} ({currentMod.Name}) .CompatibleWith {targetMod} but not reciprocated.");
                        }
                    } else {
                        Log.Info($"ERROR [ValidateMods] Mod {currentMod.WorkshopId} ({currentMod.Name}) .CompatibleWith {targetMod} but not found.");
                    }
                }
            }
            return success;
        }

        /// <summary>
        /// Fake workshop id used to denote vanilla game feature.
        /// Can be used in <see cref="ItemDetails.Replacements"/> and <see cref="ItemDetails.Conflicts"/>
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
            { "HardMode", 6u },
        };

        /// <summary>
        /// Named references for commonly referred-to mods.
        /// </summary>
        public readonly Dictionary<string, ulong> Common = new Dictionary<string, ulong> {
            { "81Tiles", 576327847 },
            { "BulldozeIt", 1627986403 },
            { "EmptyIt", 1661072176 },
            { "FineRoadAnarchy", 802066100 }, // BoogieManSam
            { "FineRoadTool", 651322972 }, // BoogieManSam
            { "HideIt", 1591417160 },
            { "NoBorderCamera", 446764406 },
            { "NoSeagulls", 564141599 },
            { "PurchaseIt", 1612287735 },
            { "RealTime", 1420955187 },
            { "RebuildIt", 1656549865 },
            { "RemoveAllAnimals", 1706704781 },
            { "ShowIt", 1556715327 },
            { "TMPE_LinuxFan", 583429740 },
            { "TMPE_Krzychu", 1637663252 },
            { "TMPE_Aubergine", 1806963141 },
        };
    }
}
