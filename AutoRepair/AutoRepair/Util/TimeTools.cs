/// <summary>
/// Library of time-related tools.
/// </summary>
namespace AutoRepair.Util {
    using System;
    public static class TimeTools {

        /// <summary>
        /// Get the current system time as formatted string.
        /// </summary>
        public static string Now => DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
    }
}
