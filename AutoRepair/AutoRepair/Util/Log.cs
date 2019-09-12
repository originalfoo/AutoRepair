namespace AutoRepair.Util {
    using System;
    using System.Diagnostics;
    using System.IO;
    using UnityEngine;

    public class Log {
        public static readonly string LogFileName = "ModFreshener.log";

        private enum LogLevel {
            Debug,
            Info,
            Error
        }

        private static readonly string LogFilePath = Path.Combine(Application.dataPath, LogFileName);
        private static readonly Stopwatch sw = Stopwatch.StartNew();

        static Log() {
            try {
                if (File.Exists(LogFilePath)) {
                    File.Delete(LogFilePath);
                }
            }
            catch (Exception) {
            }
        }

        [Conditional("DEBUG")]
        public static void _Debug(string s) {
            LogToFile(s, LogLevel.Debug);
        }

        public static void Info(string s) {
            LogToFile(s, LogLevel.Info);
        }

        public static void Error(string s) {
            LogToFile(s, LogLevel.Error);
        }

        private static void LogToFile(string log, LogLevel level) {
            using (StreamWriter w = File.AppendText(LogFilePath)) {
                w.Write("{0, -9}", $"[{level.ToString()}] @");
                w.Write("{0, 15}", sw.ElapsedTicks + " | ");
                w.WriteLine(log);
                if (level == LogLevel.Error) {
                    w.WriteLine(new StackTrace().ToString());
                    w.WriteLine();
                }
            }
        }
    }
}