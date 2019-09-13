namespace AutoRepair {
    using System.Collections.Generic;
    using AutoRepair.Struct;
    using AutoRepair.Enums;
    using AutoRepair.Util;
    public partial class Catalog {

        internal static Catalog instance;
        public static Catalog Instance => instance ?? (instance = new Catalog());

        public Dictionary<ulong, ItemDetails> Mods { get; set; } = new Dictionary<ulong, ItemDetails> { };

        public Dictionary<ulong, ItemDetails> Assets { get; set; } = new Dictionary<ulong, ItemDetails> { };

        private Catalog() {

            PopulateMods();

        }

        internal void AddMod(ItemDetails info) {
            if (info.WorkshopId == 0u) {
                Log.Error("[Catalog.Add] A workshop ID is missing.");
                return;
            }
            if (Mods.ContainsKey(info.WorkshopId)) {
                Log.Error($"[Catalog.Add] Duplicate key: {info.WorkshopId} '{info.Name}'");
                return;
            }
            Mods.Add(info.WorkshopId, info);
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
