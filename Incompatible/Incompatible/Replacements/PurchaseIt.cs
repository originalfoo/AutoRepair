namespace Incompatible.Replacements
{
    // note: this is for 25 tiles, for more see 81Tiles.cs
    public static class PurchaseIt
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1612287735 // Purchase It! by Keallu
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Purchase all 25 tiles - options to ignore milestones, set fixed or free price, and you can purchase tiles in any order."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            616078328,  // * All tile start
            405904895,  // OpenAllTiles
            406187734,  // Corner Tile Unlocker
            1270675750, // BigCity (25 tiles mod)
            425057208,  // * Area Enabler
            403798635,  // All Spaces Unlockable
            413498678,  // All spaces unlockable with right price
            1268806334, // UnlockAreaCountLimitAndFree
            477574991,  // * UnlockAreaCountLimitAndFree
            477615068,  // * UnlockAreaCountLimitAndFree
            477615230,  // * UnlockAreaCountLimit
            709765899,  // * UnlockAreaCountLimit
            1265292380, // UnlockAreaCountLimit
            477574890,  // * UnlockAreaCountLimit
            405810376,  // All 25 Aras Purchasable
            872129984,  // KazExtraAreas
            417629854,  // AreaAutoUnlock
            412191763,  // DistantAreasMod
            406451121,  // UnlockFreeArea
        };
    }
}
