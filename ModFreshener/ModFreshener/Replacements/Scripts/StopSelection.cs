namespace ModFreshener.Replacements.Scripts
{
    class StopSelection : ReplacementBase
    {
        public StopSelection()
        {
            mandatory = true;

            option.Add(1394468624, 1); // Advanced Stop Selection by BloodyPenguin

            note.Add(1, "Replaces outdated 'multitrack station enabler' mods.");

            obsolete.Add(532863263, 1); // * Multi-track Station Enabler
            obsolete.Add(442957897, 1); // * Multi-track Station Enabler
        }
    }
}
