namespace AutoRepair.Util {
    using System.Diagnostics;
    using System.IO;
    using UnityEngine;

    public class Log {
        public static readonly string LogFileName = "AutoRepair.log";

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
                Log.Info($"[Log.ctor] {TimeTools.Now}");
            } catch { }
        }

        [Conditional("DEBUG")]
        public static void Debug(string message, bool copyToGameLog = false) {
            LogToFile(message, LogLevel.Debug);
            if (copyToGameLog) {
                UnityEngine.Debug.Log(message);
            }
        }

        public static void Info(string message, bool copyToGameLog = false) {
            LogToFile(message, LogLevel.Info);
            if (copyToGameLog) {
                UnityEngine.Debug.Log(message);
            }
        }

        public static void Error(string message, bool copyToGameLog = true) {
            LogToFile(message, LogLevel.Error);
            if (copyToGameLog) {
                UnityEngine.Debug.LogError(message);
            }
        }

        private static void LogToFile(string log, LogLevel level) {
            try {
                using (StreamWriter w = File.AppendText(LogFilePath)) {
                    w.Write("{0, -9}", $"[{level.ToString()}] @");
                    w.Write("{0, 15}", sw.ElapsedTicks + " | ");
                    w.WriteLine(log);
                    if (level == LogLevel.Error) {
                        w.WriteLine(new StackTrace().ToString());
                        w.WriteLine();
                    }
                }
            } catch { }
        }
    }
}