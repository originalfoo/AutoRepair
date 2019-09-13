namespace AutoRepair.Enums {
    using System;
    using System.ComponentModel;

    [Flags]
    public enum ModFlags {
        // Unmaintained and very badly broken
        [Description("Game-breaking")]
        GameBreaking,

        // Can sometimes break saves (but some users don't have problems)
        [Description("Some users report bugs")]
        Unreliable,

        // No sign of activity from the author
        [Description("No longer maintained")]
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

        // Long-term broken mod, doesn't work
        // Note: Not the same as BrokenByUpdate
        [Description("Long-term broken, unsubscribe")]
        LongBroken,

        // confirmed working after game update
        // see list in ModInfo struct
        [Description("Confirmed as working")]
        Verified,

        // Mod will break without required items
        // See list in ModInfo struct
        [Description("Breaks if required items missing")]
        RequiredItems,

        // Mod alters save in such a way that the save won't load if mod not enabled
        // For example, More Vehicles, 81 Tiles
        [Description("Save games created with this will not load without it")]
        ChangesSavegame,

        // Conflcits badly with some other mods
        // See list in ModInfo struct
        [Description("Conflicts with other mods")]
        Conflicts,

        // Removed from workshop by author or admin
        [Description("Has been removed from workshop")]
        NoWorkshop,

        // Force migration to replacement mod(s)
        // Example use: Temp fix uploaded to workshop, original then fixed,
        // so force migration to move people back to original
        // Note: GameBreaking has same effect, but for different reason
        [Description("Mandatory migration required")]
        ForceMigration,
    }
}
