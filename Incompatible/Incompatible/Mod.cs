using ICities;
using System.Reflection;
using ColossalFramework;
using ColossalFramework.UI;
using UnityEngine;

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

        public string Name => "Incompatibility Checker " + Version;

        public string Description => "Detects incompatible and broken mods and warns you about them";

        public void OnEnabled()
        {
            Debug.Log($"[{Name}] Build {Assembly.GetExecutingAssembly().GetName().Version} for game version {GameVersionA}.{GameVersionB}.{GameVersionC}-f{GameVersionBuild}");
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
            Debug.Log($"[{Name}] disabled.");
            LoadingManager.instance.m_introLoaded -= PerformCompatibilityChecks;
        }

        private static void PerformCompatibilityChecks() // todo
        {
            // if game version changed unexpectedly, show warning

            // disable mods broken due to game patch

            // suggest replacements for broken/obsolete mods

            // check for any missing mod depdencies

            // deal with any remaining broken/obsolete mods
        }
    }
}
