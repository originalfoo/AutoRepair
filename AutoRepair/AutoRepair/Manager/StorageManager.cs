using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using AutoRepair.Util;

/// <summary>
/// Persistence manager for options. Based on code in Keallu' "Hide It!" mod.
/// </summary>
namespace AutoRepair.Manager {
    public abstract class StorageManager<C> where C : class, new() {
        private static C instance;

        public static C Load() {
            if (instance == null) {
                var configPath = GetConfigPath();
                Log.Info($"[StorageManager.Load] {configPath}");
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(C));

                try {
                    if (File.Exists(configPath)) {
                        using (StreamReader streamReader = new StreamReader(configPath)) {
                            instance = xmlSerializer.Deserialize(streamReader) as C;
                        }
                    }
                }
                catch (Exception e) {
                    Log.Error("[StorageManager.Load] Error: " + e.Message);
                }
            }
            return instance ?? (instance = new C());
        }

        public static void Save() {
            if (instance == null) return;

            string configPath = GetConfigPath();
            Log.Info($"[StorageManager.Save] {configPath}");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(C));
            XmlSerializerNamespaces noNamespaces = new XmlSerializerNamespaces();
            noNamespaces.Add("", "");

            try {
                using (StreamWriter streamWriter = new StreamWriter(configPath)) {
                    xmlSerializer.Serialize(streamWriter, instance, noNamespaces);
                }
            }
            catch (Exception e) {
                Log.Error("[StorageManager.Save] Error: " + e.Message);
            }
        }

        private static string GetConfigPath() {
            if (typeof(C).GetCustomAttributes(typeof(StoragePathAttribute), true)
                .FirstOrDefault() is StoragePathAttribute configPathAttribute) {
                //Log.Info($"[OptionsManager.GetConfigPath] {configPathAttribute.Value}");
                return configPathAttribute.Value;
            } else {
                Log.Error($"[StorageManager.GetConfigPath] StoragePath attribute missing, defaulting to: {typeof(C).Name}.xml");
                return typeof(C).Name + ".xml";
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class StoragePathAttribute : Attribute {
        public StoragePathAttribute(string value) {
            Value = value;
        }

        public string Value { get; private set; }
    }
}
