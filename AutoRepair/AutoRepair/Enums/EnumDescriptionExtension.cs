namespace AutoRepair.Enums {
    using System;
    using System.ComponentModel;
    using System.Reflection;

    public static class EnumDescriptionExtension {
        /// <summary>
        /// Retrieves text of Description attribute
        /// </summary>
        /// 
        /// <param name="value">Enum value which has Description attribute set.</param>
        /// 
        /// <returns>Text from Description attribute or Enum name if not present</returns>
        public static string GetDescription(this Enum value) {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null) {
                FieldInfo field = type.GetField(name);
                if (field != null) {
                    if (Attribute.GetCustomAttribute(field,
                            typeof(DescriptionAttribute)) is DescriptionAttribute attr) {
                        return attr.Description;
                    }
                }
            }
            return name;
        }
    }
}