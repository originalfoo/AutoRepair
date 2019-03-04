using ICities;
using static ColossalFramework.Plugins.PluginManager;

namespace Incompatible
{
    public static class Helper
    {
        public static string GetModName(PluginInfo pluginInfo)
        {
            string name = pluginInfo.name;
            IUserMod[] instances = pluginInfo.GetInstances<IUserMod>();
            if ((int)instances.Length > 0)
            {
                name = instances[0].Name;
            }
            return name;
        }

        /* todo - check subscribed first, and if not found there go to workshop
        public static string GetModName(ulong workshopId)
        {

        }
        */

        public static bool IsModBroken(PluginInfo pluginInfo)
        {
            return IsModBroken(pluginInfo.publishedFileID.AsUInt64);
        }

        public static bool IsModBroken(ulong workshopId)
        {
            return Broken.mods.ContainsKey(workshopId);
        }
    }
}
