using ColossalFramework.Plugins;

namespace ModFreshener.Replacements.Scripts
{
    class Limits : ReplacementBase
    {
        public Limits()
        {
            option.Add(1643902284, 1); // Watch It!

            note.Add(1, "'Watch It!' contains the most recent limits screen, and is compatible with the latest game version and DLCs.");

            deprecated.Add(531738447, 1); // Show more limits

            obsolete.Add(494094728, 1); // Show limits
        }

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            base.OnAfterSubscribe(plugin);

            // todo: enable limits display
        }
    }
}
