using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace Incompatible.Replacements.Scripts
{
    class Landscaping : ReplacementBase, IReplacement
    {
        protected new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 502750307, 1 } // Extra Landscaping Tools by BloodyPenguin
        };

        protected new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Adds terraforming, natural resource, water and tree painter to the game." }
        };

        protected new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 411095553, 1 }, // * Terraform tool 0.9
            { 406723376, 1 }, // Tree Brush
            { 423964385, 1 }, // * TreeBrush
        };

        private bool trees = false;
        private bool terraform = false;

        public override void OnBeforeRemove(PluginManager.PluginInfo plugin)
        {
            ulong id = plugin.publishedFileID.AsUInt64;

            switch (id)
            {
                case 406723376:
                case 423964385:
                    trees = trees || plugin.isEnabled;
                    break;
                case 411095553:
                    terraform = terraform || plugin.isEnabled;
                    break;
            }

            base.OnBeforeRemove(plugin);
        }

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            base.OnAfterSubscribe(plugin);

            // todo: enable applicable features in ELT
        }
    }
}
