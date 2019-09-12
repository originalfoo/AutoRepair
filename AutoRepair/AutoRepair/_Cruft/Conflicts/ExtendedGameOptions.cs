using System.Collections.Generic;
using static ColossalFramework.Plugins.PluginManager;

namespace AutoRepair.Conflicts
{
    class ExtendedGameOptions
    {
        // if this mod is installed...
        public ulong mod = 1237383751u; // extended game options

        private readonly HashSet<ulong> tileMods = new HashSet<ulong>()
        {
            1612287735u, // Purchase It!
            576327847u,  // 81 Tiles

            405904895u,  // OpenAllTiles
            406187734u,  // Corner Tile Unlocker
            1270675750u, // BigCity (25 tiles mod)
            403798635u,  // All Spaces Unlockable
            413498678u,  // All spaces unlockable with right price
            1268806334u, // UnlockAreaCountLimitAndFree
            1265292380u, // UnlockAreaCountLimit
            405810376u,  // All 25 Aras Purchasable
            872129984u,  // KazExtraAreas
            417629854u,  // AreaAutoUnlock
            412191763u,  // DistantAreasMod
            406451121u,  // UnlockFreeArea

            // broken and obsolete mods not listed
        };

        protected HashSet<ulong> TileMods => tileMods;

        // ...run this method
        public void Verify(bool enabled)
        {
            // make sure vanilla 'infinite oil and ore' mod is not enabled
            // because it breaks the depletion setting in extended game options
            Helper.SetBundledModState("Infinite Oil and Ore", false);

            // disable the vanilla 'unlock all' mod
            Helper.SetBundledModState("Unlock All", false);

            // if 'Purchase It' or '81 Tiles' mods are active, turn off the tiles
            // feature in 'Extended Game Options'
            if (Helper.AnyInstalled(TileMods))
            {
                // no idea how to do this :(
                // maybe open mod settings screen in hidden panel and prod the UI control?
            }
        }
    }
}
