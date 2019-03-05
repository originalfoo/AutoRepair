using ICities;
using System.Reflection;
using ColossalFramework.UI;
using UnityEngine;
using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace Incompatible
{
    public class Mod : IUserMod
    {
        // Mod version
        public static readonly string Version = "0.1";
        public static readonly string name = "Mod Freshener " + Version;

        // Required by C:SL
        public string Name => name;
        public string Description => "Detects incompatible and broken mods and warns you about them";

        // expected game version
        public static readonly uint GameVersionA = 1u;
        public static readonly uint GameVersionB = 11u;

        public void OnEnabled()
        {
            Debug.Log($"[{name}] Build {Assembly.GetExecutingAssembly().GetName().Version} for Cities:Skylines {GameVersionA}.{GameVersionB}");
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

        public static void PerformCompatibilityChecks()
        {
            Helper.DumpModListToLog();

            Debug.Log($"[{name}] Initiating compatibility checks...");

            if (UnexpectedGameVersion())
            {
                Debug.Log($"[{name}] GAME UPDATE DETECTED - MAY CAUSE ISSUES WITH MODS");

                // if game version changed unexpectedly, show warning

                // disable mods broken due to game patch
            }

            // List of installed broken/obsolete mods

            Dictionary<ulong, PluginManager.PluginInfo> broken = Broken.ModsInstalled();

            // Replacements

            // Dependencies

            // Broken

            // Conflicts
        }

        public static bool UnexpectedGameVersion()
        {
            Debug.Log($"[{name}] Detected game version: {BuildConfig.applicationVersionFull}");
            return (GameVersionB != BuildConfig.APPLICATION_VERSION_B && GameVersionA != BuildConfig.APPLICATION_VERSION_A);
        }
    }
}
