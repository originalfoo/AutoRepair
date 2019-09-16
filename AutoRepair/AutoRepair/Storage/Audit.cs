using AutoRepair.Attributes;
using AutoRepair.Manager;
using AutoRepair.Structs;
using AutoRepair.Util;
using System.Collections.Generic;

namespace AutoRepair.Storage {
    /// <summary>
    /// This class is used as an audit trail.
    ///
    /// As the log file is reset each use, I wanted somewhere to keep a persistent audit of all actions
    /// performned by the mod so if something goes horribly wrong I can find out why, even if the log
    /// was since reseet.
    ///
    /// Only used for major actions like add/remove mods.
    /// </summary>
    [StoragePath("AutoRepair.Audit.xml")] // path: ...\Steam\steamapps\common\Cities_Skylines
    public class Audit {
        private static Audit instance;
        public static Audit Instance => instance ?? (instance = StorageManager<Audit>.Load());
        public void Save() => StorageManager<Audit>.Save();

        /// <summary>
        /// Add an entry to the audit trail.
        /// </summary>
        /// <param name="entry">Text of the entry being added.</param>
        public static void Add(string entry) {
            Log.Info($"[{VersionTools.ModName}] {entry}", true);
            Instance.Entries.Add(new AuditEntry {
                Timestamp = TimeTools.Now,
                Entry = entry
            });
            Instance.Save();
        }

        // Stored properties:

        /// <summary>
        /// </summary>
        public bool AutoEnabled { get; set; } = false;

        /// <summary>
        /// </summary>
        public bool SubscribedLSM { get; set; } = false;

        /// <summary>
        /// </summary>
        public bool SubscribedSafeNets { get; set; } = false;

        /// <summary>
        /// </summary>
        public List<AuditEntry> Entries { get; set; } = new List<AuditEntry> { };
    }
}