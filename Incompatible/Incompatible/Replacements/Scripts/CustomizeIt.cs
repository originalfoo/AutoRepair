using System.Collections.Generic;

namespace Incompatible.Replacements.Scripts
{
    class CustomizeIt : ReplacementBase, IReplacement
    {
        protected new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1369729955, 1 } // Customize It! by TPB
        };

        protected new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Allows you to customise stats of most ploppable buildings." }
        };

        protected new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 785237088, 1 } // * Service Radius Adjuster
        };
    }
}
