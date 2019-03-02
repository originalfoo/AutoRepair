namespace Incompatible.Replacements
{
    public static class Landscaping
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            502750307 // Extra Landscaping Tools by BloodyPenguin
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Adds terraforming, natural resource, water and tree painter to the game."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            411095553, // Terraform tool 0.9
            406723376, // Tree Brush
            423964385, // * TreeBrush
        };

        // called each time an old mod is replaced by upgrades
        static public void OnReplace(ulong workshopid)
        {
            // could enable/disable features based on which mods it replaces?
        }

        // called once all replacements are complete
        static public void OnDone()
        {
            // enable mods?
        }
    }
}
