namespace AutoRepair.Enums {
    using System;
    using System.ComponentModel;

    [Flags]
    public enum ModFlags {
        // Unmaintained and very badly broken
        // Will always be unsubscribed
        [Description("Game-breaking")]
        GameBreaking,

        // Force migration to replacement mod(s)
        // Example use: Temp fix uploaded to workshop, original then fixed,
        // so force migration to move people back to original
        // Note: GameBreaking has same effect, but for different reason
        [Description("Mandatory migration required")]
        ForceMigration,

        // currently broken by game update (awaiting fix)
        [Description("Broken by recent game update")]
        BrokenByUpdate,

        // Long-term broken mod, doesn't work
        // Note: Not the same as BrokenByUpdate
        [Description("Long-term broken, unsubscribe")]
        LongBroken,

        // Bugs that don't break saves
        // See Warnings in ModInfo struct
        [Description("Some minor bugs")]
        MinorBugs,

        // Can sometimes break saves (but some users don't have problems)
        [Description("Some users report bugs")]
        Unreliable,

        // No sign of activity from the author
        [Description("No longer maintained")]
        Unmaintained,

        // Eats too much CPU
        [Description("Can cause lag in-game")]
        Laggy,

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

        // confirmed working after game update
        // see list in ModInfo struct
        [Description("Confirmed as working")]
        Verified,
    }
}
