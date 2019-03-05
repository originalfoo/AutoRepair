using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace Incompatible.Replacements
{
    class UnlimitedResources : ReplacementBase, IReplacement
    {
        public override Selection Mode => Selection.OnlyOne;

        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { Helper.CitiesSkylinesFeature, 1 }, // CSL 'Unlimited Oil and Ore' Mod
            { 1237383751, 2 }, // Extended Game Options
        };

        // See Also: /Conflicts/ExtendedGameOptions.cs 

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "'Infinite Oil and Ore' is bundled with the base game and does what it says on the tin." },
            { 2, "'Extended Game Options' allows you to choose custom depletion rates for oil and ore." }
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 852103955, 3 },  // * InfiniteOilAndOre
            { 580335918, 3 },  // * Infinite Oil And Ore Redux
        };

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            PluginManager.PluginInfo mod;

            if (plugin == null)
            {
                mod = Helper.GetBundledMod("Unlimited Oil And Ore");
            }
            else
            {
                mod = plugin;
            }

            if (wasEnabled && mod != null)
            {
                mod.isEnabled = true;
            }
        }
    }
}
