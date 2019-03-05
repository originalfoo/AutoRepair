using System.Collections.Generic;
using static ColossalFramework.Plugins.PluginManager;

namespace Incompatible.Replacements
{
    // determines which replaacement groups a user can select
    public enum Selection
    {
        Any,     // user can select one or more groups
        OnlyOne, // user can only select one group
        All,     // user must select all
    }

    interface IReplacement
    {
        // should the replacement always be shown?
        // * true = show if any deprecated mods are found
        // * false = show only if broken mods are found
        bool Always { get; }

        // If more than one replacement is defined, how can user select them?
        Selection Mode { get; }

        // In the following 3 properties, the 'byte' is used as a simple grouping
        // mechanism. Use bitwise operators to combine two or more groups. You will
        // have to use power of two numbers to denote the groups, for example:
        // 1, 2, 4, 8...

        // workshop id(s) of mod(s) to upgrade to
        Dictionary<ulong,byte> Replacements { get; }

        // some text to give user more info about the upgrade
        Dictionary<byte, string> Notes { get; }

        // workshop id(s) of mod(s) that will be replaced when upgrading
        // * broken mods will be unsubscribed
        // * non-broken mods can be merely disabled
        Dictionary<ulong,byte> Deprecates { get; }

        // Called before unsubbing a deprecated plugin
        // Tips:
        // * ulong workshopId = plugin.publishedFileID.AsUInt64;
        // * bool isEnabled = plugin.isEnabled
        // Note: The plugin will be automatically disabled after this method call
        void OnBeforeRemove(PluginInfo plugin);

        // Called after unsubbing a deprecated plugin
        void OnAfterRemove(PluginInfo plugin);

        // Called after subscribing a replacement plugin
        // Tip: plugin.isEnabled = true
        void OnAfterSubscribe(PluginInfo plugin);
    }
}
