namespace Incompatible.Replacements
{
    public static class TrafficManager
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1637663252 // TM:PE by Krzychu1245
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "This is continuation of TM:PE, with bugfixes and improvements, and replaces several obsolete mods."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            492391912,  // * Improvedd AI (Traffic++)
            409184143,  // * Traffic++
            626024868,  // * Traffic++ V2
            583429740,  // * Traffic Manager: President Edition (LinuxFan)
            1581695572, // * Traffic Manager: President Edition (temp bugfix)
            1348361731, // * Traffic Manager: President Edition ALPHA/DEBUG
            498363759,  // * Traffic Manager + Improved AI
            563720449,  // * Traffic Manager + Improved AI (Japanese Ver.)
            407335588,  // No Despawn Mod
            600733054,  // No On-Street Parking
            1628112268, // * RightTurnNoStop
            411833858,  // Toggle Traffic Lights
            587530437,  // * Remove Stuck Vehicles [Fixed for v1.4 +]
            813834836,  // * Remove Stuck Vehicles [1.6]
        };
    }
}
