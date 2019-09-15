namespace AutoRepair.Catalog {
    using Structs;
    using Util;

    /// <summary>
    /// Fake workshop id used to denote vanilla game feature.
    /// Can be used in <see cref="ItemDetails.Replacements"/> and <see cref="ItemDetails.CompatibleWith"/>.
    ///
    /// Do not ever use <c>0</c> for the <c>ulong</c>, as it is default <c>ulong</c> value and we don't want
    /// weird errors happening in future.
    /// </summary>
    public static class Vanilla {
        public static ulong BaseGame = 1u;
        public static ulong UnlockAll = 2u;
        public static ulong UnlimitedMoney = 3u;
        public static ulong UnlimitedSoil = 4u;
        public static ulong UnlimitedOilOre = 5u;
        public static ulong HardMode = 6u;
    }

    public static class Catalog {

        public static Categories Category => Categories.Instance;

        public static Mods Mod => Mods.Instance;

        public static Musics Music => Musics.Instance;

        // public static Assets Asset => Assets.Instance;

        public static void Close() {
            Log.Info("[Catalog.close] Closing catalogs.");
            Categories.instance = null;
            Mods.instance = null;
            Musics.instance = null;
            //Assets.instance = null;
        }

    }
}
