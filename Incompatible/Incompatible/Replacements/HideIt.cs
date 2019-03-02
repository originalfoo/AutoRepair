namespace Incompatible.Replacements
{
    public static class HideIt
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1591417160 // Hide It! by Keallu
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "This mod uses a consistent, fast and reliable approach to hiding/removing things."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {

            // animal removal mods (all but one are broken)

            421050717,  // * [ARIS] Remove Cows
            587545554,  // * Remove Cows [Fixed for v1.4 +]
            813835951,  // * Remove Cows [1.6]
            421052798,  // * [ARIS] Remove Pigs
            587549083,  // * Remove Pigs [Fixed for v1.4 +]
            813835851,  // * Remove Pigs [1.6]
            421041154,  // * [ARIS] Remove Seagulls
            587536931,  // * Remove Seagulls [Fixed for v1.4 +]
            813835673,  // * Remove Seagulls [1.6]
            564141599,  // No seagulls (this mod isn't broken)

            // pollution, prop, effect and sprite removal mods

            407270433,  // * No more purple pollution (normal grass)
            407795371,  // * No more purple pollution (brown grass)
            407810495,  // * No more purple pollution (tan grass)
            407842191,  // * No more purple pollution (red-brown grass)
            407890452,  // * No more purple pollution (grey grass)
            482360157,  // * No more purple pollution (radioactive green grass)
            408126080,  // * No more purple pollution (brown water)
            408126282,  // * No more purple pollution (green water)
            408190203,  // * No more purple pollution (muddy water)
            408189919,  // * No more purple pollution (silty water)
            408167727,  // * No more purple pollution (radioactive green water)
            666425898,  // No radioactive desert and more!
            547533304,  // Remove decoration sprites (grass and rocks)
            548149310,  // Remove dirt (trees and props)
            523824395,  // Clouds & Fog toggler
            518456166,  // Prop remover
            1627469414, // No Parking (removes parking lots from broken builings)
            1117087491, // Remove road props
            956707300,  // Remove street (lane) arrows
            919020932,  // Stop remover
            952542692,  // Airport road light remover
            949061920,  // No buoys mod

            // ui removal mods

            553319260,  // Hide border line and asset editor grid
            417565011,  // NOtifications (building notification bubble remover)
            561293123,  // Hide Problems aka Politicians' Mod
            446764406,  // No border limit camera
            433557907,  // District UI tweaks: Hide names
            439360165,  // Hide district policy icons
            451193058,  // The original hide policy icons
            1536223783, // Hide selectors
            405791507,  // Chirpy exterminator
            810373922,  // Remove chirper
            648476299,  // Chirper remover
            422603366,  // Disable chirper
            411307025,  // Chirp remover

        };
    }
}
