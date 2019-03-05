using System.Collections.Generic;

namespace Incompatible.Replacements
{
    class NetworkSkins : ReplacementBase, IReplacement
    {
        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 543722850, 1 } // Network Skins by BloodyPenguin and Boformer
        };

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Allows you to remove or change pillars, trees and lights of road networks." }
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 409073164, 1 }, // * No Pillars
            { 463845891, 1 }, // No Pillars (v1.1 compatible)
            { 547126602, 1 }, // Street light replacer
            { 423934526, 1 }, // Tree Replacer
        };
    }
}