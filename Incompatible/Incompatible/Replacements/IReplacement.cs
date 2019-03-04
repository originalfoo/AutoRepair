using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ColossalFramework.Plugins.PluginManager;

namespace Incompatible.Replacements
{
    interface IReplacement
    {
        // should the replacement always be shown?
        // * true = show if any deprecated mods are found
        // * false = show only if broken mods are found
        bool Always { get; }

        // workshop id(s) of mod(s) to upgrade to
        ulong[] Replacements { get; }

        // require all listed replacements?
        // * true = when upgrading, all replacements are required
        // * false = user can choose which replacements to upgrade to
        bool Combined { get; }

        // some text to give user more info about the upgrade
        string Notes { get; }

        // workshop id(s) of mod(s) that will be replaced when upgrading
        // * broken mods will be unsubscribed
        // * non-broken mods can be merely disabled
        ulong[] Deprecates { get; }

        // Called before unsubbing a deprecated plugin
        // ulong workshopId = plugin.publishedFileID.AsUInt64;
        // bool isEnabled = plugin.isEnabled
        // Note: The plugin will be automatically disabled after this method call
        void OnBeforeRemove(PluginInfo plugin);

        // Called after unsubbing a deprecated plugin
        // ulong workshopId = plugin.publishedFileID.AsUInt64;
        void OnAfterRemove(PluginInfo plugin);

        // Called after subscribing a replacement plugin
        // ulong workshopId = plugin.publishedFileID.AsUInt64;
        // plugin.isEnabled = true
        void OnAfterSubscribe(PluginInfo plugin);
    }
}
