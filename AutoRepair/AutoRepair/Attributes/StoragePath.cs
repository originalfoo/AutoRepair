using System;

namespace AutoRepair.Attributes {
    [AttributeUsage(AttributeTargets.Class)]
    public class StoragePathAttribute : Attribute {
        public StoragePathAttribute(string value) {
            Value = value;
        }

        public string Value { get; private set; }
    }
}
