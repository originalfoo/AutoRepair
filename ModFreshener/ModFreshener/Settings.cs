namespace ModFreshener
{
     /*
     * A library of methods for obtaining settings from, and applying settings to, other mods
    */ 

    class Settings
    {
        // Mod Name: Remove decoration sprites (grass and rocks)
        public static void From547533304(out bool fertility, out bool grass, out bool rocks)
        {
            // todo: pull settings from mod
            fertility = grass = rocks = true;
        }

        // Mod Name: Remove dirt (trees and props)
        public static void From548149310(out bool trees, out bool props)
        {
            // todo: pull settings from mod
            trees = props = true;
        }

        // Mod Name: No radioactive desert and more!
        public static void From666425898(
            out bool colorShoreline,
            out bool colorPollutionGrass,
            out bool colorResourceFertility,
            out bool colorResourceOre,
            out bool colorResourceOil,
            out bool colorResourceForest,
            out bool effectPollution,
            out bool effectShore,
            out bool effectBurnt
        )
        {
            // todo: pull settings from mod
            colorShoreline = effectShore = true;
            colorPollutionGrass = effectPollution = true;
            colorResourceFertility = true;
            colorResourceOre = true;
            colorResourceOil = true;
            colorResourceForest = true;
            effectBurnt = true;
        }

        // Mod Name: Remove street arrows
        public static void From956707300(out bool roadArrows, out bool tramArrows, out bool bikeArrows)
        {
            // todo: pull settings from mod
            roadArrows = tramArrows = bikeArrows = true;
        }

    }
}
