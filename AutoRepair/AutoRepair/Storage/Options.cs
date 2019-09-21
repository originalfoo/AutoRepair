using AutoRepair.Attributes;
using AutoRepair.Enums;
using AutoRepair.Manager;
using AutoRepair.Util;

namespace AutoRepair.Storage {
    [StoragePath("AutoRepair.Options.xml")] // path: ...\Steam\steamapps\common\Cities_Skylines
    public class Options {
        private static Options instance;
        public static Options Instance => instance ?? (instance = StorageManager<Options>.Load());
        public void Save() => StorageManager<Options>.Save();

        // Stored properties:

        /// <summary>
        /// Automatically remove game breaking mods?
        ///
        /// If <c>true</c>, <see cref="ItemFlags.GameBreaking"/> mods will be automatically unsubscribed without user intervention.
        /// </summary>
        [ConfigurableOption("Group.OnStartup", "Checkbox.AutoRemoveBreaking")]
        public bool AutoRemoveGameBreakers { get; set; } = true;

        /// <summary>
        /// Output mods list to game log file? (output_log.txt / Player.log)
        /// </summary>
        [ConfigurableOption("Group.OnStartup", "Checkbox.LogModsList")]
        public bool OutputModListToGameLog { get; set; } = true;

        public string Language { get; set; } = "default";

        /// <summary>
        /// 
        /// </summary>
        public GameUpdateMode GameUpdateStrategy { get; set; } = GameUpdateMode.DisableBroken;
    }
}