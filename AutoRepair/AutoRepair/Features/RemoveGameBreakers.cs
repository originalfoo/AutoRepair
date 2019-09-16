using AutoRepair.Util;
using System;

/// <summary>
/// Removes game breaking mods.
/// </summary>
namespace AutoRepair.Features {
    public static class RemoveGameBreakers {

        public static bool Start() {
            Log.Info("[RemoveGameBreakers.Prepare] Preparing.");
            try {
                // todo
            }
            catch (Exception e) {
                Log.Error($"ERROR [RemoveGameBreakers.Prepare] {e.Message}");
            }
            return false;
        }

        private static void Run() {
            Log.Info("[RemoveGameBreakers.Run] Output mods list to log.");
            try {
                // todo
            } catch (Exception e) {
                Log.Error($"ERROR [RemoveGameBreakers.Run] {e.Message}");
            }
        }

        public static void Stop() {

        }
    }
}
