namespace AutoRepair {
    using System.Collections.Generic;
    using AutoRepair.Struct;
    using AutoRepair.Enums;
    using AutoRepair.Util;
    public partial class Reference {

        private static Reference instance;
        public static Reference Instance => instance ?? (instance = new Reference());

        public Dictionary<ulong, ItemDetails> Mods { get; set; } = new Dictionary<ulong, ItemDetails> { };

        public Dictionary<ulong, ItemDetails> Assets { get; set; } = new Dictionary<ulong, ItemDetails> { };

        public Reference() {

            PopulateMods();

        }

        internal void Add(ItemDetails info, bool autoConflict = false) {
#if DEBUG
            if (info.WorkshopId == 0u) {
                Log.Error("[Reference.Add] A workshop ID is missing.");
                return;
            }
            if (Mods.ContainsKey(info.WorkshopId)) {
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
                foreach (KeyValuePair<ulong, ItemDetails> entry in Mods) {
                    if (entry.Value.Replacements != null && entry.Value.Replacements.Contains(info.WorkshopId)) {
                        info.Conflicts.Add(entry.Value.WorkshopId);
                    }
                }

                // now go through each of the listed conflicts and fill in their missing conflicts
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
