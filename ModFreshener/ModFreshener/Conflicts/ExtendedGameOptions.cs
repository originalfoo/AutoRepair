namespace ModFreshener.Conflicts
{
    // If Relight mod is active:
    // * Disable 'Softer Shadows' mod
    // * Change settings in 'Daylight Classic' mod (if it's installed)

    public static class ExtendedGameOptions
    {
        // if this mod is installed...
        static readonly ulong mod = 1237383751; // extended game options

        // ...run this method
        static void Verify(bool enabled)
        {
            // make sure vanilla 'infinite oil and ore' mod is not enabled
            // because it breaks the depletion setting in extended game options

            // disable the vanilla 'unlock all' mod

            // make sure 'Purchase It' (1612287735) is disabled as it conflicts with
            // the tile purchase options

            // make sure '81 tiles' is disabled for same reason
        }
    }
}
