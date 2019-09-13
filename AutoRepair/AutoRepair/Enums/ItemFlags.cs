namespace AutoRepair.Enums {
    using System;
    using System.ComponentModel;

    [Flags]
    public enum ItemFlags {

        // no applicable flags
        None = 0,

        // Unmaintained and very badly broken
        // Will always be unsubscribed
        [Description("Game-breaking")]
        GameBreaking,

        // Force migration to replacement mod(s)
        // Example use: Temp fix uploaded to workshop, original then fixed,
        // so force migration to move people back to original
        [Description("Mandatory migration required")]
        ForceMigration,

        // Long-term broken mod, doesn't work
        // Note: Not the same as BrokenByUpdate
        [Description("Long-term broken, unsubscribe")]
        LongBroken,

        // Bugs that don't break saves
        // See Warnings in ModInfo struct
        [Description("Some minor bugs")]
        MinorBugs,

        // Currently broken by game update (awaiting fix)
        [Description("Broken by recent game update")]
        BrokenByUpdate,

        // Confirmed working after game update
        // see GameVersion in ModInfo struct
        [Description("Confirmed as working")]
        Verified,

        // Can sometimes break saves (but some users don't have problems)
        // See Warnings in ModInfo struct
        [Description("Some users report bugs")]
        Unreliable,

        // No sign of activity from the author
        [Description("No longer maintained")]
        Unmaintained,

        // Eats too much CPU
        // See Warnings in ModInfo struct
        [Description("Can cause lag in-game")]
        Laggy,

        // Mod alters save in such a way that the save won't load if mod not enabled
        // For example, More Vehicles, 81 Tiles
        // See Warnings in ModInfo struct
        [Description("Save games created with this will not load without it")]
        ChangesSavegame,

        // Removed from workshop by author or admin
        [Description("Has been removed from workshop")]
        NoWorkshop,

        // The mod is not in our reference dictionary
        [Description("Auto-repair does not recognise this")]
        Unrecognised,
    }
}
