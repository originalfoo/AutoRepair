namespace Incompatible.Replacements
{
    public static class RoadOptions
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            932192868 // Road Options (Road Color Changer++) by TPB
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Allows you to change road surface color, remove props and decals (lane markings, arrows, crossings)."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            417585852,  // * Road Color Changer (original)
            651610627,  // * Road Color Changer Continued
            1128766708, // Remove Road Textures - Blank Roads
            1117087491, // Remove Road Props
            1147015481, // * No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
            956707300,  // Remove Street Arrows
        };
    }
}
