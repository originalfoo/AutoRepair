using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace Incompatible.Replacements
{
    class UnlimitedSoil : ReplacementBase, IReplacement
    {
        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { Helper.CitiesSkylinesFeature, 1 } // CSL 'Unlimited Soil' Mod
        };

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "'Unlimited Soil' mod is now bundled with the base game. It removes the terraforming (soil) limit." },
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 654586812, 1 } // * No Soil Limit
        };

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            if (wasEnabled)
            {
                PluginManager.PluginInfo mod = Helper.GetBundledMod("Unlimited Soil");
                if (mod != null)
                {
                    mod.isEnabled = true;
                }
            }
        }
    }
}
