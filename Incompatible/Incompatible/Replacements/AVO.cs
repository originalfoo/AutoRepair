namespace Incompatible.Replacements
{
    public static class AVO
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = true;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1548831935 // Advanced Vehicle Options - Industries Ready by Tim
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Updated version of AVO that puts vehicles in right categories, compatible with latest game version and DLCs."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            442167376, // Advanced Vehicle Options
        };
    }
}
