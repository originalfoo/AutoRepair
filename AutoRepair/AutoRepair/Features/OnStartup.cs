namespace AutoRepair.Features {
    using ColossalFramework.UI;
    using System;
    using Catalog;
    using Util;

    public class OnStartup {

        /// <summary>
        /// Performs various startup tasks depending on <see cref="Options"/>.
        /// </summary>
        public static void Prepare() {
            Log.Info("[OnStartup.Prepare] Preparing.");
            try {
                if (UIView.GetAView() != null) {
                    Run();
                } else {
                    LoadingManager.instance.m_introLoaded += Run;
                }
            }
            catch (Exception e) {
                Log.Error($"ERROR [OnStartup.Prepare] {e.Message}");
            }
        }

        public static void Run() {
            Log.Info("[OnStartup.Run] Running start-up tasks.");
            try {
                Catalog cat = Catalog.Instance;
            }
            catch (Exception e) {
                Log.Error($"ERROR [OnStartup.Run] {e.Message}");
            }
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
