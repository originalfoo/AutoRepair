using System.Collections.Generic;

namespace AutoRepair.Dependencies
{
    public static class Dependencies
    {
        // Note: Mod dependencies can include other types of workshop assets (eg. MOM requires Metropolitan Depot building)

        public static Dictionary<ulong, ulong[]> list = new Dictionary<ulong, ulong[]>()
        {
            // Surface Painter: Extra Landscaping Tools
            { 689937287, new ulong[]{ 502750307 } },

            // Prop Snapping: Prop & Tree Anarchy, Prop Precision
            { 787611845, new ulong[]{ 593588108, 791221322 } },

            // Ploppable Asphalt+: Find It!, Asphalt props, Pavement props, Grass props, Gravel props, Cliff props
            { 881291183, new ulong[]{ 1619685021, 1258123334, 1258124059, 1258125733, 1258124638, 1258125191 } },

            // More Flags (+ Flag Replacer): Find It, Prefab Hook
            { 595017353, new ulong[]{ 1619685021, 530771650 } },

            // Find It: Prop Precision, Prop Snapping
            { 1619685021, new ulong[]{ 791221322, 787611845 } },

            // MOM: Train & Tain Stations Converter, Metropolitan Depot, Advanced Stop Selection, Transport Line Rendering Fix
            { 81626043, new ulong[]{ 795514116, 816325876, 1394468624, 714056356 } },

            // Train & Train Stations Converter: Prefab Hook
            { 795514116, new ulong[]{ 530771650 } },

            // More Network Stuff: Prefab Hook
            { 512314255, new ulong[]{ 530771650 } },

            // Softer Shadows: Daylight Classic
            { 643364914, new ulong[]{ 530871278 } },

            // Relight: Ultimate Eye Candy, Shadow Strength Adjuster
            // See also: /Conflicts/Relight.cs
            { 1209581656, new ulong[]{ 672248733, 762520291 } }
        };
    }
}