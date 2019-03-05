using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace Incompatible.Replacements
{
    class UnlimitedResources : ReplacementBase, IReplacement
    {
        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { Helper.CitiesSkylinesFeature, 1 } // CSL Inbuilt Mod
        };

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Cities: Skylines now contains this feature in the base game." },
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            // todo
        };

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            if (wasEnabled)
            {
                PluginManager.PluginInfo mod = Helper.GetBundledMod("Unlimited Oil And Ore");
                if (mod != null)
                {
                    mod.isEnabled = true;
                }
            }
        }
    }
}
