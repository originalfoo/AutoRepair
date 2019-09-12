using ColossalFramework.Plugins;

namespace AutoRepair.Replacements.Scripts
{
    class TrafficManager : ReplacementBase
    {
        public TrafficManager()
        {
            option.Add(583429740, 1);  // TM:PE Stable
            option.Add(1637663252, 2); // TM:PE Labs

            note.Add(1, "TM:PE (Stable): Advanced traffic management tools for your city.");
            note.Add(2, "TM:PE (Labs): The experimental branch where you can try upcoming features, but there might be bugs!");

            deprecated.Add(411833858, 3); // Toggle Traffic Lights
            deprecated.Add(631930385, 3); // Realistic Vehicle Speeds
            deprecated.Add(407335588, 3); // No Despawn Mod
            deprecated.Add(600733054, 3); // No On-Street Parking

            obsolete.Add(492391912, 3);  // * Improvedd AI (Traffic++)
            obsolete.Add(409184143, 3);  // * Traffic++
            obsolete.Add(626024868, 3);  // * Traffic++ V2
            obsolete.Add(1581695572, 3); // * Traffic Manager: President Edition (temp bugfix)
            obsolete.Add(1348361731, 3); // * Traffic Manager: President Edition ALPHA/DEBUG
            obsolete.Add(498363759, 3);  // * Traffic Manager + Improved AI
            obsolete.Add(563720449, 3);  // * Traffic Manager + Improved AI (Japanese Ver.)
            obsolete.Add(1628112268, 3); // * RightTurnNoStop
            obsolete.Add(587530437, 3);  // * Remove Stuck Vehicles [Fixed for v1.4 +]
            obsolete.Add(813834836, 3);  // * Remove Stuck Vehicles [1.6]
        }

        // TMPE features related to deprecated/obsolete mods
        private bool speeds = false; // realistic vehicle speeds
        private bool despawn = false; // no despawn
        private bool parking = false; // parking restrictions
        private bool ai = false; // improved ai
        private bool redturn = false; // turn on red
        private bool lanes = false; // lane connector

        public override void OnBeforeRemove(PluginManager.PluginInfo plugin)
        {
            base.OnBeforeRemove(plugin); // track enabled state of removed mod(s)

            switch (plugin.publishedFileID.AsUInt64)
            {
                case 631930385:
                    speeds = plugin.isEnabled;
                    break;
                case 407335588:
                    despawn = plugin.isEnabled;
                    break;
                case 600733054:
                    parking = plugin.isEnabled;
                    break;
                case 492391912:
                    ai = plugin.isEnabled;
                    break;
                case 1628112268:
                    redturn = plugin.isEnabled;
                    break;
                case 409184143:
                case 626024868:
                    lanes = lanes || plugin.isEnabled;
                    break;
            }
        }

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            base.OnAfterSubscribe(plugin); // enable TMPE if applicable

            // todo: seet TMPE options based on private bools above
        }
    }
}
