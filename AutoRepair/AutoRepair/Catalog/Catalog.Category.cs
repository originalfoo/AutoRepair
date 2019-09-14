namespace AutoRepair {
    using System.Collections.Generic;
    using Enums;
    using Struct;

    /// <summary>
    /// Workshop items are grouped in to one or more 'conflict' <see cref="ItemDetails.Categories"/>.
    ///
    /// All items in a category are considered incompatible, unless specificaly stated
    /// othrewise by the <see cref="ItemDetails.CompatibleWith"/> list.
    ///
    /// If the user wants to replace old or broken item with something better, the
    /// <see cref="ItemFlags.Verified"/> items in the categories will be suggested.
    ///
    /// When replacing items, all verified items in the listed categories are combined in to
    /// a list and the lowest <see cref="SelectMode"/> of the applicable categories
    /// will then determine what choices can be made.
    /// </summary>
    public partial class Catalog {

        internal const SelectMode
            One = SelectMode.ChooseOne,
            None = SelectMode.ChooseNone,
            Any = SelectMode.ChooseAny,
            All = SelectMode.ChooseAll;

        public Dictionary<string, SelectMode> CategoryModes = new Dictionary<string, SelectMode> {

            { "25 Tiles", One },
            { "81 Tiles", One },
            { "Asset Editor", Any },
            { "Assets Panel", One },
            { "Auto Bulldoze", Any },
            { "Auto Empty", One },
            { "Building Info", One },
            { "Bulldoze", None },
            { "Road Anarchy", All },
            { "Garbage AI", None },
            { "Hard Mode", One },
            { "Hearse AI", None },
            { "Measurement", Any }, // as in distance, not performance
            { "Milestone Tweaks", Any }, // tweaks milestones without unlocking
            { "Mods Panel", One },
            { "Mod Upload Panel", One },
            { "Options Panel", One },
            { "Overwatch", None },
            { "Real Time", One },
            { "Remove Cows", One },
            { "Remove Pigs", One },
            { "Remove Seagulls", One },
            { "Remove Wildlife", One },
            { "TMPE", One },
            { "Unlimited Money", One },
            { "Unlimited Oil & Ore", One },
            { "Unlimited Soil", One },
            { "Unlock All", One }, // always include the other relevant unlocks below
            { "Unlock Landscape", One },
            { "Unlock Roads", One },
            { "Unlock Tracks", One },
            { "Unlock Buildings", One },
            { "Unlock Districts", One },
            { "Unlock Monuments", One },
            { "Unlock Transport", One },
            { "Unlock Uniques", One },
            { "Unlock Wonders", One },

        };
    }
}
