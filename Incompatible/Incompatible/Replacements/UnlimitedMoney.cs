using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace Incompatible.Replacements
{
    class UnlimitedMoney : ReplacementBase, IReplacement
    {
        internal new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { Helper.CitiesSkylinesFeature, 1 } // CSL Inbuilt Mod
        };

        internal new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Cities: Skylines now contains this feature in the base game." },
        };

        internal new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            // load of spammy "Unlimited Money" style mods (all broken)
            { 438378612, 1 },
            { 428608882, 1 },
            { 427997113, 1 },
            { 427901620, 1 },
            { 424026003, 1 },
            { 422901712, 1 },
            { 420911882, 1 },
            { 420550550, 1 },
            { 419484397, 1 },
            { 419333753, 1 },
            { 418153488, 1 },
            { 417187838, 1 },
        };

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            if (wasEnabled)
            {
                PluginManager.PluginInfo mod = Helper.GetBundledMod("Unlimited Money");
                if (mod != null) {
                    mod.isEnabled = true;
                }
            }
        }
    }
}
