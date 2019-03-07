using ColossalFramework.Plugins;
using ModFreshener.Replacements.Scripts;
using System.Collections.Generic;
using UnityEngine;

namespace ModFreshener.Replacements
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
                }
            }
        }

        // Replacement scripts
        // Ordered to tackle the most likely game breaking problems first
        protected IReplacement[] Scripts =
        {
            new Tiles81(),
            new TrafficManager(),
            new CustomizeIt(),
            new FineRoad(),
            new Tiles25(),
            new MoveIt(),
            new AVO(),
            new RoadOptions(),
            new BulldozeIt(),
            new Landscaping(),
            new FindIt(),
            new HideIt(),
            new Limits(),
            new NetworkSkins(),
            new PrecisionEngineering(),
            new ResizeIt(),
            new ShowIt(),
            new UnlimitedMoney(),
            new UnlimitedResources(),
            new UnlimitedSoil(),
            new UnlockAll(),
            new StopSelection(),
        };
    }
}
