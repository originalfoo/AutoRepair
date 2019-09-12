namespace AutoRepair.Struct {
    using AutoRepair.Enums;
    public struct ModInfo {
        // Workshop ID of the mod (even if no longer in workshop)
        public readonly ulong WorkshopId;

        // A summary of the mod
        public readonly ModFlags ModFlags;

        // Name of the mod (useful if not subscribed or no longer in workshop)
        public readonly string ModName;

        // Any notable warnings that user should be aware of
        // (only list things that aren't covered by other fields in the struct)
        public readonly string[] Warnings;

        // Which game version is this mod known to be compatible with
        public readonly string GameVersion;

        // Workshop id's of required items
        // (only list stuff that causes mod to break if not found)
        public readonly ulong[] RequiredItems;

        // Workshop id's of stuff it conflicts with
        public readonly ulong[] Conflicts;

        // Workshop id's of suitable modern replacements
        public readonly ulong[] Replacements;
    }
}
