using AutoRepair.Catalogs;
using AutoRepair.Storage;
using AutoRepair.Structs;
using AutoRepair.Util;
using ColossalFramework.PlatformServices;
using ICities;
using System;
using static ColossalFramework.Plugins.PluginManager;

namespace AutoRepair.Manager {
    public static class SubscriptionsManager {

        /// <summary>
        /// Converts a workshop id in to a <see cref="PublishedFileId"/> struct.
        /// </summary>
        /// 
        /// <param name="workshopId">The workshop id to convert.</param>
        /// 
        /// <returns>Returns a <c>PublishedFileId</c> struct representation of the <paramref name="workshopId"/>.</returns>
        public static PublishedFileId GetPublishedFileId(ulong workshopId) => new PublishedFileId(workshopId);

        /// <summary>
        /// Local mods have a workshop ID of <see cref="ulong.MaxValue"/>.
        /// </summary>
        public static readonly ulong LocalModWorkshopId = ulong.MaxValue;

        /// <summary>
        /// Returns the name of a mod by inspecting its <see cref="IUserMod.Name"/> property.
        /// If that can't be found, it defaults to the <see cref="PluginInfo.name"/> instead.
        /// 
        /// Note: The <see cref="PluginInfo.name"/> is not acutally the "name" you expect, it is either
        /// the workshop id, as a string, or the assembly/project name of the mod.
        /// </summary>
        /// 
        /// <param name="pluginInfo">The <see cref="PluginInfo"/> reference to the mod.</param>
        /// 
        /// <returns>Returns the name of the mod.</returns>
        public static string GetModName(PluginInfo pluginInfo) {
            string name = pluginInfo.name;
            try {
                IUserMod[] instances = pluginInfo.GetInstances<IUserMod>();
                if ((int)instances.Length > 0) {
                    name = instances[0].Name;
                }
            }
            catch (Exception e) {
                Log.Error($"ERROR [SubscriptionsManager.GetModName] {e.Message}");
            }
            return name;
        }

        public static bool IsSubscribed(ItemDetails item) {
            if (Vanilla.IsVanilla(item.WorkshopId)) {
                return true;
            }
            // TODO
            return false;
        }

        public static bool Subscribe(PublishedFileId item, bool enable = true, string name = "") { // why tf is string.Empty not a compile time constant *sigh*
            Archive.Instance.BeingSubscribed.Add(new ArchiveEntry {
                Name = name,
                WorkshopId = item.AsUInt64,
                Enabled = enable
            });
            Archive.Instance.Save();
            Audit.Add($"[SubscriptionsManager.Subscribe] Subscribing {item.AsUInt64} '{name}'");
            return PlatformService.workshop.Subscribe(item);
        }

        public static bool Subscribe(ulong workshopId, bool enable = true, string name = "") =>
            Subscribe(GetPublishedFileId(workshopId), enable, name);

        public static bool Subscribe(ItemDetails item, bool enable = true) =>
            Subscribe(GetPublishedFileId(item.WorkshopId), enable, item.WorkshopName);

        public static void OpenWorkshopPageFor(ItemDetails item) {

            // Can't find any direct way to subscribe, so user will have to do it manually.
            // We can, however, send them to the workshop page (:

            if (PlatformService.IsOverlayEnabled()) {
                PlatformService.ActivateGameOverlayToWorkshopItem(GetPublishedFileId(item.WorkshopId));
            } else {
                // TODO: Work out how to send them to steam website instead
            }

        }
    }
}
