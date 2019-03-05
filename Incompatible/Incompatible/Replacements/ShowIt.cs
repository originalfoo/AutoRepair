using System.Collections.Generic;

namespace Incompatible.Replacements
{
    class ShowIt : ReplacementBase, IReplacement
    {
        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1556715327, 1 } // Show It! by Keallu
        };

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Reliable, accurate and fast vital indicators for zoned buildings." }
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 1133108993, 1 }, // * Extended Building Information (1.10+)
            { 767809751, 1 },  // * Extended Building Information (Chinese)
            { 414469593, 1 },  // * Extended Building Information
            { 670422128, 1 },  // * Extended Building Information
            { 928988785, 1 },  // * Extended Building Information
        };
    }
}
