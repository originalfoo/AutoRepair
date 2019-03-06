using System.Collections.Generic;

namespace Incompatible.Replacements.Scripts
{
     /*
     * Why 'Resize It!' instead of 'More Advanced Toolbar'?
     * 
     * From end-user perspective, Resize It is easier to work with and has fewer
     * incompatibilities with other mods (particularly Find It and Ploppable RICO).
     * 
     * The replacement definition below will only prompt users to upgrade to Resize It
     * if they are using an old broken toolbar mod (denoted by '*' in deprecation list).
     * 
     * However, if users enable 'Show all upgrade recommendations' they will be asked
     * to upgrade from 'More Advanced Toolbar' to 'Resize It'.
     * 
     * If 'More Advanced Toolbar' is updated to be more compatible with other mods,
     * we will revise this repllacement script to offer a choice between the two mods.
    */

    class ResizeIt : ReplacementBase, IReplacement
    {
        protected new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1577882296, 1 } // Resize It! by Keallu
        };

        protected new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Enables you to resize build menus (toolbars), including Find It! and Ploppable RICO toolbars." }
        };

        protected new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 563229150, 1 },  // * Advanced Toolbar
            { 451700838, 1 },  // * Extended Toolbar
            { 1597852915, 1 }, // More advanced toolbar
            { 451906822, 1 },  // * Enhanced build panel
        };
    }
}
