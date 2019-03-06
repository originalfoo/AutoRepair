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
//            Dictionary<ulong, PluginManager.PluginInfo> brokenMods = Broken.ModsInstalled();

            foreach (IReplacement script in Scripts)
            {
                Debug.Log(script.ToString());


                // why is this failing?
                foreach (ulong deprecation in script.Deprecates.Keys)
                {

                    //Debug.Log($"{deprecation}");

/*
                    if (brokenMods.ContainsKey(deprecation))
                    {
                        Debug.Log($"[{Mod.name}] DETECT: {deprecation} REPLACE WITH: {script.Replacements}");
                    }
*/
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
