using System.Collections.Generic;

namespace Incompatible.Replacements
{
    class RoadOptions : ReplacementBase, IReplacement
    {
        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 932192868, 1 } // Road Options (Road Color Changer++) by TPB
        };

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Allows you to change road surface color, remove props and decals (lane markings, arrows, crossings)." }
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 417585852, 1 },  // * Road Color Changer (original)
            { 651610627, 1 },  // * Road Color Changer Continued
            { 1128766708, 1 }, // Remove Road Textures - Blank Roads
            { 1117087491, 1 }, // Remove Road Props
            { 1147015481, 1 }, // * No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
            { 956707300, 1 },  // Remove Street Arrows
        };
    }
}
