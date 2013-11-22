using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSelector {

    /// <summary>
    /// Класс обработки файлов
    /// </summary>
    class FileProcessing {

        private string prefixNameResFile = "res";
        private string dirResFiles = "";
        private const string fileExtension = ".html";
        private const string encoding = "windows-1251";
        private int countLineInInputFile = 0;

        /// <summary>
        /// Обработка текстового файла
        /// </summary>
        /// <param name="pathInputFile">Путь к входному файлу</param>
        /// <param name="pathDictionaryFile">Путь к словарю</param>
        /// <param name="n">Количество строк в результирующем файле, 
        /// если оно превышается, то запись продолжается в следующий файл</param>
        public void processInputFile(string pathInputFile, string pathDictionaryFile, int n) {
            int countOutFiles = 0;
            countLineInInputFile = 0;
            var dictionary = new Dictionary(pathDictionaryFile, encoding);
            if (dictionary.Count() == 0) {
                MessageBox.Show("Словарь пуст или не найден!");
                return;
            }
            try {
                using (var st = new StreamReader(pathInputFile, Encoding.GetEncoding(encoding))) {
                    var writer = openWriterOfResFile(getNameResFile(countOutFiles));
                    var countLineInOutputFile = 0;
                    StringProcessing sp = new StringProcessing();
                    while (true) {
                        var line = st.ReadLine();
                        if (line == null)
                            break;
                        sp.selectingWordsInLine(ref line, dictionary);
                        countLineInInputFile++;
                        if (isEndFile(countLineInOutputFile, n, line)) {
                            countLineInOutputFile = 1;
                            countOutFiles++;
                            divisionIntoFiles(ref writer, line, countOutFiles);
                            continue;
                        }
                        line = addLineBreak(line);
                        writer.WriteLine(line);
                        countLineInOutputFile++;
                    }
                    closeWriterOfResFile(ref writer);
                }
                MessageBox.Show("Обработка завершена!");
                countLineInInputFile = 0;
            } catch (Exception e) {
                countLineInInputFile = 0;
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// получение номера текущей обрабатываемой строки
        /// </summary>
        /// <returns></returns>
        public int getCurNumberLine() {
            return countLineInInputFile;
        }

        /// <summary>
        /// Получение количества строк в исходном файле
        /// </summary>
        /// <param name="pathInputFile">Путь к входному файлу</param>
        /// <returns></returns>
        public int getCountLinesInText(string pathInputFile) {
            int count = 0;
            try {
                using (var st = new StreamReader(pathInputFile, Encoding.GetEncoding(encoding))) {
                    while (true) {
                        var line = st.ReadLine();
                        if (line == null)
                            break;
                        count++;
                    }
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            return count;
        }

        /// <summary>
        /// Установка пути для сохранения файлов
        /// </summary>
        /// <param name="dir">путь к каталогу</param>
        public void setDirResFiles(string dir) {
            dirResFiles = dir + "\\";
        }

        /// <summary>
        /// установка имени файлов
        /// </summary>
        /// <param name="name">Имя</param>
        public void setNameResFile(string name) {
            prefixNameResFile = name;
        }

        private bool isEndFile(int curNumberLine, int n, string line) {
            return (curNumberLine >= (n - 1)) && ((line.Contains('.')) || (line.Contains('!')) || (line.Contains('?')));
        }

        private string getNameResFile(int numberCurFile) {
            string strNumber = "";
            if (numberCurFile != 0)
                strNumber = (numberCurFile + 1).ToString(); ;
            return dirResFiles + prefixNameResFile + strNumber + fileExtension;
        }

        private void divisionIntoFiles(ref StreamWriter writer, string line, int countOutFiles) {
            var sentenceBeforeDot = getSentenceBeforeDot(line);
            writer.Write(sentenceBeforeDot);
            closeWriterOfResFile(ref writer);
            writer = openWriterOfResFile(getNameResFile(countOutFiles));
            var sentenceAfterDot = getSentenceAfterDot(line);
            sentenceAfterDot = addLineBreak(sentenceAfterDot);
            writer.WriteLine(sentenceAfterDot);
        }

        private string getSentenceBeforeDot(string line) {
            int indexDot = findLastIndexDot(line);
            var sentence = line.Substring(0, indexDot + 1);
            return sentence;
        }

        private string getSentenceAfterDot(string line) {
            int indexDot = findLastIndexDot(line);
            var sentence = line.Substring(indexDot + 1, line.Length - indexDot - 1);
            return sentence;
        }

        private StreamWriter openWriterOfResFile(string nameFile) {
            var stream = new StreamWriter(nameFile, false, Encoding.GetEncoding(encoding));
            writeFirstPartOfFile(stream);
            return stream;
        }

        private void closeWriterOfResFile(ref StreamWriter stream) {
            writeLastPartOfFile(stream);
            stream.Close();
        }

        private string addLineBreak(string line) {
            return line + "</br>";
        }

        private void writeFirstPartOfFile(StreamWriter sw) {
            sw.Write("<html><head></head><body><p>");
        }

        private void writeLastPartOfFile(StreamWriter sw) {
            sw.Write("</p></body></html>");
        }

        private int findLastIndexDot(string str) {
            char[] seporators = { '.', '!', '?' };
            return str.LastIndexOfAny(seporators);
        }
    }
}
