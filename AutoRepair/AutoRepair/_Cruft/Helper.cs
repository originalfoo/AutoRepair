using ColossalFramework;
using ColossalFramework.Plugins;
using ICities;
using System;
using System.Collections.Generic;
using UnityEngine;
using static ColossalFramework.Plugins.PluginManager;

namespace AutoRepair.Util
{
    public static class Helper {
        // fake workshop id to use for replacements
        public static ulong CitiesSkylinesFeature = 0;

        // dumps a nice list of mods to the game log file
        public static void DumpModListToLog() {
            List<string> output = new List<string>()
            {
                 "===================================================================================",
                $"[{Mod.name}] SUBSCRIBED MODS LIST",
                 "===================================================================================",
            };

            try {
                foreach (PluginInfo plugin in Singleton<PluginManager>.instance.GetPluginsInfo()) {
                    if (plugin.isCameraScript) {
                        continue;
                    }

                    string id = plugin.isBuiltin
                        ? "(Bundled)"
                        : plugin.publishedFileID.AsUInt64 == ulong.MaxValue
                            ? "(Local)"
                            : plugin.publishedFileID.ToString();

                    string broken = Broken.mods.ContainsKey(plugin.publishedFileID.AsUInt64) ? "!" : " ";
                    string enabled = plugin.isEnabled ? "* " : "  ";

                    output.Add(broken + enabled + id.PadRight(12) + GetModName(plugin));
                }

                output.Add("===================================================================================");

                Debug.Log(String.Join("\n", output.ToArray()));
            }
            catch (Exception e) {
                Debug.Log($"[{Mod.name}] Helper.DumpModListToLog() ERROR");
                Debug.LogException(e);
            }
        }
    }
}
