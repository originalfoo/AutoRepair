namespace AutoRepair.Manager {
    using AutoRepair.Util;
    class FeatureManager {

        /// <summary>
        /// 1. Finds Mod Freshener mod
        /// 2. Enables it
        ///
        /// Notes:
        /// 
        /// * The mod option that triggers this (<see cref="Options.SelfEnableOnStartup"/>) is automatically disabled after first use.
        /// * That option will be re-enabled should the user unsubscribe the mod via Content Manager.
        /// </summary>
        public static void SelfEnable() {

        }

        /// <summary>
        /// Performs various startup tasks on <see cref="Options"/>.
        /// </summary>
        public static void OnStartup() {

        }

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


    }
}
