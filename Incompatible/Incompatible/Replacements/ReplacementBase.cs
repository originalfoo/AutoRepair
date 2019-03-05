using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace Incompatible.Replacements
{
    class ReplacementBase
    {
        public virtual bool Always => false;

        public virtual Selection Mode => Selection.Any;

        internal Dictionary<ulong, byte> replacements = null;

        public Dictionary<ulong, byte> Replacements => replacements;

        internal Dictionary<byte, string> notes = null;

        public Dictionary<byte, string> Notes => notes;

        internal Dictionary<ulong, byte> deprecates = null;

        public Dictionary<ulong, byte> Deprecates => deprecates;

        protected bool wasEnabled = false;

        public virtual void OnBeforeRemove(PluginManager.PluginInfo plugin)
        {
            wasEnabled = wasEnabled || plugin.isEnabled;
        }

        public virtual void OnAfterRemove(PluginManager.PluginInfo plugin)
        {
            // xyzzy
        }

        public virtual void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            plugin.isEnabled = plugin.isEnabled || wasEnabled;
        }
    }
}
