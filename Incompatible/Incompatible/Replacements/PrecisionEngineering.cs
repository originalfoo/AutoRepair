namespace Incompatible.Replacements
{
    public static class PrecisionEngineering
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1548831935 // Precision Engineering by Simie
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Precision Engineering replaces the obsolete Road Protactor mod."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            436253779, // * Road protractor
        };
    }
}
