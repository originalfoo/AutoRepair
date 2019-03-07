using System.Collections.Generic;
using static ColossalFramework.Plugins.PluginManager;

namespace ModFreshener.Replacements
{
    // determines which replaacement groups a user can select
    public enum Select
    {
        Any,     // user can select one or more groups
        OnlyOne, // user can only select one group
        All,     // user must select all
    }

    interface IReplacement
    {
        // Should we always recommend the upgrade?
        // * true = show if any of deprecated mods are installed
        // * false = show only if broken mods are installed
        bool Mandatory { get; }

        // If more than one replacement is defined, how can user select them?
        Select Choice { get; }

        // In the following 4 properties, the 'byte' is used as a simple grouping
        // mechanism. Use bitwise operators to combine two or more groups. You will
        // have to use power of two numbers to denote the groups, for example:
        // 1, 2, 4, 8...

        // workshop id(s) of mod(s) to upgrade to
        Dictionary<ulong,byte> Option { get; }

        // some text to give user more info about the upgrade
        Dictionary<byte, string> Note { get; }

        // deprecated mods that must be disabled but can optionally be removed
        Dictionary<ulong,byte> Deprecated { get; }

        // obsolete mods that must be removed
        Dictionary<ulong,byte> Obsolete { get; }

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
