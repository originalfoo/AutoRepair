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
        [ConfigurableOption("On Startup", "Automatically remove game breaking mods")]
        public bool AutoRemoveGameBreakers { get; set; } = true;

        /// <summary>
        /// Output mods list to game log file? (output_log.txt / Player.log)
        /// 
        /// The list will always output to the Mod Freshener <see cref="Log"/>.
        /// </summary>
        [ConfigurableOption("On Startup", "Add a list of mods to the main game log file")]
        public bool OutputModListToGameLog { get; set; } = true;

        public string Language { get; set; } = "default";

        /// <summary>
        /// Determines what happens to mods listed in <see cref="GameUpdateMods"/>
        /// </summary>
        public GameUpdateMode GameUpdateStrategy { get; set; } = GameUpdateMode.DisableBroken;
    }
}