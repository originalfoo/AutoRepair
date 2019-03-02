namespace Incompatible.Replacements
{
    public static class FineRoad
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            802066100, // Fine Road Anarchy by SamSamTS
            651322972, // Fine Road Tool by SamSamTS
        };

        // treat replacements as single combined item?
        static readonly bool combined = true;

        // why do the upgrade?
        static readonly string[] why = {
            "Fine Road Anarchy allows you to toggle bending (sharp junctions), snapping, collisions and slope/height limits.",
            "Fine Road Tool allows you to force elevated, bridge and tunnel modes, and also create smooth gradients when placing networks."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            418556522,  // * Road Anarchy
            954034590,  // * Road Anarchy V2
            1362508329, // Fine Road Anarchy 2018
            433567230,  // Advanced Road Anarchy
            1436255148, // Fine Road Anarchy (Chinese)
            553184329,  // * Sharp Junction Angles
            448434637,  // * Enhanced Road Heights
        };
    }
}
