using ColossalFramework.Plugins;
using AutoRepair.Replacements.Scripts;
using System.Collections.Generic;
using UnityEngine;

namespace AutoRepair.Replacements
{
    class Replacer
    {
        public void Run()
        {
            Dictionary<ulong, PluginManager.PluginInfo> brokenMods = Broken.ModsInstalled();

            foreach (IReplacement script in Scripts)
            {
                Debug.Log(script.ToString());

                foreach (ulong obsolete in script.Obsolete.Keys)
                {
                    Debug.Log($"{obsolete}");

                    if (brokenMods.ContainsKey(obsolete))
                    {
                        Debug.Log($"[{Mod.name}] DETECT: {obsolete} REPLACE WITH: {script.Option}");
                    }
                    else if (!Broken.mods.ContainsKey(obsolete))
                    {
                        Debug.Log($"[{Mod.name}] MISSING FROM BROKEN LIST: {obsolete}");
                    }
                }
            }
        }

        // Replacement scripts
        protected IReplacement[] Scripts =
        {
            new AVO(),
            new BulldozeIt(),
            new CustomizeIt(),
            new EmptyIt(),
            new FindIt(),
            new FineRoad(),
            new HideIt(),
            new Landscaping(),
            new Limits(),
            new LodDetail(),
            new MoveIt(),
            new MovingSun(),
            new NetworkSkins(),
            new PrecisionEngineering(),
            new RealTime(),
            new ResizeIt(),
            new RoadOptions(),
            new ShowIt(),
            new StopSelection(),
            new Tiles25(),
            new Tiles81(),
            new TrafficManager(),
            new UnlimitedMoney(),
            new UnlimitedResources(),
            new UnlimitedSoil(),
            new UnlockAll(),
        };
    }
}
