using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TextSelector {
    public partial class FormTextSelector : Form {

        private Thread thread;
        private FileProcessing fp = new FileProcessing();

        public FormTextSelector() {
            InitializeComponent();
            thread = new Thread(startProcessing);
        }

        private void startProcessing(object n) {
            progressBar.BeginInvoke((MethodInvoker)delegate() {
                this.progressBar.Maximum = fp.getCountLinesInText(textBoxOpenTextFile.Text);
            });
            fp.setDirResFiles(textBoxSave.Text);
            if (textBoxNameResFile.Text != "") {
                fp.setNameResFile(textBoxNameResFile.Text);
            }
            fp.processInputFile(textBoxOpenTextFile.Text, textBoxDictionaryFile.Text, (int)n);
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            if (thread != null) 
                thread.Abort();
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e) {
            if (thread != null)
                thread.Abort();
        }

        private bool isEmptyBoxes() {
            return (textBoxOpenTextFile.Text.Trim() == ""
                || textBoxDictionaryFile.Text.Trim() == ""
                || textBoxSave.Text.Trim() == "");
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            if (isEmptyBoxes()) {
                MessageBox.Show("Выберите все файлы и путь для сохранения!");
                return;
            }
            if (thread != null)
                if (thread.IsAlive)
                    return;
            thread = new Thread(startProcessing);
            thread.Start((int)numericUpDownCountLine.Value);
        }

        private void buttonOpen_Click(object sender, EventArgs e) {
            openFileDialogText.ShowDialog();
            textBoxOpenTextFile.Text = openFileDialogText.FileName;
        }

        private void openFileDialogText_FileOk(object sender, CancelEventArgs e) {
        }

        private void buttonOpenDictionaryFile_Click(object sender, EventArgs e) {
            openFileDialogDictionary.ShowDialog();
            textBoxDictionaryFile.Text = openFileDialogDictionary.FileName;
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            folderBrowserDialogRes.ShowDialog();
            textBoxSave.Text = folderBrowserDialogRes.SelectedPath;
        }

        private void update() {
            if (thread == null) return;
            labelProcessing.Visible = thread.IsAlive;
            buttonCancel.Enabled = thread.IsAlive;
            buttonStart.Enabled = !thread.IsAlive;
            progressBar.Value = fp.getCurNumberLine();
        }

        private void timer_Tick(object sender, EventArgs e) {
            update();
        }
    }
}
