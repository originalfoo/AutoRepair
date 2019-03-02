namespace Incompatible.Replacements
{
     /*
     * Why 'Resize It!' instead of 'More Advanced Toolbar'?
     * 
     * From end-user perspective, Resize It is easier to work with and has fewer
     * incompatibilities with other mods (particularly Find It and Plop The Growables).
     * 
     * The replacement definition below will only prompt users to upgrade to Resize It
     * if they are using an old broken toolbar mod (denoted by '*' in deprecation list).
     * 
     * However, if users enable 'Show all upgrade recommendations' they will be asked
     * to upgrade from 'More Advanced Toolbar' to 'Resize It!'.
     * 
     * If 'More Advanced Toolbar' is updated to be more compatible with other mods,
     * we will revise this repllacement script to offer a choice between the two mods.
    */

    public static class ResizeIt
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1577882296 // Resize It! by Keallu
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Enables you to resize build menus (toolbars), including Find It! and Ploppable RICO toolbars."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            563229150,  // * Advanced Toolbar
            451700838,  // * Extended Toolbar
            1597852915, // More advanced toolbar
            451906822,  // * Enhanced build panel
        };
    }
}
