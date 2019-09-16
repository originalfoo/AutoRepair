using AutoRepair.Enums;
using ColossalFramework.PlatformServices;

namespace AutoRepair.Structs {
    public struct ItemDetails {
        // Type of item
        public ItemTypes ItemType;

        // Workshop ID of the mod (even if no longer in workshop)
        public ulong WorkshopId; // default 0

        // Name of the item as it appears in workshop (UGCDetails.title)
        public string WorkshopName;

        // Name of the item as it apperas in Content Manager (eg. IUserMod.Name for mods)
        public string IUserModName;

        // Name of the mod (it's main dll) as it appears when querying PluginInfo.name
        // Not applicable to assets.
        public string PluginInfoName;

        public ulong creatorID;

        public float score;

        public int upVotes;

        public int downVotes;

        public uint timeCreated;

        public uint timeUpdated;

        //public uint timeAddedToUserList; // not sure if wanted

        public int fileSize;

        public int previewFileSize;

        public string tags;
        public bool tagsTruncated; // nuke last partial tag

        //public Texture2D image; // these need storing in a cach folder on disk, not in the xml

        public string imageURL;


        // A summary of the mod
        public ItemFlags Flags; // default: 0

        // Any notable warnings that user should be aware of
        // (only list things that aren't covered by other fields in the struct)
        public string[] Notes;

        // Which game version is this mod known to be compatible with
        public string[] GameVersion;

        // Workshop id's of required items
        // (only list stuff that causes mod to break if not found)
        public ulong[] RequiredItems;

        // If more than one required item, is it a choice or should
        // they all be used?
        public bool NeedAllRequired; // default: false

        // Conflict Categories
        // An item can be in zero or more categories.
        // All items in a category will be considered conflicting, unless explicity stated as compatible.
        // All Verified items in a category will be considered potenital replacements.
        public string[] Categories;

        // Denotes mod is compatible with another, despite conflict categorisation
        public ulong[] CompatibleWith;
    }
}
