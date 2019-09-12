namespace AutoRepair.Replacements.Scripts
{
    class EmptyIt : ReplacementBase
    {
        public EmptyIt()
        {
            option.Add(1661072176, 1); // Empty It! by Keallu
 
            note.Add(1, "'Empty It!' lets you configure landfills, graveyards and snow dumps to start auto-emptying before they become full.");

            deprecated.Add(1182722930, 1); // Automatic Empty

            obsolete.Add(896806060, 1); // Automatic Emptying
            obsolete.Add(407873631, 1); // Automatic Emptying
            obsolete.Add(686588890, 1); // * Automatic Emptying Extended
        }
    }
}
