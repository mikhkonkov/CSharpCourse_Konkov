using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSelector {

    /// <summary>
    /// Класс для обработки строки
    /// </summary>
    class StringProcessing {
        private const string separators = " /\\\'\".,?!;%:*(){}[]|#@&^";
        private const string openTags = "<b><i>";
        private const string closeTags = "</i></b>";

        /// <summary>
        /// Обработка строки: поиск слова и выделение его тегами
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="dictionary">словарь</param>
        public void selectingWordsInLine(ref string str, Dictionary dictionary) {
            for (int i = 0; i < str.Length; i++) {
                if (separators.Contains(str[i]))
                    continue;
                int lengthCurWord = findLengthWord(str, i);
                string word = str.Substring(i, lengthCurWord);
                if (dictionary.Contains(word.ToLower())) {
                    word = selectingWord(word);
                    str = replacingWord(str, i, lengthCurWord, word);
                }
                i += word.Length;
            }
        }

        private string selectingWord(string word) {
            word = openTags + word + closeTags;
            return word;
        }

        private string replacingWord(string str, int startPos, int lengthOldWorld, string newWorld) {
            str = str.Remove(startPos, lengthOldWorld);
            str = str.Insert(startPos, newWorld);
            return str;
        }

        private int findLengthWord(string str, int indexStartWord) {
            int indexEndWord = str.IndexOfAny(separators.ToCharArray(), indexStartWord);
            int length = indexEndWord - indexStartWord;
            if (indexEndWord < indexStartWord) length = str.Length - indexStartWord;
            if (length < 0) length = 0;
            return length;
        }
    }
}
