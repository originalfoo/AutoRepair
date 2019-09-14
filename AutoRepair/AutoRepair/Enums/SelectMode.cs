namespace AutoRepair.Enums {
    using System.ComponentModel;

    public enum SelectMode {
        // Choose zero
        [Description("No replacements")]
        ChooseNone = 0,

        // Choose zero, or one
        [Description("Choose only one")]
        ChooseOne,

        // Choose zero, one, or more
        [Description("Choose any")]
        ChooseAny,

        // Choose zero, or all
        [Description("Choose all")]
        ChooseAll,
    }
}
