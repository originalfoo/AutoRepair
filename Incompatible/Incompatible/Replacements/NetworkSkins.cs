namespace Incompatible.Replacements
{
    public static class NetworkSkins
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            543722850 // Network Skins by BloodyPenguin and Boformer
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Allows you to remove or change pillars, trees and lights of road networks."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            409073164, // * No Pillars
            463845891, // No Pillars (v1.1 compatible)
            547126602, // Street light replacer
            423934526, // Tree Replacer
        };
    }
}
