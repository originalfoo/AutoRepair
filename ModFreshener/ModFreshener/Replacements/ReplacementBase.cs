using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace ModFreshener.Replacements
{
    abstract class ReplacementBase : IReplacement
    {
        protected bool mandatory = false;

        public virtual bool Mandatory => mandatory;

        protected Select choice = Select.OnlyOne;

        public Select Choice => choice;

        protected Dictionary<ulong, byte> option = new Dictionary<ulong, byte>();

        public virtual Dictionary<ulong, byte> Option => option;

        protected Dictionary<byte, string> note = new Dictionary<byte, string>();

        public virtual Dictionary<byte, string> Note => note;

        protected Dictionary<ulong, byte> deprecated = new Dictionary<ulong, byte>();

        public virtual Dictionary<ulong, byte> Deprecated => deprecated;

        protected Dictionary<ulong, byte> obsolete = new Dictionary<ulong, byte>();

        public virtual Dictionary<ulong, byte> Obsolete => obsolete;

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
