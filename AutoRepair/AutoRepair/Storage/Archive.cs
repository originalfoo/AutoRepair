using AutoRepair.Manager;
using AutoRepair.Structs;
using System.Collections.Generic;

namespace AutoRepair.Storage {
    /// <summary>
    ///
    /// </summary>
    [StoragePath("AutoRepair.Archive.xml")] // path: ...\Steam\steamapps\common\Cities_Skylines
    public class Archive {
        private static Archive instance;
        public static Archive Instance => instance ?? (instance = StorageManager<Archive>.Load());
        public void Save() => StorageManager<Archive>.Save();

        // Stored properties:

        /// <summary>
        /// List of all removed game-breaking mods which have not yet been post-processed.
        /// </summary>
        public List<ArchiveEntry> RemovedGameBreakers { get; set; } = new List<ArchiveEntry> { };

        /// <summary>
        /// The game version previously seen by the mod. If actual version differs from this, it
        /// triggers the game update features which are controlled by <see cref="GameUpdateStrategy"/>.
        ///
        /// Don't update this for several weeks after a game update.
        /// </summary>
        public GameVersion PreviousGameVersion { get; set; } = new GameVersion { Major = 1, Minor = 12 };

        /// <summary>
        /// List of all subscribed mods at point when a game version change was detected.
        /// </summary>
        public List<ArchiveEntry> DisabledOnGameUpdate { get; set; } = new List<ArchiveEntry> { };
    }
}