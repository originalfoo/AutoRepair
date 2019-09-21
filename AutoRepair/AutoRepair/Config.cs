namespace AutoRepair {
    using System.Collections.Generic;

    static class Config {
        internal const string DEFAULT_LANGUAGE = "en";
        internal const string RESOURCES_PREFIX = "AutoRepair.Resources.";

        internal static Dictionary<string, string> Languages = new Dictionary<string, string>() {
            { "en", "English" }
        };
    }
}
