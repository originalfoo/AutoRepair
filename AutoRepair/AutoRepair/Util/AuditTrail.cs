namespace AutoRepair.Util {
    using Manager;
    using Struct;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class is used as an audit trail.
    ///
    /// As the log file is reset each use, I wanted somewhere to keep a persistent audit of all actions
    /// performned by the mod so if something goes horribly wrong I can find out why, even if the log
    /// was since reseet.
    ///
    /// Only used for major actions like add/remove mods.
    /// </summary>
    [OptionsPath("AutoRepair.AuditTrail.xml")] // path: ...\Steam\steamapps\common\Cities_Skylines
    public class AuditTrail {
        /// <summary>
        /// Add items to the list with 
        /// </summary>
        public List<AuditEntry> Entries { get; set; } = new List<AuditEntry> { };

        // End of audit properties.

        /// <summary>
        /// Add an entry to the audit trail.
        /// </summary>
        /// <param name="entry">Text of the entry being added.</param>
        public static void Add(string entry) {
            Instance.Entries.Add(new AuditEntry {
                Timestamp = TimeTools.Now,
                Entry = entry
            });
            Instance.Save();
        }

        private static AuditTrail instance;
        public static AuditTrail Instance => instance ?? (instance = OptionsManager<AuditTrail>.Load());
        public void Save() => OptionsManager<AuditTrail>.Save();
    }
}