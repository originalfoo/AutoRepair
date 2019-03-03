using ColossalFramework;
using ColossalFramework.Plugins;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Incompatible.Broken
{
    public static class Broken
    {
        // a list of game breaking or obsolete mods
        public static readonly Dictionary<ulong,bool> list = new Dictionary<ulong, bool>
        {
            // need to re-check these
            { 529979180, true  }, // CSL Service Reserve
            { 413847191, true  }, // SOM - Services Optimisation Module
            // also, one of the compass mods might be working


            // true  = Replacement mod available, or incorporated in to base game
            //         ('*' in inline comment denotes replacement mod exists)
            // false = No replacement

            { 422554572,  true  }, // 81 Tiles Updated
            { 412168106,  false }, // Adjustable Demand v2
            { 563229150,  true  }, // * Advanced Toolbar
            { 616078328,  true  }, // * All Tile Start
            { 425057208,  true  }, // * Area Enabler
            { 408760323,  false }, // Auto Line Color
            { 406132323,  true  }, // * Automatic Bulldoze
            { 1393966192, true  }, // * Automatic Bulldoze Simple Edition
            { 639486063,  true  }, // * Automatic Bulldoze v2
            { 686588890,  true  }, // Automatic Emptying: Extended
            { 416064574,  true  }, // Cimtographer
            { 408613485,  true  }, // City Statistics Early Access
            { 658232246,  true  }, // Compass
            { 420469721,  true  }, // Compass Mod
            { 410535198,  true  }, // Control Building Level Up
            { 1398502258, true  }, // Dam Upkeep Scaler
            { 821539759,  true  }, // Disable Zone Check
            { 649522495,  true  }, // District Service Limit
            { 406629464,  true  }, // Dynamic Resolution
            { 421188880,  true  }, // [ARIS] Early Death
            { 813835487,  true  }, // Early Death [1.6]
            { 587516082,  true  }, // Early Death [Fixed for 1.4 +]
            { 569008960,  true  }, // Employ Overeducated Workers
            { 456408505,  true  }, // European Buildings Unlocker
            { 451906822,  true  }, // * Enhanced build panel
            { 439582006,  true  }, // [ARIS] Enhanced Garbage Truck AI
            { 583552152,  true  }, // Enhanced Garbage Truck AI [Fixed for v1.4 +]
            { 813835391,  true  }, // Enhanced Garbage Truck AI [1.6]
            { 433249875,  true  }, // [ARIS] Enhanced Hearse AI
            { 583556014,  true  }, // Enhanced Hearse AI [Fixed for v1.4 +]
            { 813835241,  true  }, // Enhanced Hearse AI [1.6]
            { 448434637,  true  }, // * Enhanced Road Heights
            { 1133108993, true  }, // * Extended Building Information (1.10+)
            { 767809751,  true  }, // * Extended Building Information (Chinese)
            { 414469593,  true  }, // * Extended Building Information
            { 670422128,  true  }, // * Extended Building Information
            { 928988785,  true  }, // * Extended Building Information
            { 411164732,  true  }, // Extended Public Transport UI
            { 802489150,  true  }, // Extended Public Transport UI (+DLCs!)
            { 408209297,  true  }, // Extended Road Upgrade
            { 631694768,  true  }, // Extended Road Upgrade
            { 451700838,  true  }, // * Extended Toolbar
            { 410234967,  true  }, // Fire Spread
            { 637901778,  true  }, // Fire Spread [Fixed for C:S 1.3.2+]
            { 406255342,  true  }, // First Person Camera
            { 439360165,  true  }, // * Hide district policy icons
            { 413748580,  true  }, // Image Overlay
            { 492391912,  true  }, // * Improved AI (Traffic++)
            { 508195208,  true  }, // Improved Asset Icons
            { 417430545,  true  }, // Improved Assets Panel
            { 416033610,  true  }, // Improved Mods Panel
            { 580335918,  true  }, // Infinite Oil and Ore
            { 472128528,  true  }, // Larger Footprints
            { 503147777,  true  }, // * MoleDozer
            { 1434173135, true  }, // * Move It (Chinese version)
            { 1120637951, true  }, // * Move It Extra Filters
            { 1622545887, true  }, // * Move It (Legacy Edition)
            { 420230361,  true  }, // Moving Sun
            { 532863263,  true  }, // * Multi-track Station Enabler
            { 442957897,  true  }, // * Multi-track Station Enabler
            { 478820060,  true  }, // Network Extensions Project(v1)
            { 658653260,  true  }, // * Network Nodes Editor [Experimental]
            { 929114228,  true  }, // New Roads for Network Extensions
            { 1147015481, true  }, // * No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
            { 407270433,  true  }, // * No more purple pollution (normal grass)
            { 407795371,  true  }, // * No more purple pollution (brown grass)
            { 407810495,  true  }, // * No more purple pollution (tan grass)
            { 407842191,  true  }, // * No more purple pollution (red-brown grass)
            { 407890452,  true  }, // * No more purple pollution (grey grass)
            { 482360157,  true  }, // * No more purple pollution (radioactive green grass)
            { 408126080,  true  }, // * No more purple pollution (brown water)
            { 408126282,  true  }, // * No more purple pollution (green water)
            { 408190203,  true  }, // * No more purple pollution (muddy water)
            { 408189919,  true  }, // * No more purple pollution (silty water)
            { 408167727,  true  }, // * No more purple pollution (radioactive green water)
            { 409073164,  true  }, // * No pillars
            { 771161159,  true  }, // OSM Import
            { 410842044,  true  }, // Persistent Resource View
            { 685747254,  true  }, // Prop Fine Tune
            { 421050717,  true  }, // * [ARIS] Remove Cows
            { 587545554,  true  }, // * Remove Cows [Fixed for v1.4 +]
            { 813835951,  true  }, // * Remove Cows [1.6]
            { 421052798,  true  }, // * [ARIS] Remove Pigs
            { 587549083,  true  }, // * Remove Pigs [Fixed for v1.4 +]
            { 813835851,  true  }, // * Remove Pigs [1.6]
            { 421041154,  true  }, // * [ARIS] Remove Seagulls
            { 587536931,  true  }, // * Remove Seagulls [Fixed for v1.4 +]
            { 813835673,  true  }, // * Remove Seagulls [1.6]
            { 428094792,  true  }, // * [ARIS] Remove Stuck Vehicles
            { 587530437,  true  }, // * Remove Stuck Vehicles [Fixed for v1.4 +]
            { 813834836,  true  }, // * Remove Stuck Vehicles [1.6]
            { 820547325,  true  }, // Resilient Owners (Make Historical)
            { 1628112268, true  }, // * RightTurnNoStop
            { 418556522,  true  }, // * Road Anarchy
            { 954034590,  true  }, // * Road Anarchy V2
            { 417926819,  true  }, // * Road Assistant
            { 417585852,  true  }, // * Road Color Changer (original)
            { 651610627,  true  }, // * Road Color Changer Continued
            { 436253779,  true  }, // * Road Protractor
            { 726005715,  true  }, // Roads United Core+
            { 680748394,  true  }, // Roads United: North America
            { 605590542,  true  }, // Rush Hour[Beta]
            { 540758804,  true  }, // * Search Box Mod
            { 785237088,  true  }, // * Service Radius Adjuster
            { 553184329,  true  }, // * Sharp Junction Angles
            { 494094728,  true  }, // * Show limits
            { 421028969,  false }, // [ARIS] Skylines Overwatch
            { 583538182,  false }, // Skylines Overwatch [Fixed for v1.3 +]
            { 813833476,  false }, // Skylines Overwatch [1.6]
            { 1393831156, true  }, // Sub Mesh Flags
            { 556416380,  true  }, // Telemetry Control
            { 411095553,  true  }, // * Terraform Tool 0.9
            { 510802741,  true  }, // Toggle District Snapping
            { 415782697,  true  }, // Toggle Zoning
            { 409184143,  true  }, // * Traffic++
            { 626024868,  true  }, // * Traffic++ V2
            { 583429740,  true  }, // * Traffic Manager: President Edition (LinuxFan)
            { 1581695572, true  }, // * Traffic Manager: President Edition (temp bugfix)
            { 1348361731, true  }, // * Traffic Manager: President Edition ALPHA/DEBUG
            { 498363759,  true  }, // * Traffic Manager + Improved AI
            { 563720449,  true  }, // * Traffic Manager + Improved AI (Japanese Ver.)
            { 423964385,  true  }, // * TreeBrush
            { 477615230,  true  }, // * UnlockAreaCountLimit
            { 709765899,  true  }, // * UnlockAreaCountLimit
            { 477574890,  true  }, // * UnlockAreaCountLimit
            { 477574991,  true  }, // * UnlockAreaCountLimitAndFree
            { 477615068,  true  }, // * UnlockAreaCountLimitAndFree
            { 445799544,  true  }, // * V10Bulldoze
            { 414702884,  true  }, // Zoneable Pedestrian Paths
        };

        public static Dictionary<ulong, PluginManager.PluginInfo> ModsInstalled()
        {
            Dictionary<ulong, PluginManager.PluginInfo> detected = new Dictionary<ulong, PluginManager.PluginInfo>();

            foreach (PluginManager.PluginInfo pluginInfo in Singleton<PluginManager>.instance.GetPluginsInfo())
            {
                if ( !pluginInfo.isBuiltin && list.ContainsKey(pluginInfo.publishedFileID.AsUInt64) ) {
                    if (list[pluginInfo.publishedFileID.AsUInt64])
                    {
                        Debug.Log($"[{Mod.name}] Superseded mod: {pluginInfo.publishedFileID.ToString()} {pluginInfo.name}");
                    }
                    else
                    {
                        Debug.Log($"[{Mod.name}] Obsolete/broken mod: {pluginInfo.publishedFileID.ToString()} {pluginInfo.name}");
                    }
                    detected.Add(pluginInfo.publishedFileID.AsUInt64, pluginInfo);
                }
            }

            return detected;
        }

    }

}

