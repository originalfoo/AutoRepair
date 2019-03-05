using System.Collections.Generic;

namespace Incompatible.Replacements
{
    class FineRoad : ReplacementBase, IReplacement
    {
        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 802066100, 1 }, // Fine Road Anarchy by SamSamTS
            { 651322972, 2 }, // Fine Road Tool by SamSamTS
        };

        internal new readonly Dictionary<byte,string> notes = new Dictionary<byte,string>()
        {
            { 1, "Fine Road Anarchy allows you to toggle bending (sharp junctions), snapping, collisions and slope/height limits." },
            { 2, "Fine Road Tool allows you to force elevated, bridge and tunnel modes, and also create smooth gradients when placing networks." },
            { 3, "It is recommended to use both 'Fine Road' mods together." },
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 418556522, 1|2 }, // * Road Anarchy
            { 954034590, 1|2 }, // * Road Anarchy V2
            { 1362508329, 1 },  // Fine Road Anarchy 2018
            { 433567230, 1|2 }, // Advanced Road Anarchy
            { 1436255148, 1 },  // Fine Road Anarchy (Chinese)
            { 553184329, 1 },   // * Sharp Junction Angles
            { 448434637, 2 },   // * Enhanced Road Heights
        };
    }
}
