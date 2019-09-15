
/// <summary>
/// Auto-enables the mod when it is first subscribed.
///
/// Why? Users with old 'Improved Mods Panel' mod can't access Content Manager > Mods.
/// </summary>

namespace AutoRepair.Features {
    using Util;
    using ColossalFramework.UI;
    using static ColossalFramework.Plugins.PluginManager;
    using System;

    public static class AutoEnable {
        internal static bool loadingEvent = false;

        /// <summary>
        /// Called from <c>Mod.ctor</c>, only when the mod is first subscribed.
        ///
        /// 1. Prevent further calls by setting SelfEnableOnStartup = false
        /// 2. Determine when <c>SelfEnable()</c> is safe to call.
        /// </summary>
        public static void Prepare() {
            Log.Info("[AutoEnable.Prepare] Preparing.");
            try {
                if (UIView.GetAView() == null) {
                    LoadingManager.instance.m_introLoaded += Run;
                } else {
                    Run();
                }
            }
            catch (Exception e) {
                Log.Error($"ERROR [AutoEnable.Prepare] {e.Message}");
            }
        }

        /// <summary>
        /// 1. Find AutoRepair mod
        /// 2. Enable it
        /// </summary>
        public static void Run() {
            Log.Info("[AutoEnable.Run] Auto-enabling AutoRepair mod.");
            try {
                PluginInfo self = PluginTools.FirstOrNull(
                    PluginTools.FilterPluginList((PluginInfo mod) => {
                        return PluginListFilters.IsNamed(mod, VersionTools.ModName);
                    }, true
                ));

                if (self == null) {
                    Log.Info("[AutoEnable.Run] Could not find self.");
                    return;
                }

                self.isEnabled = true;
                AuditTrail.Add("[AutoEnable.Run] AutoRepair mod has self-enabled.");
            } catch (Exception e) {
                Log.Error($"ERROR [AutoEnable.Run] {e.Message}");
            }
        }
    }
}
