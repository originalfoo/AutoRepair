namespace AutoRepair.Enums {
    using System.ComponentModel;

    public enum ReplacementMode {
        // There are no replacements for this item
        [Description("No replacements")]
        ChooseNone = 0,

            // Choices act like radio buttons
        [Description("Choose only one")]
        ChooseOne,

        // Choices act like checkboxes
        [Description("Choose any")]
        ChooseAny,

        // Choices act like '(de)select all'
        [Description("Choose all")]
        ChooseAll,
    }
}
