using ColossalFramework.Plugins;

namespace Incompatible.Replacements.Scripts
{
    class UnlimitedResources : ReplacementBase
    {
        public UnlimitedResources()
        {
            option.Add(Helper.CitiesSkylinesFeature, 1); // CSL 'Unlimited Oil and Ore' Mod
            option.Add(1237383751, 2); // Extended Game Options (See Also: /Conflicts/ExtendedGameOptions.cs)

            note.Add(1, "'Infinite Oil and Ore' mod is bundled with Cities: Skylines.");
            note.Add(2, "'Extended Game Options' allows to set custom depletion rate for oil and ore; set to 0 for no depletion (infinite resource).");

            obsolete.Add(852103955, 3); // * InfiniteOilAndOre
            obsolete.Add(580335918, 3); // * Infinite Oil And Ore Redux
        }

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            PluginManager.PluginInfo mod = plugin ?? Helper.GetBundledMod("Unlimited Oil And Ore");

            if (wasEnabled && mod != null)
            {
                mod.isEnabled = true;
            }
        }
    }
}
