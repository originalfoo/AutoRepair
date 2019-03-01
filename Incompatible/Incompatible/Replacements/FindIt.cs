namespace Incompatible.Replacements
{
    public static class FindIt
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            837734529 // Find It! by SamSamTS
        };

        // why do the upgrade?
        static readonly string[] why = {
            "A fast searchable and filterable build menu providing access to all assets including props."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            540758804, // * Search Box Mod
            505480567, // More beautification (causes lag)
        };
    }
}
