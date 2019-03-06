namespace Incompatible.Replacements.Scripts
{
    // note: this is for 25 tiles, for more see 81Tiles.cs
    class PurchaseIt : ReplacementBase
    {
        public PurchaseIt()
        {
            option.Add(1612287735, 1); // Purchase It!
            option.Add(1237383751, 2); // Extended Game Options (See Also: /Conflicts/ExtendedGameOptions.cs)

            note.Add(1, "'Purchase It!' allows you to buy up to 25 tiles in any order -" +
                         " they don't need to be next to each other.");
            note.Add(2, "'Extended Game Options' allows you buy between 1 and 25 tiles," +
                         " but they must be adjacent to each other.");

            deprecated.Add(405904895, 3);  // OpenAllTiles
            deprecated.Add(406187734, 3);  // Corner Tile Unlocker
            deprecated.Add(1270675750, 3); // BigCity (25 tiles mod)
            deprecated.Add(403798635, 3);  // All Spaces Unlockable
            deprecated.Add(413498678, 3);  // All spaces unlockable with right price
            deprecated.Add(1268806334, 3); // UnlockAreaCountLimitAndFree
            deprecated.Add(1265292380, 3); // UnlockAreaCountLimit
            deprecated.Add(405810376, 3);  // All 25 Aras Purchasable
            deprecated.Add(872129984, 3);  // KazExtraAreas
            deprecated.Add(417629854, 3);  // AreaAutoUnlock
            deprecated.Add(412191763, 3);  // DistantAreasMod
            deprecated.Add(406451121, 3);  // UnlockFreeArea

            obsolete.Add(1138679561, 3); // * All Spaces Unlock
            obsolete.Add(616078328, 3);  // * All tile start
            obsolete.Add(425057208, 3);  // * Area Enabler
            obsolete.Add(477574890, 3);  // * UnlockAreaCountLimit
            obsolete.Add(477615230, 3);  // * UnlockAreaCountLimit
            obsolete.Add(709765899, 3);  // * UnlockAreaCountLimit
            obsolete.Add(477574991, 3);  // * UnlockAreaCountLimitAndFree
            obsolete.Add(477615068, 3);  // * UnlockAreaCountLimitAndFree
        }
    }
}
