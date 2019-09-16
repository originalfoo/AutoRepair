using System;

/// <summary>
/// Library of time-related tools.
/// </summary>
namespace AutoRepair.Util {
    public static class TimeTools {

        /// <summary>
        /// Get the current system time as formatted string.
        /// </summary>
        public static string Now => DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
    }
}
