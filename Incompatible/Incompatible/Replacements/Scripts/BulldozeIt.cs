using System.Collections.Generic;

namespace Incompatible.Replacements.Scripts
{
    class BulldozeIt : ReplacementBase, IReplacement
    {
        protected new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1627986403, 1 } // Bulldoze It! by Keallu
        };

        protected new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Provides automatic and manual bulldozing of abandoned, burnt, collapsed and flooded buildings directly on the bulldozer bar." }
        };

        protected new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 445799544, 1 },  // * V10Bulldoze
            { 406132323, 1 },  // * Automatic Bulldoze
            { 1393966192, 1 }, // * Automatic Bulldoze Simple Edition
            { 639486063, 1 },  // * Automatic Bulldoze v2
            { 503147777, 1 },  // * MoleDozer
            { 1628521230, 1 }, // Bulldoze Everything
            { 1507233911, 1 }, // Automatic Bulldoze
        };
    }
}
