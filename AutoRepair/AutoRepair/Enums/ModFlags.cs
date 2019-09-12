namespace AutoRepair.Enums {
    using System;
    using System.ComponentModel;

    [Flags]
    public enum ModFlags {
        // Unmaintained and very badly broken
        [Description("Game-breaking")]
        GameBreaking,

        // Can sometimes break saves (but some users don't have problems)
        [Description("Occasional problems")]
        Unreliable,

        // No sign of activity from the author
        [Description("No longer maintained by author")]
        Unmaintained,

        // Bugs that don't break saves
        // See Warnings in ModInfo struct
        [Description("Some minor bugs")]
        MinorBugs,

        // Eats too much CPU
        [Description("Can cause lag in-game")]
        Laggy,

        // currently broken by game update (awaiting fix)
        [Description("Broken by recent game update")]
        BrokenByUpdate,

        // confirmed working after game update
        [Description("Confirmed as working")]
        Verified,

        // Mod will break without required items
        // See list in ModInfo struct
        [Description("Breaks if required items missing")]
        RequiredItems,

        // Conflcits badly with some other mods
        // See list in ModInfo struct
        [Description("Conflicts with other mods")]
        Conflicts
    }
}
