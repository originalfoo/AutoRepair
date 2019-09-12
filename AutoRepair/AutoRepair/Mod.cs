namespace AutoRepair {
    using ICities;
    using System.Reflection;
    using ColossalFramework.UI;
    using UnityEngine;
    using AutoRepair.Util;
    using AutoRepair.Manager;
    using JetBrains.Annotations;

    public class Mod : IUserMod {
        /// <summary>
        /// Name and version defined by assembly.
        /// </summary>
        public static readonly string ver = $"{Assembly.GetExecutingAssembly().GetName().Version.Major}.{Assembly.GetExecutingAssembly().GetName().Version.Minor}";
        public static readonly string name = $"{Assembly.GetExecutingAssembly().GetName().Name}";
        public static readonly string nameAndVer = $"{name} {ver}";

        /// <summary>
        /// The game version the mod is designed for.
        /// </summary>
        public static readonly uint GameVersionA = 1u;
        public static readonly uint GameVersionB = 12u;

        [UsedImplicitly]
        public string Name {
            get {
                if (Options.Instance.SelfEnableOnStartup && UIView.GetAView() == null) {
                    LoadingManager.instance.m_introLoaded += FeatureManager.SelfEnable;
                    Options.Instance.SelfEnableOnStartup = false;
                    Options.Instance.Save();
                }
                return nameAndVer;
            }
        }

        [UsedImplicitly]
        public string Description => "Helps you repair Cities: Skylines.";

        [UsedImplicitly]
        public void OnEnabled() {
            Log.Info($"{nameAndVer} enabled.");
            Debug.Log($"{nameAndVer} enabled. See '{Log.LogFileName}' for full report.");

            // Startup tasks
            if (UIView.GetAView() != null) {
                FeatureManager.OnStartup();
            } else {
                LoadingManager.instance.m_introLoaded += FeatureManager.OnStartup;
            }
        }

        [UsedImplicitly]
        public void OnDisabled() {
            Debug.Log($"[{name}] Disabled.");
            LoadingManager.instance.m_introLoaded -= FeatureManager.OnStartup;
            LoadingManager.instance.m_introLoaded -= FeatureManager.SelfEnable;
        }

        //        public static bool UnexpectedGameVersion()
        //        {
        //            Debug.Log($"[{name}] Detected game version: {BuildConfig.applicationVersionFull}");
        //            return (GameVersionB != BuildConfig.APPLICATION_VERSION_B || GameVersionA != BuildConfig.APPLICATION_VERSION_A);
        //        }
    }
}
