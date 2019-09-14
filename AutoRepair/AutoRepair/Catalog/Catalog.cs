namespace AutoRepair.Catalog {
    using System.Collections.Generic;
    using Struct;
    using Util;

    /// <summary>
    /// Fake workshop id used to denote vanilla game feature.
    /// Can be used in <see cref="ItemDetails.Replacements"/> and <see cref="ItemDetails.CompatibleWith"/>.
    ///
    /// Do not ever use <c>0</c> for the <c>ulong</c>, as it is default <c>ulong</c> value and we don't want
    /// weird errors happening in future.
    /// </summary>
    public static class Vanilla {
        public static ulong BaseGame = 1u;
        public static ulong UnlockAll = 2u;
        public static ulong UnlimitedMoney = 3u;
        public static ulong UnlimitedSoil = 4u;
        public static ulong UnlimitedOilOre = 5u;
        public static ulong HardMode = 6u;
    }

    public partial class Catalog {

        internal static Catalog instance;
        public static Catalog Instance => instance ?? (instance = new Catalog());

        public static Dictionary<ulong, ItemDetails> Mods = new Dictionary<ulong, ItemDetails> { };

        //public Dictionary<ulong, ItemDetails> Assets { get; set; } = new Dictionary<ulong, ItemDetails> { };

        private Catalog() {

            Log.Info("[Catalog.ctor] Initialising catalog.");

            PopulateMods();
            if (!ValidateMods()) {
                return;
            }

        }

        internal static void AddMod(ItemDetails info) {
            //Log.Info($"[Catalog.AddMod] {info.WorkshopId} = {info.Name}");
            if (info.WorkshopId == 0u) {
                Log.Info($"ERROR [Catalog.AddMod] Workshop ID is missing: 0u ({info.Name})");
                return;
            }
            if (Mods.ContainsKey(info.WorkshopId)) {
                Log.Info($"ERROR [Catalog.AddMod] Duplicate key: {info.WorkshopId} ({info.Name})");
                return;
            }
            if (info.Categories == null) {
                Log.Info($"WARN [Catalog.AddMod] Missing .Categories: {info.WorkshopId} ({info.Name})");
                return;
            }
            if (!ValidateItemCategories(info)) {
                return;
            }
            Mods.Add(info.WorkshopId, info);
        }

        internal static bool ValidateItemCategories(ItemDetails info) {
            //Log.Info($"[Catalog.ValidateItemCategories] {info.WorkshopId} = {info.Name}");
            bool success = true;
            foreach (string category in info.Categories) {
                if (!Categories.Lookup.ContainsKey(category)) {
                    Log.Info($"ERROR [Catalog.ValidateCategories] '{info.WorkshopId}' ({info.Name}) invalid category: {category}");
                    success = false;
                }
            }
            return success;
        }

        internal static bool ValidateMods() {
            Log.Info("[Catalog.ValidateMods] Validating.");
            bool success = true;
            foreach (KeyValuePair<ulong,ItemDetails> entry in Mods) {
                ItemDetails currentMod = entry.Value;
                //Log.Info($"[Catalog.ValidateMods] {currentMod.WorkshopId} = {currentMod.Name}");
                // check reciprocal `.CompatibleWith`
                if (currentMod.CompatibleWith != null) {
                    foreach (ulong targetMod in currentMod.CompatibleWith) {
                        if (Mods.TryGetValue(targetMod, out ItemDetails otherMod) && otherMod.CompatibleWith != null) {
                            List<ulong> reciprocates = new List<ulong>(otherMod.CompatibleWith);
                            if (!reciprocates.Contains(currentMod.WorkshopId)) {
                                Log.Info($"ERROR [Catalog.ValidateMods] Mod {currentMod.WorkshopId} ({currentMod.Name}) .CompatibleWith {targetMod} but not reciprocated.");
                            }
                        } else {
                            Log.Info($"ERROR [Catalog.ValidateMods] Mod {currentMod.WorkshopId} ({currentMod.Name}) .CompatibleWith {targetMod} but not found.");
                        }
                    }
                }
            }
            return success;
        }
    }
}
