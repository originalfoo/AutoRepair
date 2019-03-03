using ICities;
using System.Reflection;
using ColossalFramework;
using ColossalFramework.UI;
using UnityEngine;
using System.Collections.Generic;
using ColossalFramework.Plugins;
using Incompatible.Broken;

namespace Incompatible
{
    public class Mod : IUserMod
    {
        public static readonly string Version = "0.1";

        public static readonly uint GameVersion = 180609552u;
        public static readonly uint GameVersionA = 1u;
        public static readonly uint GameVersionB = 11u;
        public static readonly uint GameVersionC = 1u;
        public static readonly uint GameVersionBuild = 2u;

        public static readonly string name = "Mod Freshener " + Version;

        public string Name => name;

        public string Description => "Detects incompatible and broken mods and warns you about them";

        public void OnEnabled()
        {
            Debug.Log($"[{name}] Build {Assembly.GetExecutingAssembly().GetName().Version} for game version {GameVersionA}.{GameVersionB}.{GameVersionC}-f{GameVersionBuild}");
            if (UIView.GetAView() != null)
            {
                PerformCompatibilityChecks();
            }
            else
            {
                LoadingManager.instance.m_introLoaded += PerformCompatibilityChecks;
            }
        }

        public void OnDisabled()
        {
            Debug.Log($"[{name}] Disabled.");
            LoadingManager.instance.m_introLoaded -= PerformCompatibilityChecks;
        }

        private static void PerformCompatibilityChecks() // todo
        {
            Debug.Log($"[{name}] Initiating compatibility checks...");

            // if game version changed unexpectedly, show warning

            // disable mods broken due to game patch

            // List of installed broken/obsolete mods

            Dictionary<ulong, PluginManager.PluginInfo> broken = Broken.ModsInstalled();

            // Replacements

            // Dependencies

            // Broken

            // Conflicts
        }
    }
}
