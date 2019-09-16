using AutoRepair.Util;
using System;

/// <summary>
/// Outputs a list of all subscribed mods to the log file.
/// </summary>
namespace AutoRepair.Features {
    public static class OutputModsList {

        public static bool Start() {
            Log.Info("[OutputModsList.Prepare] Preparing.");
            try {
                // todo
            }
            catch (Exception e) {
                Log.Error($"ERROR [OutputModsList.Prepare] {e.Message}");
            }
            return false;
        }

        private static void Run() {
            Log.Info("[OutputModsList.Run] Output mods list to log.");
            try {
                // todo
            } catch (Exception e) {
                Log.Error($"ERROR [OutputModsList.Run] {e.Message}");
            }
        }

        public static void Stop() {

        }
    }
}
