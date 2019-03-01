namespace Incompatible.Replacements
{
    public static class BulldozeIt
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1627986403 // Bulldoze It! by Keallu
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Provides automatic and manual bulldozing of abandoned, burnt, collapsed and flooded buildings directly on the bulldozer bar."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            445799544,  // * V10Bulldoze
            406132323,  // * Automatic Bulldoze
            1393966192, // * Automatic Bulldoze Simple Edition
            639486063,  // * Automatic Bulldoze v2
            503147777,  // * MoleDozer
            1628521230, // Bulldoze Everything
            1507233911, // Automatic Bulldoze
        };
    }
}
