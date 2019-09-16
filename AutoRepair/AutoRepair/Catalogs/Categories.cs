using System.Collections.Generic;
using AutoRepair.Enums;
using AutoRepair.Structs;
using AutoRepair.Util;

namespace AutoRepair.Catalogs {
    // TODO: The categories should probably be flags or something like that, which would
    //       remove the need for the ValidateItem() method and also facilitate much faster
    //       filtering by category. Will probably make this change once the mod is nearing
    //       completion and a full list of categories is known.

    /// <summary>
    /// Workshop items are grouped in to one or more 'conflict' categories, as listed in their
    /// <see cref="ItemDetails.Categories"/> field.
    ///
    /// All items in a category are considered incompatible, unless specificaly stated
    /// othrewise by the <see cref="ItemDetails.CompatibleWith"/> list.
    ///
    /// If the user wants to replace old or broken item with something better, only
    /// <see cref="ItemFlags.Verified"/> items in the categories will be suggested.
    ///
    /// When replacing items, all verified items in the listed categories are combined in to
    /// a list and the lowest <see cref="SelectMode"/> of the applicable categories
    /// will then determine how many choices can be made.
    /// </summary>
    public class Categories {

        internal const SelectMode
            One = SelectMode.ChooseOne,
            None = SelectMode.ChooseNone,
            Any = SelectMode.ChooseAny,
            All = SelectMode.ChooseAll;

        internal static Categories instance;
        public static Categories Instance => instance ?? (instance = new Categories());

        Categories() { }

        public bool ValidateItem(ItemDetails info) {
            //Log.Info($"[Catalog.ValidateItemCategories] {info.WorkshopId} = {info.Name}");
            bool success = true;
            if (info.Categories == null) {
                Log.Info($"WARNING [Categories.Validate] '{info.WorkshopId}' ({info.WorkshopName}) has no categories.");
                info.Categories = new string[] { };
            } else {
                foreach (string category in info.Categories) {
                    if (!Lookup.ContainsKey(category)) {
                        Log.Info($"ERROR [Categories.Validate] '{info.WorkshopId}' ({info.WorkshopName}) invalid category: {category}");
                        success = false;
                    }
                }
            }
            return success;
        }

        public readonly Dictionary<string, SelectMode> Lookup = new Dictionary<string, SelectMode> {

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
            { "Unlock All", One }, // always include any applicable unlocks below
            { "Unlock Landscape", One },
            { "Unlock Roads", One },
            { "Unlock Tracks", One },
            { "Unlock Buildings", One },
            { "Unlock Districts", One },
            { "Unlock Monuments", One },
            { "Unlock Transport", One },
            { "Unlock Uniques", One },
            { "Unlock Wonders", One },
            { "Vehicle Options", One },

        };
    }
}
