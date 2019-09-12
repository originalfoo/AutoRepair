namespace AutoRepair.Util {
    using static ColossalFramework.Plugins.PluginManager;
    using static PluginTools;

    public static class PluginListFilters {
        public static bool IsCameraScript(PluginInfo plugin) => plugin.isCameraScript;

        public static bool IsBundledMod(PluginInfo plugin) => plugin.isBuiltin;

        public static bool IsBundledOrCameraScript(PluginInfo plugin) => IsBundledMod(plugin) || IsCameraScript(plugin);

        public static bool IsLocal(PluginInfo plugin) => HasWorkshopId(plugin, ulong.MaxValue);

        public static bool IsWorkshopMod(PluginInfo plugin) => !IsBundledOrCameraScript(plugin) && !IsLocal(plugin);

        // Advanced filters

        public static bool IsNamed(PluginInfo plugin, string name) => GetModName(plugin) == name;

        public static bool NameContains(PluginInfo plugin, string text) => GetModName(plugin).Contains(text);

        public static bool HasWorkshopId(PluginInfo plugin, ulong workshopId) => plugin.publishedFileID.AsUInt64 == workshopId;
    }
}