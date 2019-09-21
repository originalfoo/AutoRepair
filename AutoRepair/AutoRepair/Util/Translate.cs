namespace AutoRepair.Util {
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using ColossalFramework.Globalization;
    using Storage;

    public class Translate {
        /// <summary>
        /// The current language used for translations.
        /// </summary>
        private string CurrentLanguage { get; set; }

        /// <summary>
        /// Language -> Key -> Translation
        /// </summary>
        internal Dictionary<string, Dictionary<string, string>> Translations;

        public Translate(string resourceName) {
            Log.Info("[Translate.ctor] Instantiating.");
            Load(resourceName);
            CurrentLanguage = GetCurrentLanguage();
        }

        /// <summary>
        /// Get current language from mod options.
        ///
        /// If game language, work out what that is.
        ///
        /// Make sure language is in <see cref="Config.Languages"/>; if not default to <see cref="Config.DEFAULT_LANGUAGE"/>.
        /// </summary>
        /// <returns>A language that's supported by the mod.</returns>
        public string GetCurrentLanguage() {
            string lang = Options.Instance.Language;

            if (string.IsNullOrEmpty(lang) || lang == "game") {
                lang = LocaleManager.instance.language;
            }

            if (!Config.Languages.ContainsKey(lang)) {
                Log.Info($"[GetCurrentLanguage] Requested language not avialable: '{lang}'");
                lang = Config.DEFAULT_LANGUAGE;
            }

            Log.Info($"[Translate.GetCurrentLanguage] '{lang}' selected.");
            return lang;
        }

        public string Get(string key) => Get(CurrentLanguage, key);

        [SuppressMessage("Style", "IDE0018:Inline variable declaration", Justification = "Would require two variables to be defined which seems counter-productive.")]
        public string Get(string lang, string key) {
            string translation;

            // Try find translation in the current language first
            if (Translations[lang].TryGetValue(key, out translation)) {
                return translation;
            }

            // If not found, try also get translation in the default English
            // Untranslated keys are prefixed with ¶
            return Translations[Config.DEFAULT_LANGUAGE].TryGetValue(key, out translation)
                ? translation
                : "¶" + key;
        }

        public bool HasString(string key) => Translations[CurrentLanguage].ContainsKey(key);

        private void Load(string resourceName) {
            Log.Info($"[Translate.Load] {resourceName}.csv");

            Translations = new Dictionary<string, Dictionary<string, string>>();

            // Load file in to lines[]
            string filename = $"{Config.RESOURCES_PREFIX}{resourceName}.csv";

            string[] lines;
            using (Stream st = Assembly.GetExecutingAssembly()
                                       .GetManifestResourceStream(filename)) {
                using (var sr = new StreamReader(st, Encoding.UTF8)) {
                    lines = sr
                        .ReadToEnd()
                        .Split(new[] { "\n", "\r\n" }, StringSplitOptions.None);
                }
            }

            // First line is language column headings
            string firstLine = lines[0];
            List<string> langCodes = new List<string>();
            using (var sr = new StringReader(firstLine)) {
                ReadCsvCell(sr); // skip first empty cell
                while (true) {
                    string langCode = ReadCsvCell(sr);
                    if (langCode.Length == 0) {
                        break;
                    }

                    // add to temporary list
                    langCodes.Add(langCode);

                    // add to main languages dictionary if missing
                    if (!Config.Languages.ContainsKey(langCode)) {
                        Config.Languages.Add(langCode, langCode);
                    }

                    // create translations dictionary for this language
                    Translations[langCode] = new Dictionary<string, string>();
                }
            }

            // first col = translation key, remaining cols = translations in languages as per langCodes list
            foreach (string line in lines.Skip(1)) {
                using (var sr = new StringReader(line)) {
                    string key = ReadCsvCell(sr);
                    if (key.Length == 0) {
                        break; // last line is empty
                    }
                    foreach (string lang in langCodes) {
                        string cell = ReadCsvCell(sr);

                        // empty strings for non-default language are skipped
                        if (string.IsNullOrEmpty(cell) && lang != Config.DEFAULT_LANGUAGE) {
                            continue;
                        }
                        Translations[lang][key] = cell;
                    }
                }
            }

            Log.Info($"[Translate.Load] {Translations.Count} langauge(s) loaded.");
        }

        /// <summary>
        /// Given a stringReader, read a CSV cell which can be a string until next comma, or quoted
        /// string (in this case double quotes are decoded to a quote character) and respects
        /// newlines \n too.
        /// </summary>
        /// <param name="sr">Source for reading CSV</param>
        /// <returns>Cell contents</returns>
        private static string ReadCsvCell(StringReader sr) {
            var sb = new StringBuilder();
            if (sr.Peek() == '"') {
                sr.Read(); // skip the leading \"

                // The cell begins with a \" character, special reading rules apply
                while (true) {
                    int next = sr.Read();
                    if (next == -1) {
                        break; // end of the line
                    }

                    switch (next) {
                        case '\\': {
                            int special = sr.Read();
                            if (special == 'n') {
                                // Recognized a new line
                                sb.Append("\n");
                            } else {
                                // Not recognized, append as is
                                sb.Append("\\");
                                sb.Append((char)special, 1);
                            }

                            break;
                        }
                        case '\"': {
                            // Found a '""', or a '",'
                            int peek = sr.Peek();
                            switch (peek) {
                                case '\"': {
                                    sr.Read(); // consume the double quote
                                    sb.Append("\"");
                                    break;
                                }
                                case ',':
                                case -1: {
                                    // Followed by a comma or end-of-string
                                    sr.Read(); // Consume the comma
                                    return sb.ToString();
                                }
                                default: {
                                    // Followed by a non-comma, non-end-of-string
                                    sb.Append("\"");
                                    break;
                                }
                            }
                            break;
                        }
                        default: {
                            sb.Append((char)next, 1);
                            break;
                        }
                    }
                }
            } else {
                // Simple reading rules apply, read to the next comma or end-of-string
                while (true) {
                    int next = sr.Read();
                    if (next == -1 || next == ',') {
                        break; // end-of-string or a comma
                    }

                    sb.Append((char)next, 1);
                }
            }

            return sb.ToString();
        }
    } // end class
}
