using System.Collections.Generic;

namespace Incompatible.Replacements
{
    // note: this is for 25 tiles, for more see 81Tiles.cs
    class PurchaseIt : ReplacementBase, IReplacement
    {
        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1612287735, 1 } // Purchase It! by Keallu
        };

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Purchase all 25 tiles - options to ignore milestones, set fixed or free price, and you can purchase tiles in any order." }
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 616078328, 1 },  // * All tile start
            { 405904895, 1 },  // OpenAllTiles
            { 406187734, 1 },  // Corner Tile Unlocker
            { 1270675750, 1 }, // BigCity (25 tiles mod)
            { 425057208, 1 },  // * Area Enabler
            { 403798635, 1 },  // All Spaces Unlockable
            { 413498678, 1 },  // All spaces unlockable with right price
            { 1268806334, 1 }, // UnlockAreaCountLimitAndFree
            { 477574991, 1 },  // * UnlockAreaCountLimitAndFree
            { 477615068, 1 },  // * UnlockAreaCountLimitAndFree
            { 477615230, 1 },  // * UnlockAreaCountLimit
            { 709765899, 1 },  // * UnlockAreaCountLimit
            { 1265292380, 1 }, // UnlockAreaCountLimit
            { 477574890, 1 },  // * UnlockAreaCountLimit
            { 405810376, 1 },  // All 25 Aras Purchasable
            { 872129984, 1 },  // KazExtraAreas
            { 417629854, 1 },  // AreaAutoUnlock
            { 412191763, 1 },  // DistantAreasMod
            { 406451121, 1 },  // UnlockFreeArea
        };
    }
}
