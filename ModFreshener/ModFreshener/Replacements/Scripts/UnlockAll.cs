using ColossalFramework.Plugins;

namespace ModFreshener.Replacements.Scripts
{
    class UnlockAll : ReplacementBase
    {
        public UnlockAll()
        {
            option.Add(Helper.CitiesSkylinesFeature, 1); // CSL 'Unlock All' Mod
            option.Add(1237383751, 2); // Extended Game Options (See Also: /Conflicts/ExtendedGameOptions.cs)

            note.Add(1, "'Unlock All' mod is bundled with Cities: Skylines. It unlocks all milestones at the start of a game.");
            note.Add(2, "'Extended Game Options' mod allows you to choose which milestone you want to start at.");

            deprecated.Add(1242879105, 3); // Unlock Any Milestone
            deprecated.Add(407162294, 3);  // All basic unlocks at the start

            obsolete.Add(438378843, 3); // * UnlockAll
            obsolete.Add(431993428, 3); // * UnlockAll
            obsolete.Add(428555989, 3); // * UnlockAll
            obsolete.Add(428555664, 3); // * UnlockAll
            obsolete.Add(419329713, 3); // * UnlockAll
            obsolete.Add(418975267, 3); // * UnlockAll
            obsolete.Add(410614868, 3); // * EarlyUnlock
            obsolete.Add(443489442, 3); // * Custom Milestone Unlocker
        }

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            PluginManager.PluginInfo mod = plugin ?? Helper.GetBundledMod("Unlock All");

            if (wasEnabled && mod != null)
            {
                mod.isEnabled = true;
            }
        }
    }
}
