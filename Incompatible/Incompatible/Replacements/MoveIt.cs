namespace Incompatible.Replacements
{
    public static class MoveIt
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1619685021 // Move It! by Quboid
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Powerful and reliable tool to move and align networks, props and more."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            658653260,  // * Network nodes editor
            1434173135, // * Move It (Chinese version)
            1120637951, // * Move It Extra Filters
            1622545887, // * Move It (Legacy Edition)
        };
    }
}
