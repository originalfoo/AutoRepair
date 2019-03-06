using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace Incompatible.Replacements
{
    class ReplacementBase
    {
        public virtual bool Always => false;

        public virtual Selection Mode => Selection.OnlyOne;

        protected Dictionary<ulong, byte> replacements = null;

        public virtual Dictionary<ulong, byte> Replacements => replacements;

        protected Dictionary<byte, string> notes = null;

        public virtual Dictionary<byte, string> Notes => notes;

        protected Dictionary<ulong, byte> deprecates = null;

        public virtual Dictionary<ulong, byte> Deprecates => deprecates;

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
