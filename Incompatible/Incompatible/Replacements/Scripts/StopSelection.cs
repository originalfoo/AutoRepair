using System.Collections.Generic;

namespace Incompatible.Replacements.Scripts
{
    class StopSelection : ReplacementBase, IReplacement
    {
        protected new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1394468624, 1 } // Advanced Stop Selection by BloodyPenguin
        };

        protected new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Replaces outdated 'multitrack station enabler' mods." }
        };

        protected new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 532863263, 1 }, // * Multi-track Station Enabler
            { 442957897, 1 }, // * Multi-track Station Enabler
        };
    }
}
