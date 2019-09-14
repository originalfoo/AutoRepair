using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoRepair.Util {
    public class VersionTools {

        internal static string ModNameStub => $"{Assembly.GetExecutingAssembly().GetName().Name}";

        public static string ModVersion => $"{Assembly.GetExecutingAssembly().GetName().Version.Major}.{Assembly.GetExecutingAssembly().GetName().Version.Minor}";

        public static string ModName => $"{ModNameStub} {ModVersion}";


        /// <summary>
        /// The game version the mod is expecting to see.
        /// </summary>
        public static readonly uint GameVersionA = 1u;
        public static readonly uint GameVersionB = 12u;

        //        public static bool UnexpectedGameVersion()
        //        {
        //            Debug.Log($"[{name}] Detected game version: {BuildConfig.applicationVersionFull}");
        //            return (GameVersionB != BuildConfig.APPLICATION_VERSION_B || GameVersionA != BuildConfig.APPLICATION_VERSION_A);
        //        }

    }
}
