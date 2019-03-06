using System.Collections.Generic;

namespace Incompatible.Replacements.Scripts
{
    class TrafficManager : ReplacementBase, IReplacement
    {
        public override Selection Mode => Selection.OnlyOne;

        protected new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 583429740, 1 },  // TM:PE Stable
            { 1637663252, 2 }, // TM:PE Labs
        };

        protected new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "TM:PE (Stable): Advanced traffic management tools for your city." },
            { 2, "TM:PE (Labs): The experimental branch where you can try upcoming features, but there might be bugs!" },
        };

        protected new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 492391912, 3 },  // * Improvedd AI (Traffic++)
            { 409184143, 3 },  // * Traffic++
            { 626024868, 3 },  // * Traffic++ V2
            { 1581695572, 3 }, // * Traffic Manager: President Edition (temp bugfix)
            { 1348361731, 3 }, // * Traffic Manager: President Edition ALPHA/DEBUG
            { 498363759, 3 },  // * Traffic Manager + Improved AI
            { 563720449, 3 },  // * Traffic Manager + Improved AI (Japanese Ver.)
            { 407335588, 3 },  // No Despawn Mod
            { 600733054, 3 },  // No On-Street Parking
            { 1628112268, 3 }, // * RightTurnNoStop
            { 411833858, 3 },  // Toggle Traffic Lights
            { 631930385, 3 },  // Realistic Vehicle Speeds
            { 587530437, 3 },  // * Remove Stuck Vehicles [Fixed for v1.4 +]
            { 813834836, 3 },  // * Remove Stuck Vehicles [1.6]
        };
    }
}
