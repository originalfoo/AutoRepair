namespace Incompatible.Replacements
{
     /*
     * Why recommend upgrading 'More Beautification' to 'Find It'?
     * 
     * 1. More Beautification mod causes severe lag (especially on potato computers) when
     *    opening the build menu.
     * 
     * 2. Find It provides access to far more assets, has additional filters and a search tool.
     * 
     * For these reasons, we believe that Find It is generally better for end-users.
    */

    public static class FindIt
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = true;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            837734529 // Find It! by SamSamTS
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

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
