namespace AutoRepair.Enums {
    using System.ComponentModel;

    public enum GameUpdateMode {
        [Description("Do nothing (may cause crashes)")]
        DoNothing,

        [Description("Disable all mods (manual re-enable)")]
        DisableAll,

        [Description("Disable all, until confirmed compatible")]
        EnableCompatible,

        [Description("Disable if broken, re-enable when compatible")]
        DisableBroken,
    }
}
