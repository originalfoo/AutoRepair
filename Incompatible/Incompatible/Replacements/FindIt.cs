using static ColossalFramework.Plugins.PluginManager;

namespace Incompatible.Replacements
{
    /*
    * Why recommend upgrading 'More Beautification' to 'Find It'?
    * 
    * 1. More Beautification mod causes severe lag (especially on potato computers) when
    *    opening the build menu.
    * 
    * 2. Find It provides access to far more assets, has additional filters and a search tool.
    * 
    * 3. Find It is a prerequisite for some popular mods, such as Plop the Growables
    * 
    * For these reasons, 'Find It' is considered more suitable for end-users.
   */

    public class FindIt : IReplacement
    {
        public bool Always => true;

        public ulong[] Replacements = { 837734529u }; // Find It! by SamSamTS

        public bool Combined => false;

        public string Notes => "A fast searchable and filterable build menu providing access to all assets including props.";

        public readonly ulong[] Deprecates =
        {
            540758804, // * Search Box Mod
            505480567, // More beautification (causes lag)
        };

        public void OnBeforeRemove(PluginInfo plugin)
        {
            // do nothing
        }

        public void OnAfterRemove(PluginInfo plugin)
        {
            // do nothing
        }

        public void OnAfterSubscribe(PluginInfo plugin)
        {
            plugin.isEnabled = true;
        }

    }
}
