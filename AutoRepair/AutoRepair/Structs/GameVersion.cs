using System;

namespace AutoRepair.Structs {
    /// <summary>
    /// Used for game version tracking in Options and VersionTools.
    ///
    /// Less cruft than <see cref="System.Version"/> and it's only used rarely so not worried about performance.
    /// </summary>
    
    public struct GameVersion : IEquatable<GameVersion> {
        public uint Major;
        public uint Minor;

        public override string ToString() => $"{Major}.{Minor}";
        public override int GetHashCode() => ToString().GetHashCode();
        public bool Equals(GameVersion other) => Minor == other.Minor && Major == other.Major;
    }
}
