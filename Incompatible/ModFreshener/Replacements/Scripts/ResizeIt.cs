namespace ModFreshener.Replacements.Scripts
{
     /*
     * Why 'Resize It!' instead of 'More Advanced Toolbar'?
     * 
     * From end-user perspective, Resize It is easier to work with and has fewer
     * incompatibilities with other mods (particularly Find It and Ploppable RICO).
    */

    class ResizeIt : ReplacementBase
    {
        public ResizeIt()
        {
            option.Add(1577882296, 1); // Resize It! by Keallu

            note.Add(1, "'Resize It!' lets you to resize build menus (toolbars), including Find It! and Ploppable RICO.");

            deprecated.Add(1597852915, 1); // More advanced toolbar

            obsolete.Add(563229150, 1); // * Advanced Toolbar
            obsolete.Add(451700838, 1); // * Extended Toolbar
            obsolete.Add(451906822, 1); // * Enhanced build panel
        }
    }
}
