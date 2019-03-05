using System.Collections.Generic;

namespace Incompatible.Replacements
{
    class AVO : ReplacementBase, IReplacement
    {
        public override bool Always => true;

        internal new Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>() {
            { 1548831935, 1 } // Advanced Vehicle Options by Tim
        };

        internal new Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "AVO allows you to customise vehicle stats (capacity, size, etc.) and colours, and also control which vehicles can spawn. Compatible with latest game version and all DLCs." }
        };

        internal new Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>() {
            { 442167376, 1 },  // Advanced Vehicle Options by SamSamTS
            { 1228424498, 1 }, // * Bzimage VehicleCapacity
            { 414326578, 1 },  // * Configurable Transport Capacity
        };
    }
}
