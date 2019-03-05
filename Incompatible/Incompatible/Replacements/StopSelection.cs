using System.Collections.Generic;

namespace Incompatible.Replacements
{
    class StopSelection : ReplacementBase, IReplacement
    {
        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1394468624, 1 } // Advanced Stop Selection by BloodyPenguin
        };

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Replaces outdated 'multitrack station enabler' mods." }
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 532863263, 1 }, // * Multi-track Station Enabler
            { 442957897, 1 }, // * Multi-track Station Enabler
        };
    }
}
