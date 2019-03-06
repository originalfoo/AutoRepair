using ColossalFramework.Plugins;
using Incompatible.Replacements.Scripts;
using System.Collections.Generic;
using UnityEngine;

namespace Incompatible.Replacements
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

        protected IReplacement[] Scripts =
        {
            new AVO(),
            new BulldozeIt(),
            new CustomizeIt(),
            new FindIt(),
            new FineRoad(),
            new HideIt(),
            new Landscaping(),
            new Limits(),
            new MoveIt(),
            new NetworkSkins(),
            new PrecisionEngineering(),
            new PurchaseIt(),
            new ResizeIt(),
            new RoadOptions(),
            new ShowIt(),
            new StopSelection(),
            new TrafficManager(),
            new UnlimitedMoney(),
            new UnlimitedResources(),
            new UnlimitedSoil(),
            new UnlockAll(),            
        };
    }
}
