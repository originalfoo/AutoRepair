using ICities;
using UnityEngine;
using AutoRepair.Features;
using AutoRepair.Storage;
using AutoRepair.Util;
using JetBrains.Annotations;

namespace AutoRepair {
    public class Mod : IUserMod {
        /// <summary>
        /// If <c>true</c>, all features disabled.
        /// </summary>
        public static readonly bool EmergencyStop = false;

        [UsedImplicitly]
        public string Name => VersionTools.ModName;

        [UsedImplicitly]
        public string Description => EmergencyStop
            ? "Temporarily suspended while we fix some bugs."
            : "Helps you repair Cities: Skylines.";

        [UsedImplicitly]
        static Mod() {
            if (!EmergencyStop && !Audit.Instance.AutoEnabled) {
                Audit.Instance.AutoEnabled = true;
                Audit.Instance.Save();
                AutoEnable.Start();
            }
        }

        [UsedImplicitly]
        public void OnEnabled() {
            if (!EmergencyStop) {
                Log.Info($"[{VersionTools.ModName}] Enabled. Game version: {VersionTools.CurrentGameVersion}", true);
                FeatureManager.Start();
            }
        }

        [UsedImplicitly]
        public void OnDisabled() {
            if (!EmergencyStop) {
                Debug.Log($"[{VersionTools.ModName}] Disabled.");
                FeatureManager.Stop();
            }
        }
    }
}
