using AutoRepair.Storage;
using AutoRepair.Structs;
using System.Reflection;

namespace AutoRepair.Storage {
    public class VersionTools {

        internal static string ModNameStub => $"{Assembly.GetExecutingAssembly().GetName().Name}";

        public static string ModVersion => $"{Assembly.GetExecutingAssembly().GetName().Version.Major}.{Assembly.GetExecutingAssembly().GetName().Version.Minor}";

        public static string ModName => $"{ModNameStub} {ModVersion}";

        /// <summary>
        /// The current (actual) game version.
        /// </summary>
        public static GameVersion CurrentGameVersion => new GameVersion {
            Major = BuildConfig.APPLICATION_VERSION_A,
            Minor = BuildConfig.APPLICATION_VERSION_B
        };

        /// <summary>
        ///  Will be <c>true</c> if the actual game version is different to stored previous game version.
        /// </summary>
        public static bool IsNewGameVersion => !CurrentGameVersion.Equals(Archive.Instance.PreviousGameVersion);
    }
}
