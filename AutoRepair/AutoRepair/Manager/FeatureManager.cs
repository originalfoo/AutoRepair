using ColossalFramework.UI;
using System;
using AutoRepair.Catalogs;
using AutoRepair.Storage;
using AutoRepair.Util;

/// <summary>
/// Triggers applicable features on startup.
/// </summary>
namespace AutoRepair.Features {
    public static class FeatureManager {

        /// <summary>
        /// Performs various startup tasks depending on <see cref="Options"/>.
        /// </summary>
        public static bool Start() {
            Log.Info("[FeatureManager.Prepare] Preparing.");
            try {
                if (UIView.GetAView() == null) {
                    LoadingManager.instance.m_introLoaded += Run;
                } else {
                    Run();
                }
            }
            catch (Exception e) {
                Log.Error($"ERROR [FeatureManager.Prepare] {e.Message}");
            }
            return false;
        }

        private static void Run() {
            Log.Info("[FeatureManager.Run] Running start-up tasks.");
            try {

                if (Options.Instance.AutoRemoveGameBreakers && RemoveGameBreakers.Start()) {
                    return;
                }

                if (VersionTools.IsNewGameVersion && NewGameVersion.Start()) {
                    return;
                }

                if (!Audit.Instance.SubscribedLSM) {

                }

                if (!Audit.Instance.SubscribedSafeNets) {

                }

                if (Options.Instance.OutputModListToGameLog) {
                    OutputModsList.Start();
                }

            }
            catch (Exception e) {
                Log.Error($"ERROR [FeatureManager.Run] {e.Message}");
            }
        }

        public static void Stop() {
            Log.Info("[FeatureManager.Stop] Stopping.");

            LoadingManager.instance.m_introLoaded -= Run;

            Catalog.Stop();
        }

        /*


        // todo: move following stuff elsewhere


        /// <summary>
        /// 1. Gets list of subscribed game-breaking mods
        /// 2. Automatically unsubscribes them
        /// 3. Prompts user to exit to desktop and reload game
        /// </summary>
        public static void RemoveGameBreakers() {

        }

        /// <summary>
        /// 1. If no LSM is subscribed, the live version will be subscribed.
        /// 2. If subscribed LSM is not enabled, it will be enabled.
        /// </summary>
        public static void SubscribeAndEnableLSM() {

        }

        */
    }
}
