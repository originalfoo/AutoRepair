/// <summary>
/// These tools are used to change options of other mods
/// by interactive with the UI components of their options
/// screen. It is not 100% reliable, due to shit UI system
/// in the game, but it will work for most users and mods.
/// </summary>
namespace AutoRepair.Util {
    using ColossalFramework.UI;

    class OptionsTools {

        public static UIPanel GetOptionsRoot(ulong workshopId) {
            // todo
        }

        public static UICheckBox GetCheckbox(UIPanel root, string name) {
            // todo
        }

        public static bool GetCurrentState(UICheckBox component) {
            // todo
        }

        public static void SetCurrentState(UICheckBox component, bool state) {
            // todo
        }

        public static UIDropDown GetDropDown(UIPanel root, string name) {
            // todo
        }

        public static int GetCurrentState(UIDropDown component) {
            // todo
        }

        public static void SetCurrentState(UIDropDown component, bool state) {
            // todo
        }
    }
}
