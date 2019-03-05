using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace Incompatible.Replacements
{
    class UnblockAll : ReplacementBase, IReplacement
    {
        public override Selection Mode => Selection.OnlyOne;

        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { Helper.CitiesSkylinesFeature, 1 }, // CSL 'Unlock All' Mod
            { 1237383751, 2 }, // Extended Game Options
        };

        // See Also: /Conflicts/ExtendedGameOptions.cs 

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "'Unlock All' mod is bundled with Cities: Skylines. It unlocks all milestones at the start of a game." },
            { 2, "'Extended Game Options' mod allows you to choose which milestone you want to start at." },
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 438378843, 3 },  // * UnlockAll
            { 431993428, 3 },  // * UnlockAll
            { 428555989, 3 },  // * UnlockAll
            { 428555664, 3 },  // * UnlockAll
            { 419329713, 3 },  // * UnlockAll
            { 418975267, 3 },  // * UnlockAll
            { 410614868, 3 },  // * EarlyUnlock
            { 443489442, 3 },  // * Custom Milestone Unlocker
            { 1242879105, 3 }, // Unlock Any Milestone
            { 407162294, 3 },  // All basic unlocks at the start
        };

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            PluginManager.PluginInfo mod;

            if (plugin == null)
            {
                mod = Helper.GetBundledMod("Unlock All");
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
