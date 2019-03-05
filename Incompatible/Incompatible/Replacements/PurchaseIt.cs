using System.Collections.Generic;

namespace Incompatible.Replacements
{
    // note: this is for 25 tiles, for more see 81Tiles.cs
    class PurchaseIt : ReplacementBase, IReplacement
    {
        public override Selection Mode => Selection.OnlyOne;

        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1612287735, 1 }, // Purchase It!
            { 1237383751, 2 }, // Extended Game Options
        };

        // See Also: /Conflicts/ExtendedGameOptions.cs 

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "'Purchase It!' allows you to buy up to 25 tiles in any order -" +
                 " they don't need to be next to each other." },
            { 2, "'Extended Game Options' allows you buy between 1 and 25 tiles," +
                 " but they must be adjacent to each other."}
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 616078328, 3 },  // * All tile start
            { 405904895, 3 },  // OpenAllTiles
            { 406187734, 3 },  // Corner Tile Unlocker
            { 1270675750, 3 }, // BigCity (25 tiles mod)
            { 425057208, 3 },  // * Area Enabler
            { 403798635, 3 },  // All Spaces Unlockable
            { 413498678, 3 },  // All spaces unlockable with right price
            { 1268806334, 3 }, // UnlockAreaCountLimitAndFree
            { 477574991, 3 },  // * UnlockAreaCountLimitAndFree
            { 477615068, 3 },  // * UnlockAreaCountLimitAndFree
            { 477615230, 3 },  // * UnlockAreaCountLimit
            { 709765899, 3 },  // * UnlockAreaCountLimit
            { 1265292380, 3 }, // UnlockAreaCountLimit
            { 477574890, 3 },  // * UnlockAreaCountLimit
            { 405810376, 3 },  // All 25 Aras Purchasable
            { 872129984, 3 },  // KazExtraAreas
            { 417629854, 3 },  // AreaAutoUnlock
            { 412191763, 3 },  // DistantAreasMod
            { 406451121, 3 },  // UnlockFreeArea
            { 1138679561, 3 }, // * All Spaces Unlock
        };
    }
}
