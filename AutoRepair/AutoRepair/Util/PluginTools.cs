using ColossalFramework;
using ColossalFramework.Plugins;
using ICities;
using System;
using System.Collections.Generic;
using static ColossalFramework.Plugins.PluginManager;
using AutoRepair.Struct;

namespace AutoRepair.Util {
    public static class PluginTools {

        /// <summary>
        /// Fake workshop id used to denote vanilla game feature.
        /// Can be used in <see cref="ModDetails.Replacements"/> and <see cref="ModDetails.Conflicts"/>
        /// </summary>
        public static readonly ulong VanillaGame = 1;

        /// <summary>
        /// Fake workshop id used to denote bundled UnlockAll mod.
        /// Can be used in <see cref="ModDetails.Replacements"/> and <see cref="ModDetails.Conflicts"/>
        /// </summary>
        public static readonly ulong UnlockAll = 2;

        /// <summary>
        /// Fake workshop id used to denote bundled UnlimitedMoney mod.
        /// Can be used in <see cref="ModDetails.Replacements"/> and <see cref="ModDetails.Conflicts"/>
        /// </summary>
        public static readonly ulong UnlimitedMoney = 3;

        public static readonly ulong UnlimitedSoil = 4;

        public static readonly ulong UnlimitedOilOre = 5;


        /// <summary>
        /// Returns a list of all plugins, including bundled mods, camera scripts and 
        /// </summary>
        public static IEnumerable<PluginInfo> ListOfAllPlugins => Singleton<PluginManager>.instance.GetPluginsInfo();

        public delegate bool PluginListFilter(PluginInfo info);

        /// <summary>
        /// Filters a custom list of plugins to those mathcing a filter.
        /// </summary>
        /// 
        /// <param name="list">The list of plugins to filter.</param>
        /// <param name="filter">Filter function which should return <c>true</c> if the plugin matches.</param>
        /// <param name="first">If <c>true</c>, only the first match will be returned.</param>
        /// <returns>A list of zero or more <see cref="PluginInfo"/> that match the filter.</returns>
        public static List<PluginInfo> FilterPluginList(IEnumerable<PluginInfo> list, PluginListFilter filter, bool first = false) {
            List<PluginInfo> results = new List<PluginInfo> { };
            try {
                foreach (PluginInfo plugin in list) {
                    if (filter(plugin)) {
                        results.Add(plugin);
                        if (first) {
                            break;
                        }
                    }
                }
            }
            catch (Exception e) {
                Log.Error($"[PluginTools.FilterPluginList] Error: {e.Message}");
            }
            return results;
        }

        /// <summary>
        /// Filters a list of all plugins to those mathcing a filter.
        /// </summary>
        /// 
        /// <param name="list">The list of plugins to filter.</param>
        /// <param name="filter">Filter function which should return <c>true</c> if the plugin matches.</param>
        /// <param name="first">If <c>true</c>, only the first match will be returned.</param>
        /// <returns>A list of zero or more <see cref="PluginInfo"/> that match the filter.</returns>
        public static List<PluginInfo> FilterPluginList(PluginListFilter filter, bool first = false) {
            return FilterPluginList(ListOfAllPlugins, filter, first);
        }

        /// <summary>
        /// Sets the <see cref="PluginInfo.isEnabled"/> state of plugins matching criteria.
        /// </summary>
        ///
        /// <param name="list">The list of plugins to filter.</param>
        /// <param name="filter">A <see cref="PluginListFilter"/>.</param>
        /// <param name="enabled">If <c>true</c> matching plugins will be enabled; otherwise they will be disabled.</param>
        /// <param name="first">If <c>true</c> (default) only the first matching plugin will be affected.</param>
        ///
        /// <returns>Returns <c>true</c> if successful, otherwise <c>false</c>.</returns>
        public static bool SetPluginEnabledState(IEnumerable<PluginInfo> list, PluginListFilter filter, bool enabled, bool first = true) {
            try {
                List<PluginInfo> results = FilterPluginList(list, filter, first);
                foreach (PluginInfo plugin in results) {
                    plugin.isEnabled = enabled;
                }
                return true;
            }
            catch (Exception e) {
                Log.Error($"[PluginTools.SetPluginEnabledState] Error: {e.Message}");
                return false;
            }
        }

        /// <summary>
        /// Returns the name of a mod by inspecting its <see cref="IUserMod.Name"/> property.
        /// If that can't be found, it defaults to the <see cref="PluginInfo.name"/> instead.
        /// </summary>
        /// 
        /// <param name="pluginInfo">The <see cref="PluginInfo"/> reference to the mod.</param>
        /// 
        /// <returns>Returns the name of the mod.</returns>
        public static string GetModName(PluginInfo pluginInfo) {
            string name = pluginInfo.name;
            try {
                IUserMod[] instances = pluginInfo.GetInstances<IUserMod>();
                if ((int)instances.Length > 0) {
                    name = instances[0].Name;
                }
            }
            catch (Exception e) {
                Log.Error($"[PluginTools.GetModName] Error: {e.Message}");
            }
            return name;
        }

    }
}