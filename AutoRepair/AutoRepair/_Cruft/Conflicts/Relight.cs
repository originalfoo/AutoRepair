namespace AutoRepair.Conflicts
{
    // If Relight mod is active:
    // * Disable 'Softer Shadows' mod
    // * Change settings in 'Daylight Classic' mod (if it's installed)

    public static class Relight
    {
        // if this mod is installed...
        static readonly ulong mod = 1209581656;

        // ...run this method
        static void Verify(bool enabled)
        {
            if (!enabled)
            {
                return;
            }


            // Disable 'Softer Shadows' mod (643364914)

            // Change settings in 'Daylight Classic' mod (530871278)
            // 1. Disable 'Classic sunlight color' option
            // 2. Disable 'Classic sunlight intensity' option
            // 3. Disable 'Classic fog color for AD' option

            // i have no idea how to do this!
        }
    }
}
