using ColossalFramework.Plugins;

namespace AutoRepair.Replacements.Scripts
{
    class UnlimitedMoney : ReplacementBase
    {
        public UnlimitedMoney()
        {
            option.Add(Helper.CitiesSkylinesFeature, 1); // CSL 'Unlimited Money' Mod

            note.Add(1, "'Unlimited Money' mod is bundled with Cities: Skylines.");

            // loads of "UnlimitedMoney" mods
            obsolete.Add(438378612, 1);
            obsolete.Add(428608882, 1);
            obsolete.Add(427997113, 1);
            obsolete.Add(427901620, 1);
            obsolete.Add(424026003, 1);
            obsolete.Add(422901712, 1);
            obsolete.Add(420911882, 1);
            obsolete.Add(420550550, 1);
            obsolete.Add(419484397, 1);
            obsolete.Add(419333753, 1);
            obsolete.Add(418153488, 1);
            obsolete.Add(417187838, 1);
        }

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            if (wasEnabled)
            {
                Helper.SetBundledModState("Unlimited Money", true);
            }
        }
    }
}
