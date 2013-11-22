namespace TextSelector {
    partial class FormTextSelector {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.openFileDialogText = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenTextFile = new System.Windows.Forms.Button();
            this.labelFileText = new System.Windows.Forms.Label();
            this.textBoxOpenTextFile = new System.Windows.Forms.TextBox();
            this.labelFileDictionary = new System.Windows.Forms.Label();
            this.textBoxDictionaryFile = new System.Windows.Forms.TextBox();
            this.buttonOpenDictionaryFile = new System.Windows.Forms.Button();
            this.openFileDialogDictionary = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogRes = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.labelSave = new System.Windows.Forms.Label();
            this.labelCountLines = new System.Windows.Forms.Label();
            this.numericUpDownCountLine = new System.Windows.Forms.NumericUpDown();
            this.labelProcessing = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelNameResfile = new System.Windows.Forms.Label();
            this.textBoxNameResFile = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountLine)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(303, 187);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(222, 187);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // openFileDialogText
            // 
            this.openFileDialogText.AddExtension = false;
            this.openFileDialogText.Filter = "Текстовые файлы|*.txt";
            this.openFileDialogText.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogText_FileOk);
            // 
            // buttonOpenTextFile
            // 
            this.buttonOpenTextFile.Location = new System.Drawing.Point(303, 12);
            this.buttonOpenTextFile.Name = "buttonOpenTextFile";
            this.buttonOpenTextFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenTextFile.TabIndex = 2;
            this.buttonOpenTextFile.Text = "Выбрать...";
            this.buttonOpenTextFile.UseVisualStyleBackColor = true;
            this.buttonOpenTextFile.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelFileText
            // 
            this.labelFileText.AutoSize = true;
            this.labelFileText.Location = new System.Drawing.Point(20, 17);
            this.labelFileText.Name = "labelFileText";
            this.labelFileText.Size = new System.Drawing.Size(76, 13);
            this.labelFileText.TabIndex = 3;
            this.labelFileText.Text = "Файл текста:";
            // 
            // textBoxOpenTextFile
            // 
            this.textBoxOpenTextFile.Location = new System.Drawing.Point(102, 13);
            this.textBoxOpenTextFile.Name = "textBoxOpenTextFile";
            this.textBoxOpenTextFile.Size = new System.Drawing.Size(195, 20);
            this.textBoxOpenTextFile.TabIndex = 4;
            // 
            // labelFileDictionary
            // 
            this.labelFileDictionary.AutoSize = true;
            this.labelFileDictionary.Location = new System.Drawing.Point(12, 46);
            this.labelFileDictionary.Name = "labelFileDictionary";
            this.labelFileDictionary.Size = new System.Drawing.Size(84, 13);
            this.labelFileDictionary.TabIndex = 5;
            this.labelFileDictionary.Text = "Файл словаря:";
            // 
            // textBoxDictionaryFile
            // 
            this.textBoxDictionaryFile.Location = new System.Drawing.Point(102, 43);
            this.textBoxDictionaryFile.Name = "textBoxDictionaryFile";
            this.textBoxDictionaryFile.Size = new System.Drawing.Size(195, 20);
            this.textBoxDictionaryFile.TabIndex = 6;
            // 
            // buttonOpenDictionaryFile
            // 
            this.buttonOpenDictionaryFile.Location = new System.Drawing.Point(303, 43);
            this.buttonOpenDictionaryFile.Name = "buttonOpenDictionaryFile";
            this.buttonOpenDictionaryFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenDictionaryFile.TabIndex = 7;
            this.buttonOpenDictionaryFile.Text = "Выбрать...";
            this.buttonOpenDictionaryFile.UseVisualStyleBackColor = true;
            this.buttonOpenDictionaryFile.Click += new System.EventHandler(this.buttonOpenDictionaryFile_Click);
            // 
            // openFileDialogDictionary
            // 
            this.openFileDialogDictionary.Filter = "Текстовые файлы|*.txt";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(303, 72);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Выбрать...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSave
            // 
            this.textBoxSave.Location = new System.Drawing.Point(102, 74);
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(195, 20);
            this.textBoxSave.TabIndex = 9;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Location = new System.Drawing.Point(24, 77);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(72, 13);
            this.labelSave.TabIndex = 10;
            this.labelSave.Text = "Сохранить в:";
            // 
            // labelCountLines
            // 
            this.labelCountLines.AutoSize = true;
            this.labelCountLines.Location = new System.Drawing.Point(84, 134);
            this.labelCountLines.Name = "labelCountLines";
            this.labelCountLines.Size = new System.Drawing.Size(145, 13);
            this.labelCountLines.TabIndex = 11;
            this.labelCountLines.Text = "Количество строк в файле:";
            // 
            // numericUpDownCountLine
            // 
            this.numericUpDownCountLine.Location = new System.Drawing.Point(235, 132);
            this.numericUpDownCountLine.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCountLine.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCountLine.Name = "numericUpDownCountLine";
            this.numericUpDownCountLine.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownCountLine.TabIndex = 13;
            this.numericUpDownCountLine.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelProcessing
            // 
            this.labelProcessing.AutoSize = true;
            this.labelProcessing.Location = new System.Drawing.Point(99, 192);
            this.labelProcessing.Name = "labelProcessing";
            this.labelProcessing.Size = new System.Drawing.Size(100, 13);
            this.labelProcessing.TabIndex = 14;
            this.labelProcessing.Text = "Идет обработка ...";
            this.labelProcessing.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelNameResfile
            // 
            this.labelNameResfile.AutoSize = true;
            this.labelNameResfile.Location = new System.Drawing.Point(29, 104);
            this.labelNameResfile.Name = "labelNameResfile";
            this.labelNameResfile.Size = new System.Drawing.Size(67, 13);
            this.labelNameResfile.TabIndex = 15;
            this.labelNameResfile.Text = "Имя файла:";
            // 
            // textBoxNameResFile
            // 
            this.textBoxNameResFile.Location = new System.Drawing.Point(102, 101);
            this.textBoxNameResFile.Name = "textBoxNameResFile";
            this.textBoxNameResFile.Size = new System.Drawing.Size(195, 20);
            this.textBoxNameResFile.TabIndex = 16;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 158);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(366, 17);
            this.progressBar.TabIndex = 17;
            // 
            // FormTestTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 222);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxNameResFile);
            this.Controls.Add(this.labelNameResfile);
            this.Controls.Add(this.labelProcessing);
            this.Controls.Add(this.numericUpDownCountLine);
            this.Controls.Add(this.labelCountLines);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.textBoxSave);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpenDictionaryFile);
            this.Controls.Add(this.textBoxDictionaryFile);
            this.Controls.Add(this.labelFileDictionary);
            this.Controls.Add(this.textBoxOpenTextFile);
            this.Controls.Add(this.labelFileText);
            this.Controls.Add(this.buttonOpenTextFile);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonCancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 260);
            this.MinimumSize = new System.Drawing.Size(406, 260);
            this.Name = "FormTestTask";
            this.Text = "Text Selector. Konkov Mikhail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.OpenFileDialog openFileDialogText;
        private System.Windows.Forms.Button buttonOpenTextFile;
        private System.Windows.Forms.Label labelFileText;
        private System.Windows.Forms.TextBox textBoxOpenTextFile;
        private System.Windows.Forms.Label labelFileDictionary;
        private System.Windows.Forms.TextBox textBoxDictionaryFile;
        private System.Windows.Forms.Button buttonOpenDictionaryFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogDictionary;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogRes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Label labelCountLines;
        private System.Windows.Forms.NumericUpDown numericUpDownCountLine;
        private System.Windows.Forms.Label labelProcessing;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelNameResfile;
        private System.Windows.Forms.TextBox textBoxNameResFile;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

