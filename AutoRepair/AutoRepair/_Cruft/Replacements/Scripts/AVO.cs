namespace AutoRepair.Replacements.Scripts
{
    class AVO : ReplacementBase
    {
        public AVO()
        {
            option.Add(1548831935, 1); // Advanced Vehicle Options by Tim

            note.Add(1, "AVO allows you to customise vehicle stats (capacity, speed, colors...), and also control which vehicles can spawn. Compatible with latest game version and all DLCs.");

            deprecated.Add(442167376, 1); // Advanced Vehicle Options by SamSamTS

            obsolete.Add(1228424498, 1); // * Bzimage VehicleCapacity
            obsolete.Add(414326578, 1);  // * Configurable Transport Capacity
        }
    }
}
