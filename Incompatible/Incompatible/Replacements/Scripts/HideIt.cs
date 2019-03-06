using System.Collections.Generic;
using static ColossalFramework.Plugins.PluginManager;

namespace Incompatible.Replacements.Scripts
{
    class HideIt : ReplacementBase, IReplacement
    {
        protected new Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1591417160, 1 } // Hide It! by Keallu
        };

        protected new Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Hide It enables you to hide a wide range of things in a fast, reliable manner." }
        };

        protected new Dictionary<ulong,byte> deprecates = new Dictionary<ulong,byte>()
        {
            // animal removal mods (all but one are broken)

            { 421050717, 1 },  // * [ARIS] Remove Cows .
            { 587545554, 1 },  // * Remove Cows [Fixed for v1.4 +] .
            { 813835951, 1 },  // * Remove Cows [1.6] .
            { 421052798, 1 },  // * [ARIS] Remove Pigs .
            { 587549083, 1 },  // * Remove Pigs [Fixed for v1.4 +] .
            { 813835851, 1 },  // * Remove Pigs [1.6] .
            { 421041154, 1 },  // * [ARIS] Remove Seagulls .
            { 587536931, 1 },  // * Remove Seagulls [Fixed for v1.4 +] .
            { 813835673, 1 },  // * Remove Seagulls [1.6] .
            { 564141599, 1 },  // No seagulls (this mod isn't broken) .

            // pollution mods

            { 407270433, 1 },  // * No more purple pollution (normal grass) .
            { 407795371, 1 },  // * No more purple pollution (brown grass) .
            { 407810495, 1 },  // * No more purple pollution (tan grass) .
            { 407842191, 1 },  // * No more purple pollution (red-brown grass) .
            { 407890452, 1 },  // * No more purple pollution (grey grass) .
            { 482360157, 1 },  // * No more purple pollution (radioactive green grass) .
            { 408126080, 1 },  // * No more purple pollution (brown water) .
            { 408126282, 1 },  // * No more purple pollution (green water) .
            { 408190203, 1 },  // * No more purple pollution (muddy water) .
            { 408189919, 1 },  // * No more purple pollution (silty water) .
            { 408167727, 1 },  // * No more purple pollution (radioactive green water) .
            { 491002883, 1 },  // Pale Green Pollution (Tropical Boreal) .
            { 490998828, 1 },  // Pale Green Pollition (Temperate) .
            { 491003892, 1 },  // Pale Green Pollution (European) .
            { 666425898, 1 },  // No radioactive desert and more! .

            // prop, effect and sprite removal mods

            { 547533304, 1 },  // Remove decoration sprites (grass and rocks) .
            { 548149310, 1 },  // Remove dirt (trees and props) .
            { 523824395, 1 },  // Clouds & Fog toggler
            { 518456166, 1 },  // Prop remover
            { 1627469414, 1 }, // No Parking (removes parking lots from broken builings)
            { 1117087491, 1 }, // Remove road props
            { 956707300, 1 },  // Remove street (lane) arrows .
            { 919020932, 1 },  // Stop remover .
            { 952542692, 1 },  // Airport road light remover
            { 949061920, 1 },  // No buoys mod .

            // ui removal mods

            { 417926819, 1 },  // * Road Assistant (note: Hide It obviously doesn't do the grid thing that this mod does, but does everything else)
            { 553319260, 1 },  // Hide border line and asset editor grid .
            { 417565011, 1 },  // NOtifications (building notification bubble remover) .
            { 561293123, 1 },  // Hide Problems aka Politicians' Mod .
            { 446764406, 1 },  // No border limit camera .
            { 433557907, 1 },  // District UI tweaks: Hide names .
            { 439360165, 1 },  // Hide district policy icons .
            { 451193058, 1 },  // The original hide policy icons .
            { 1536223783, 1 }, // Hide selectors .
            { 405791507, 1 },  // Chirpy exterminator .
            { 810373922, 1 },  // Remove chirper .
            { 648476299, 1 },  // Chirper remover .
            { 422603366, 1 },  // Disable chirper .
            { 411307025, 1 },  // Chirp remover .
        };

        // Hide It features (false = don't hide; true = hide)
        private bool cows = false;
        private bool pigs = false;
        private bool seagulls = false;
        private bool chirper = false;
        private bool policyIcons = false;
        private bool districtNames = false;
        private bool spritesGrass = false;
        private bool spritesRocks = false;
        private bool spritesFertility = false;
        private bool dirtTrees = false;
        private bool dirtProps = false;
        private bool cameraBounds = false;
        private bool borderLine = false;
        private bool buoys = false;
        private bool notifications = false;
        private bool stops = false; // bus and tram stops
        private bool roadArrows = false;
        private bool tramArrows = false;
        private bool bikeArrows = false;
        private bool colorShoreline = false;
        private bool colorPollutionGrass = false;
        private bool colorPollutionWater = false;
        private bool colorResourceFertility = false;
        private bool colorResourceOre = false;
        private bool colorResourceOil = false;
        private bool colorResourceForest = false;
        private bool effectPollution = false; // dead trees
        private bool effectShore = false; // dead trees
        private bool effectBurnt = false; // charred ground and buildings

        // determine which features should be enabled in Hide It
        public override void OnBeforeRemove(PluginInfo plugin)
        {
            ulong id = plugin.publishedFileID.AsUInt64;
            
            switch (id)
            {
                // remove cows
                case 421050717:
                case 587545554:
                case 813835951:
                    cows = cows || plugin.isEnabled;
                    break;

                // remove pigs
                case 421052798:
                case 587549083:
                case 813835851:
                    pigs = pigs || plugin.isEnabled;
                    break;

                // remove seagulls
                case 421041154:
                case 587536931:
                case 813835673:
                case 564141599:
                    seagulls = seagulls || plugin.isEnabled;
                    break;
                
                // chirper:
                case 405791507:
                case 810373922:
                case 648476299:
                case 422603366:
                case 411307025:
                    chirper = chirper || plugin.isEnabled;
                    break;

                // district names
                case 433557907:
                    districtNames = districtNames || plugin.isEnabled;
                    break;

                // district policy icons
                case 439360165:
                case 451193058:
                    policyIcons = policyIcons || plugin.isEnabled;
                    break;

                // terrain sprites (grass, rock and fertility)
                case 547533304:
                    if (plugin.isEnabled)
                    {
                        Settings.From547533304(out spritesFertility, out spritesGrass, out spritesRocks);
                    }
                    break;

                // dirt (trees and props)
                case 548149310:
                    if (plugin.isEnabled)
                    {
                        Settings.From548149310(out dirtTrees, out dirtProps);
                    }
                    break;

                // camera bounds
                case 446764406:
                    cameraBounds = cameraBounds || plugin.isEnabled;
                    break;

                // border line
                case 553319260:
                    borderLine = borderLine || plugin.isEnabled;
                    break;

                // buoys
                case 949061920:
                    buoys = buoys || plugin.isEnabled;
                    break;

                // bus & tram stops
                case 919020932:
                    stops = stops || plugin.isEnabled;
                    break;

                // lane arrows
                case 956707300:
                    if (plugin.isEnabled)
                    {
                        Settings.From956707300(out roadArrows, out tramArrows, out bikeArrows);
                    }
                    break;

                // notifications
                case 417565011:
                case 561293123:
                    notifications = notifications || plugin.isEnabled;
                    break;

                // water and land pollution
                case 407270433:
                case 407795371:
                case 407810495:
                case 407842191:
                case 407890452:
                case 482360157:
                case 408126080:
                case 408126282:
                case 408190203:
                case 408189919:
                case 408167727:
                case 491002883:
                case 490998828:
                case 491003892:
                    colorPollutionGrass = colorPollutionGrass || plugin.isEnabled;
                    colorPollutionWater = colorPollutionWater || plugin.isEnabled;
                    break;

                // pollution and effects
                case 666425898:
                    if (plugin.isEnabled)
                    {
                        Settings.From666425898(
                            out colorShoreline,
                            out colorPollutionGrass,
                            out colorResourceFertility,
                            out colorResourceOre,
                            out colorResourceOil,
                            out colorResourceForest,
                            out effectPollution,
                            out effectShore,
                            out effectBurnt
                        );
                    }
                    break;

                // ignore settings from...
                case 417926819:
                case 1536223783: // (use Ctrl+H instead of Alt+H)
                    break;
            }
        }

        public override void OnAfterSubscribe(PluginInfo plugin)
        {
            plugin.isEnabled = true;

            // set config options for the mod
        }
    }
}
