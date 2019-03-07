using ColossalFramework;
using ColossalFramework.Plugins;
using ICities;
using System;
using System.Collections.Generic;
using UnityEngine;
using static ColossalFramework.Plugins.PluginManager;

namespace ModFreshener
{
    public static class Helper
    {
        // fake workshop id to use for replacements
        public static ulong CitiesSkylinesFeature = 0;

        // dumps a nice list of mods to the game log file
        public static void DumpModListToLog()
        {
            List<string> output = new List<string>()
            {
                 "===================================================================================",
                $"[{Mod.name}] SUBSCRIBED MODS LIST",
                 "===================================================================================",
            };

            try
            {
                foreach (PluginInfo plugin in Singleton<PluginManager>.instance.GetPluginsInfo())
                {
                    if (plugin.isCameraScript)
                    {
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
            catch (Exception e)
            {
                Debug.Log($"[{Mod.name}] Helper.DumpModListToLog() ERROR");
                Debug.LogException(e);
            }
        }

        // get plugin info for a local mod
        // note: may be null if mod not found
        public static PluginInfo GetLocalMod(string name)
        {
            try
            {
                foreach (PluginInfo plugin in Singleton<PluginManager>.instance.GetPluginsInfo())
                {
                    if (!plugin.isBuiltin && !plugin.isCameraScript && plugin.publishedFileID.AsUInt64 == ulong.MaxValue && GetModName(plugin) == name)
                    {
                        return plugin;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Log($"[{Mod.name}] Helper.DumpModListToLog() ERROR");
                Debug.LogException(e);
            }
            return null;
        }

        // get plugin info for a bundled mod
        // note: may be null if mod not found
        public static PluginInfo GetBundledMod(string name)
        {
            try
            {
                foreach (PluginInfo plugin in Singleton<PluginManager>.instance.GetPluginsInfo())
                {
                    if (plugin.isBuiltin && GetModName(plugin) == name)
                    {
                        return plugin;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Log($"[{Mod.name}] Helper.DumpModListToLog() ERROR");
                Debug.LogException(e);
            }
            return null;
        }

        // returns name of mod as defined in the IUserMod class
        public static string GetModName(PluginInfo pluginInfo)
        {
            string name = pluginInfo.name;
            IUserMod[] instances = pluginInfo.GetInstances<IUserMod>();
            if ((int)instances.Length > 0)
            {
                name = instances[0].Name;
            }
            return name;
        }

        /* todo - check subscribed first, and if not found there go to workshop
        public static string GetModName(ulong workshopId, bool allowOnlineQuery)
        {

        }
        */

        public static bool IsModBroken(PluginInfo pluginInfo)
        {
            return IsModBroken(pluginInfo.publishedFileID.AsUInt64);
        }

        public static bool IsModBroken(ulong workshopId)
        {
            return Broken.mods.ContainsKey(workshopId);
        }

        public static PluginInfo GetPluginInfo(ulong workshopId, bool allowOnlineQuery)
        {
            try
            {
                // check installed mods first
                foreach (PluginInfo plugin in Singleton<PluginManager>.instance.GetPluginsInfo())
                {
                    if (plugin.publishedFileID.AsUInt64 == workshopId)
                    {
                        return plugin;
                    }
                }

                // check online workshop
                if (allowOnlineQuery && IsWorkshopAvailable())
                {
                    // todo
                }
            }
            catch (Exception e)
            {
                Debug.Log($"[{Mod.name}] Helper.GetPluginInfo() ERROR");
                Debug.LogException(e);
            }
            return null;
        }

        public static bool IsModInstalled(ulong workshopId)
        {
            try
            {
                foreach (PluginInfo plugin in Singleton<PluginManager>.instance.GetPluginsInfo())
                {
                    if (!plugin.isBuiltin && !plugin.isCameraScript && plugin.publishedFileID.AsUInt64 == workshopId)
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Log($"[{Mod.name}] Helper.IsModInstalled({workshopId}) ERROR");
                Debug.LogException(e);
            }
            return false;
        }

        public static bool IsModEnabled(ulong workshopId)
        {
            try
            {
                foreach (PluginInfo plugin in Singleton<PluginManager>.instance.GetPluginsInfo())
                {
                    if (!plugin.isBuiltin && !plugin.isCameraScript && plugin.publishedFileID.AsUInt64 == workshopId && plugin.isEnabled)
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Log($"[{Mod.name}] Helper.IsModEnabled({workshopId}) ERROR");
                Debug.LogException(e);
            }
            return false;
        }

        public static bool IsWorkshopAvailable()
        {
            // todo
            return false;
        }

        public static bool IsSteamOverlayAvailable()
        {
            // todo
            return false;
        }
    }
}
