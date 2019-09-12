using ColossalFramework.Plugins;

namespace AutoRepair.Replacements.Scripts
{
    class Landscaping : ReplacementBase
    {
        public Landscaping()
        {
            choice = Select.Any;

            option.Add(502750307, 1); // Extra Landscaping Tools by BloodyPenguin
            option.Add(1658679290, 2); // Forest Brush by TPB

            note.Add(1, "'Extra Landscapin Tools' adds terraforming, natural resource, water and tree painter to the game.");
            note.Add(2, "'Forest Brush' allows you to quickly crete forest styles (plant collections) and then paint them on the map.");

            deprecated.Add(406723376, 3); // Tree Brush
            deprecated.Add(1654658173, 2); // Random Tree Brush

            obsolete.Add(411095553, 1); // * Terraform tool 0.9
            obsolete.Add(423964385, 3); // * TreeBrush
        }

        private bool trees = false;
        private bool terraform = false;

        public override void OnBeforeRemove(PluginManager.PluginInfo plugin)
        {
            ulong id = plugin.publishedFileID.AsUInt64;

            switch (id)
            {
                case 406723376:
                case 423964385:
                case 1654658173:
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
