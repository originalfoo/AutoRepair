/// <summary>
/// Persistence manager for options. Based on code in Keallu' "Hide It!" mod.
/// </summary>

namespace AutoRepair.Manager {
    using System;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;
    using AutoRepair.Util;

    public abstract class OptionsManager<C> where C : class, new() {
        private static C instance;

        public static C Load() {
            if (instance == null) {
                Log.Info("[OptionsManager.Load] Loading options.");
                var configPath = GetConfigPath();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(C));

                try {
                    if (File.Exists(configPath)) {
                        using (StreamReader streamReader = new StreamReader(configPath)) {
                            instance = xmlSerializer.Deserialize(streamReader) as C;
                        }
                    }
                }
                catch (Exception e) {
                    Log.Error("[OptionsManager.Load] Error: " + e.Message);
                }
            }
            return instance ?? (instance = new C());
        }

        public static void Save() {
            if (instance == null) return;
            Log.Info("[OptionsManager.Save] Saving options.");

            string configPath = GetConfigPath();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(C));
            XmlSerializerNamespaces noNamespaces = new XmlSerializerNamespaces();
            noNamespaces.Add("", "");

            try {
                using (StreamWriter streamWriter = new StreamWriter(configPath)) {
                    xmlSerializer.Serialize(streamWriter, instance, noNamespaces);
                }
            }
            catch (Exception e) {
                Log.Error("[OptionsManager.Save] Error: " + e.Message);
            }
        }

        private static string GetConfigPath() {
            if (typeof(C).GetCustomAttributes(typeof(OptionsPathAttribute), true)
                .FirstOrDefault() is OptionsPathAttribute configPathAttribute) {
                Log.Info($"[OptionsManager.GetConfigPath] {configPathAttribute.Value}");
                return configPathAttribute.Value;
            } else {
                Log.Error($"[OptionsManager.GetConfigPath] OptionsPath attribute missing: {typeof(C).Name}");
                return typeof(C).Name + ".xml";
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class OptionsPathAttribute : Attribute {
        public OptionsPathAttribute(string value) {
            Value = value;
        }

        public string Value { get; private set; }
    }
}
