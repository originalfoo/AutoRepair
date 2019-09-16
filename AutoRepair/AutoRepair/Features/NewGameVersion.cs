using AutoRepair.Util;
using System;

/// <summary>
/// Outputs a list of all subscribed mods to the log file.
/// </summary>
namespace AutoRepair.Features {
    public static class NewGameVersion {

        public static bool Start() {
            Log.Info("[NewGameVersion.Prepare] Preparing.");
            try {
                // todo
            }
            catch (Exception e) {
                Log.Error($"ERROR [NewGameVersion.Prepare] {e.Message}");
            }
            return false;
        }

        private static void Run() {
            Log.Info("[NewGameVersion.Run] Output mods list to log.");
            try {
                // todo
            } catch (Exception e) {
                Log.Error($"ERROR [NewGameVersion.Run] {e.Message}");
            }
        }

        public static void Stop() {

        }
    }
}
