using System;
using System.ComponentModel;

namespace AutoRepair.Enums {
    [Flags]
    public enum ItemFlags {

        // no applicable flags
        None = 0,

        /* Maintenance status flags */

        // Confirmed working after game update
        // see GameVersion in ModInfo struct
        [Description("Confirmed as working")]
        Verified,

        // No sign of activity from the author
        [Description("Item no longer maintained")]
        Unmaintained,

        // Removed from workshop by author or admin
        [Description("Item removed from workshop")]
        NoWorkshop,

        // The mod is not in our reference dictionary
        [Description("Item is not in catalog")]
        Unrecognised,

        /* Reliability status flags */

        // Can sometimes break saves (but some users don't have problems)
        // See Warnings in ModInfo struct
        [Description("Some users report bugs")]
        Unreliable,

        // Currently broken by game update (awaiting fix)
        [Description("Broken by recent game update")]
        BrokenByUpdate,

        // Bugs that don't break saves
        // See Warnings in ModInfo struct
        [Description("Some minor bugs")]
        MinorBugs,

        // Long-term broken mod, doesn't work
        // Note: Not the same as BrokenByUpdate
        [Description("Long-term broken, unsubscribe")]
        LongBroken,

        // Unmaintained and very badly broken
        // Will always force migration (see below)
        [Description("Game-breaking")]
        GameBreaking,

        /* Other status flags */

        // Force migration to replacement mod(s)
        // Example use: Temp fix uploaded to workshop, original then fixed,
        // so force migration to move people back to original
        [Description("Mandatory migration required")]
        ForceMigration,

        // Eats too much CPU
        // See Warnings in ModInfo struct
        [Description("Can cause lag in-game")]
        Laggy,

        // Mod alters save in such a way that the save won't load if mod not enabled
        // For example, More Vehicles, 81 Tiles
        // See Warnings in ModInfo struct
        [Description("Save games created with this will not load without it")]
        ChangesSavegame,

        // Does it break the asset/theme/map editor?
        [Description("Breaks the asset/theme/map editors")]
        BreaksEditors,

        // Just a translation of existing mod, likely unmaintained
        [Description("Translation of an existing mod")]
        Translation,
    }
}
