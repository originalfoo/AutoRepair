namespace AutoRepair {
    using ICities;
    using UnityEngine;
    using Features;
    using Util;
    using JetBrains.Annotations;

    public class Mod : IUserMod {
        /// <summary>
        /// If <c>true</c>, all features disabled.
        /// </summary>
        public static readonly bool EmergencyStop = false;

        [UsedImplicitly]
        public string Name => VersionTools.ModName;

        [UsedImplicitly]
        public string Description => EmergencyStop
            ? "Temporarily deactivated while we fix some bugs."
            : "Helps you repair Cities: Skylines.";

        [UsedImplicitly]
        static Mod() {
            if (!EmergencyStop && Options.Instance.AutoEnableOnFirstUse) {
                Options.Instance.AutoEnableOnFirstUse = false;
                Options.Instance.Save();
                AutoEnable.Prepare();
            }
        }

        [UsedImplicitly]
        public void OnEnabled() {
            if (!EmergencyStop) {
                Log.Info($"[{VersionTools.ModName}] Enabled.", true);
                OnStartup.Prepare();
            }
        }

        [UsedImplicitly]
        public void OnDisabled() {
            if (!EmergencyStop) {
                Debug.Log($"[{VersionTools.ModName}] Disabled.");
                Catalog.Catalog.Close();
                ClearLoadingEvents();
            }
        }

        public void ClearLoadingEvents() {
            LoadingManager.instance.m_introLoaded -= AutoEnable.Run;
            LoadingManager.instance.m_introLoaded -= OnStartup.Run;
        }

    }
}
