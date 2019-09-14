using ColossalFramework.UI;

namespace AutoRepair.Features {

    public class OnStartup {

        /// <summary>
        /// Performs various startup tasks depending on <see cref="Options"/>.
        /// </summary>
        public static void Prepare() {

            if (UIView.GetAView() != null) {
                Run();
            } else {
                LoadingManager.instance.m_introLoaded += Run;
            }

        }

        public static void Run() {
            Catalog _ = Catalog.Instance;
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
