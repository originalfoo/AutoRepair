namespace AutoRepair.Replacements.Scripts
{
    class FineRoad : ReplacementBase
    {
        public FineRoad()
        {
            choice = Select.Any;

            option.Add(802066100, 1); // Fine Road Anarchy by SamSamTS
            option.Add(651322972, 2); // Fine Road Tool by SamSamTS

            note.Add(1, "'Fine Road Anarchy' allows you to toggle bending (sharp junctions), snapping, collisions and slope/height limits.");
            note.Add(2, "'Fine Road Tool' allows you to force elevated, bridge and tunnel modes, and also create smooth gradients when placing networks.");
            note.Add(3, "It is recommended to use both 'Fine Road' mods together.");

            deprecated.Add(1362508329, 1); // Fine Road Anarchy 2018
            deprecated.Add(433567230, 3);  // Advanced Road Anarchy
            deprecated.Add(1436255148, 1); // Fine Road Anarchy (Chinese)

            obsolete.Add(448434637, 2); // * Enhanced Road Heights
            obsolete.Add(418556522, 3); // * Road Anarchy
            obsolete.Add(954034590, 3); // * Road Anarchy V2
            obsolete.Add(553184329, 1); // * Sharp Junction Angles
        }
    }
}
