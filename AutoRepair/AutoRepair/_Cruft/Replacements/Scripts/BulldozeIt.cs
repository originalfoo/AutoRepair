namespace AutoRepair.Replacements.Scripts
{
    class BulldozeIt : ReplacementBase
    {
        public BulldozeIt()
        {
            choice = Select.Any;

            option.Add(1627986403, 1); // Bulldoze It! by Keallu
            option.Add(1656549865, 2); // Rebuild It! by Keallu

            note.Add(1, "'Bulldoze It!' can automatically or manually remove burnt, collapsed, flooded and abandoned buildings, directly from the bulldozer bar.");
            note.Add(2, "'Rebuild It!' can automaticlaly rebuild burnt, collapsed, flooded and abandoned buildings.");

            if (Helper.IsModInstalled(503147777)) // MoleDozer
            {
                note.Add(3, "Note: The base game now includes an underground bulldozer button - you can find it on the striped bulldoze bar while the bulldoze tool is active.");
            }

            deprecated.Add(1628521230, 1); // Bulldoze Everything
            deprecated.Add(1507233911, 1); // Automatic Bulldoze

            obsolete.Add(445799544, 3);  // * V10Bulldoze
            obsolete.Add(406132323, 3);  // * Automatic Bulldoze
            obsolete.Add(1393966192, 3); // * Automatic Bulldoze Simple Edition
            obsolete.Add(639486063, 3);  // * Automatic Bulldoze v2
            obsolete.Add(503147777, 3);  // * MoleDozer -- vanilla game now has button on bulldoze bar to bulldoze underground
        }
    }
}
