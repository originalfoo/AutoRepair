namespace AutoRepair.Replacements.Scripts
{
    class PrecisionEngineering : ReplacementBase
    {
        public PrecisionEngineering()
        {
            option.Add(1548831935, 1); // Precision Engineering by Simie

            note.Add(1, "'Precision Engineering' replaces the obsolete 'Road Protactor' mod.");

            obsolete.Add(436253779, 1); // * Road protractor
        }
    }
}