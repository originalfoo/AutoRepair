using ColossalFramework.Plugins;

namespace AutoRepair.Replacements.Scripts
{
    class UnlimitedSoil : ReplacementBase
    {
        public UnlimitedSoil()
        {
            option.Add(Helper.CitiesSkylinesFeature, 1); // CSL 'Unlimited Soil' Mod

            note.Add(1, "'Unlimited Soil' mod is bundled with the base game. It removes the terraforming (soil) limit.");

            obsolete.Add(654586812, 1); // * No Soil Limit
        }

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            if (wasEnabled)
            {
                Helper.SetBundledModState("Unlimited Soil", true);
            }
        }
    }
}
