using ColossalFramework;
using ColossalFramework.UI;
using ColossalFramework.Plugins;
using static ColossalFramework.Plugins.PluginManager;
using System;
using System.Linq;
using AutoRepair.Manager;
using AutoRepair.Storage;
using AutoRepair.Util;

/// <summary>
/// Note: This feature is special case not managed by FeatureManager.
///
/// Old versions of "Improved Mods Panel" mod break the mods panel, preventing users
/// from enabling/disabling mods, etc. So we auto-enable the AutoRepair mod to avoid
/// that pain.
/// </summary>

namespace AutoRepair.Features {
    public static class AutoEnable {

        /// <summary>
        /// Called from <c>Mod.ctor</c>, only when the mod is first subscribed.
        ///
        /// 1. Prevent further calls by setting SelfEnableOnStartup = false
        /// 2. Determine when <c>SelfEnable()</c> is safe to call.
        /// </summary>
        public static void Start() {
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
        private static void Run() {
            Log.Info($"[AutoEnable.Run] Ensuring mod is enabled.");
            try {
                PluginInfo self = Singleton<PluginManager>.instance.GetPluginsInfo()
                    .Where(plugin => SubscriptionsManager.GetModName(plugin) == VersionTools.ModName)
                    .FirstOrDefault();

                if (self == null) {
                    Log.Info("WARNING [AutoEnable.Run] Could not find self.");
                    return;
                }

                if (!self.isEnabled) {
                    self.isEnabled = true;
                    Audit.Add("[AutoEnable.Run] AutoRepair mod has self-enabled.");
                }
            } catch (Exception e) {
                Log.Error($"ERROR [AutoEnable.Run] {e.Message}");
            }
            Stop();
        }

        public static void Stop() {
            Log.Info("[AutoEnable.Stop] Clearing events.");
            LoadingManager.instance.m_introLoaded -= Run;
        }
    }
}
