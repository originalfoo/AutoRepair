namespace AutoRepair.Attributes {
    using System;

    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    sealed class ConfigurableOptionAttribute : Attribute {
        public ConfigurableOptionAttribute(string group, string description) {
            Group = group;
            Description = description;
        }
        public string Group { get; private set; }
        public string Description { get; private set; }
    }
}