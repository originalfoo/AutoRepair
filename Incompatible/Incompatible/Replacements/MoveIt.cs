using System.Collections.Generic;

namespace Incompatible.Replacements
{
    class MoveIt : ReplacementBase, IReplacement
    {
        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1619685021, 1 } // Move It! by Quboid
        };

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Powerful and reliable tool to move and align networks, props and more." }
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 658653260, 1 },  // * Network nodes editor
            { 1434173135, 1 }, // * Move It (Chinese version)
            { 1120637951, 1 }, // * Move It Extra Filters
            { 1622545887, 1 }, // * Move It (Legacy Edition)
        };
    }
}
