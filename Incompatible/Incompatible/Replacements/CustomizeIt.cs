namespace Incompatible.Replacements
{
    public static class CustomizeIt
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1369729955 // Customize It! by TPB
        };

        // why do the upgrade?
        static readonly string[] why = {
            "Allows you to customise stats of most ploppable buildings."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            785237088, // * Service Radius Adjuster
        };
    }
}
