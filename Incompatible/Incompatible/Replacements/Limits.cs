namespace Incompatible.Replacements
{
    public static class Limits
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1643902284 // Watch It! by Keallu
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Includes a fast and updated limits screen which includes the latest game features."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            494094728, // Show limits
            531738447, // Show more limits
        };
    }
}
