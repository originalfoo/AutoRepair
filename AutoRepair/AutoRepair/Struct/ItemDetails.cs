namespace AutoRepair.Struct {
    using AutoRepair.Enums;
    using System.Collections.Generic;

    public struct ItemDetails {
        // Workshop ID of the mod (even if no longer in workshop)
        public ulong WorkshopId; // default 0

        // A summary of the mod
        public ItemFlags Flags; // default: 0

        // Name of the mod (useful if not subscribed or no longer in workshop)
        public string Name;

        // Any notable warnings that user should be aware of
        // (only list things that aren't covered by other fields in the struct)
        public List<string> Warnings;

        // Which game version is this mod known to be compatible with
        public List<string> GameVersion;

        // Workshop id's of required items
        // (only list stuff that causes mod to break if not found)
        public List<ulong> RequiredItems;

        // If more than one required item, is it a choice or should
        // they all be used?
        public bool NeedAllRequired; // default: false

        // Workshop id's of stuff it conflicts with
        public List<ulong> Conflicts;

        // Workshop id's of suitable modern replacements
        public List<ulong> Replacements;

        // If more than one replacement, is it a choice or should
        // they all be used?
        public ReplacementMode ReplaceMode;
    }
}
