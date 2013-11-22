using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TextSelector {

    /// <summary>
    /// Класс содержащий словарь
    /// </summary>
    class Dictionary {

        private HashSet<string> dictionary = new HashSet<string>();

        /// <summary>
        /// Загрузка словаря
        /// </summary>
        /// <param name="pathDictionaryFile">Путь к словарю</param>
        /// <returns></returns>
        public Dictionary(string pathDictionaryFile, string encoding) {
            var content = getFileContent(pathDictionaryFile, encoding);
            foreach (string str in content) {
                var word = str.ToLower().Trim();
                if (word == "")
                    continue;
                dictionary.Add(word);
            }
        }

        /// <summary>
        /// Определяет входит ли слово в словарь
        /// </summary>
        /// <param name="word">Слово</param>
        /// <returns></returns>
        public bool Contains(string word) {
            return dictionary.Contains(word);
        }

        /// <summary>
        /// Возвращает число элементов, которые содержатся в словаре.
        /// </summary>
        /// <returns></returns>
        public int Count() {
            return dictionary.Count;
        }

        private IEnumerable<string> getFileContent(string fileName, string encoding) {
            Stream stream = null;
            try {
                stream = File.OpenRead(fileName);
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            if (stream == null) yield break;
            using (var reader = new StreamReader(stream, Encoding.GetEncoding(encoding))) {
                while (true) {
                    var line = reader.ReadLine();
                    if (line == null) {
                        yield break;
                    }
                    yield return line;
                }
            }
        }
    }
}
