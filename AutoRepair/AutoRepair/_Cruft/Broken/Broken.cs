using ColossalFramework;
using ColossalFramework.Plugins;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace AutoRepair {
    public static class Broken {
        // a list of game breaking or obsolete mods
        public static readonly Dictionary<ulong, string> mods = new Dictionary<ulong, string>
        {
            // '*' at start of string means "replacement available"

            { 412168106,  "Adjustable Demand v2" },
            { 563229150,  "* Advanced Toolbar" },
            { 408760323,  "Auto Line Color" },
            { 406132323,  "* Automatic Bulldoze" },
            { 1393966192, "* Automatic Bulldoze Simple Edition" },
            { 639486063,  "* Automatic Bulldoze v2" },

            { 1228424498, "* Bzimage VehicleCapacity" },
            { 416064574,  "Cimtographer" },
            { 408613485,  "City Statistics Early Access" },
            { 658232246,  "Compass" },
            { 420469721,  "Compass Mod" },
            { 414326578,  "* Configurable Transport Capacity" },
            { 410535198,  "Control Building Level Up" },
            { 443489442,  "* Custom Milestone Unlocker" },
            { 1398502258, "Dam Upkeep Scaler" },
            { 821539759,  "Disable Zone Check" },
            { 649522495,  "District Service Limit" },
            { 406629464,  "Dynamic Resolution" },
            { 421188880,  "[ARIS] Early Death" },
            { 813835487,  "Early Death [1.6]" },
            { 587516082,  "Early Death [Fixed for 1.4 +]" },
            { 410614868,  "* EarlyUnlock" },
            { 569008960,  "Employ Overeducated Workers" },
            { 456408505,  "European Buildings Unlocker" },
            { 451906822,  "* Enhanced build panel" },
            { 411164732,  "Extended Public Transport UI" },
            { 802489150,  "Extended Public Transport UI (+DLCs!)" },
            { 408209297,  "Extended Road Upgrade" },
            { 631694768,  "Extended Road Upgrade" },
            { 451700838,  "* Extended Toolbar" },
            { 410234967,  "Fire Spread" },
            { 637901778,  "Fire Spread [Fixed for C:S 1.3.2+]" },
            { 406255342,  "First Person Camera" },
            { 439360165,  "* Hide district policy icons" },
            { 413748580,  "Image Overlay" },
            { 492391912,  "* Improved AI (Traffic++)" },
            { 508195208,  "Improved Asset Icons" },
            { 417430545,  "Improved Assets Panel" },
            { 416033610,  "Improved Mods Panel" },
            { 852103955,  "* InfiniteOilAndOre" },
            { 580335918,  "* Infinite Oil and Ore Redux" },
            { 472128528,  "Larger Footprints" }, // no replacement
            { 503147777,  "* MoleDozer" },
            { 1434173135, "* Move It (Chinese version)" },
            { 1120637951, "* Move It Extra Filters" },
            { 1622545887, "* Move It (Legacy Edition)" },
            { 420230361,  "* Moving Sun" },
            { 532863263,  "* Multi-track Station Enabler" },
            { 442957897,  "* Multi-track Station Enabler" },
            { 478820060,  "Network Extensions Project(v1)" },
            { 658653260,  "* Network Nodes Editor [Experimental]" },
            { 929114228,  "New Roads for Network Extensions" },
            { 1147015481, "* No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets" },
            { 407270433,  "* No more purple pollution (normal grass)" },
            { 407795371,  "* No more purple pollution (brown grass)" },
            { 407810495,  "* No more purple pollution (tan grass)" },
            { 407842191,  "* No more purple pollution (red-brown grass)" },
            { 407890452,  "* No more purple pollution (grey grass)" },
            { 482360157,  "* No more purple pollution (radioactive green grass)" },
            { 408126080,  "* No more purple pollution (brown water)" },
            { 408126282,  "* No more purple pollution (green water)" },
            { 408190203,  "* No more purple pollution (muddy water)" },
            { 408189919,  "* No more purple pollution (silty water)" },
            { 408167727,  "* No more purple pollution (radioactive green water)" },
            { 409073164,  "* No pillars" },
            { 654586812,  "* No Soil Limit" },
            { 771161159,  "OSM Import" },
            { 410842044,  "Persistent Resource View" },
            { 685747254,  "Prop Fine Tune" },
            { 421050717,  "* [ARIS] Remove Cows" },
            { 587545554,  "* Remove Cows [Fixed for v1.4 +]" },
            { 813835951,  "* Remove Cows [1.6]" },
            { 421052798,  "* [ARIS] Remove Pigs" },
            { 587549083,  "* Remove Pigs [Fixed for v1.4 +]" },
            { 813835851,  "* Remove Pigs [1.6]" },
            { 421041154,  "* [ARIS] Remove Seagulls" },
            { 587536931,  "* Remove Seagulls [Fixed for v1.4 +]" },
            { 813835673,  "* Remove Seagulls [1.6]" },
            { 428094792,  "* [ARIS] Remove Stuck Vehicles" },
            { 587530437,  "* Remove Stuck Vehicles [Fixed for v1.4 +]" },
            { 813834836,  "* Remove Stuck Vehicles [1.6]" },
            { 820547325,  "Resilient Owners (Make Historical)" },
            { 1628112268, "* RightTurnNoStop" },
            { 417926819,  "* Road Assistant" },
            { 417585852,  "* Road Color Changer (original)" },
            { 651610627,  "* Road Color Changer Continued" },
            { 436253779,  "* Road Protractor" },
            { 726005715,  "Roads United Core+" },
            { 680748394,  "Roads United: North America" },
            { 605590542,  "Rush Hour II" },
            { 540758804,  "* Search Box Mod" },
            { 413847191,  "SOM - Services Optimisation Module" },
            { 785237088,  "* Service Radius Adjuster" },
            { 494094728,  "* Show limits" },
            { 1393831156, "Sub Mesh Flags" },
            { 556416380,  "Telemetry Control" },
            { 411095553,  "* Terraform Tool 0.9" },
            { 510802741,  "Toggle District Snapping" },
            { 415782697,  "Toggle Zoning" },
            { 409184143,  "* Traffic++" },
            { 626024868,  "* Traffic++ V2" },
            { 1581695572, "* Traffic Manager: President Edition (temp bugfix)" },
            { 1348361731, "* Traffic Manager: President Edition ALPHA/DEBUG" },
            { 498363759,  "* Traffic Manager + Improved AI" },
            { 563720449,  "* Traffic Manager + Improved AI (Japanese Ver.)" },
            { 423964385,  "* TreeBrush" },
            { 445799544,  "* V10Bulldoze" },
            { 414702884,  "Zoneable Pedestrian Paths" }, // no mod replacement, but there are 'road' assets that can be used
            { 421320224,  "Unlock Districts" },
        };

        // returns a list of which broken mods are currently installed
        public static Dictionary<ulong, PluginManager.PluginInfo> ModsInstalled() {
            Debug.Log($"[{Mod.name}] Scanning for broken mods...");
            Dictionary<ulong, PluginManager.PluginInfo> detected = new Dictionary<ulong, PluginManager.PluginInfo>();

            try {
                foreach (PluginManager.PluginInfo pluginInfo in Singleton<PluginManager>.instance.GetPluginsInfo()) {
                    ulong pluginId = pluginInfo.publishedFileID.AsUInt64;
                    if (!pluginInfo.isBuiltin) {
                        if (Broken.mods.ContainsKey(pluginId)) // it's on the list of known broken mods
                        {
                            Debug.Log($"[{Mod.name}] Broken or obsolete: {pluginInfo.publishedFileID.ToString()} - {Broken.mods[pluginId]}");
                            detected.Add(pluginInfo.publishedFileID.AsUInt64, pluginInfo);
                        } else {
                            // todo: find some way to check if a mod is marked obsolete in steam workshop
                        }
                    }
                }
            }
            catch (Exception e) {
                Debug.Log($"[{Mod.name}] Unable to build broken plugin list...");
                Debug.LogException(e);
            }

            return detected;
        }

    }

}

