namespace Incompatible.Replacements
{
    public static class ShowIt
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1556715327 // Show It! by Keallu
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Reliable, accurate and fast vital indicators for zoned buildings."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            1133108993, // * Extended Building Information (1.10+)
            767809751,  // * Extended Building Information (Chinese)
            414469593,  // * Extended Building Information
            670422128,  // * Extended Building Information
            928988785,  // * Extended Building Information
        };
    }
}
