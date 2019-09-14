namespace AutoRepair {
    using Manager;
    using Util;
    using Enums;
    using Attributes;

    [OptionsPath("AutoRepair.Options.xml")] // path: ...\Steam\steamapps\common\Cities_Skylines
    public class Options {
        /// <summary>
        /// Causes mod to self-enable when first subscribed.
        ///
        /// The option is automatically set to <c>false</c> afterwards.
        /// </summary>
        public bool AutoEnableOnFirstUse { get; set; } = true;

        /// <summary>
        /// LSM greatly reduces RAM consumption (and thus OOM crashes) and has powerful error handling/recovery features.
        ///
        /// The option is automatically set to <c>false</c> after first use.
        /// </summary>
        public bool AutoSubscribeLSM { get; set; } = true;

        /// <summary>
        /// SafeNets fixes a very common game-breaking error caused by missing networks.
        ///
        /// The option is automatically set to <c>false</c> after first use.
        /// </summary>
        public bool AutoSubscribeSafeNets { get; set; } = true;

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

        /// <summary>
        /// When a game update is detected:
        /// * <see cref="PreviousGameVersion"/> is updated
        /// * <see cref="GameUpdateMods"/> is cleared then populated with workshop ids of currently enabled mods
        /// * <see cref="GameUpdateStrategy"/> determines what happens next
        /// </summary>
        public ulong[] GameUpdateMods { get; set; } = { };

        /// <summary>
        /// The game version associated with the mods in <see cref="GameUpdateMods"/>
        /// </summary>
        public string PreviousGameVersion { get; set; } = "";

        /// <summary>
        /// Determines what happens to mods listed in <see cref="GameUpdateMods"/>
        /// </summary>
        //[ConfigurableOption("After Game Updates", "What should we do?")]
        public GameUpdateMode GameUpdateStrategy { get; set; } = GameUpdateMode.DisableBroken;


        // End of options list.

        private static Options instance;
        public static Options Instance => instance ?? (instance = OptionsManager<Options>.Load());
        public void Save() => OptionsManager<Options>.Save();
    }
}