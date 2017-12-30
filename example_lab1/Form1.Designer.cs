namespace example_lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxSPBFilePath = new System.Windows.Forms.TextBox();
            this.ButSearchSPB = new System.Windows.Forms.Button();
            this.ButLoadSData = new System.Windows.Forms.Button();
            this.ButMakeReport = new System.Windows.Forms.Button();
            this.ButSaveReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.DialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.DialogSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxSPBFilePath
            // 
            this.TextBoxSPBFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSPBFilePath.Location = new System.Drawing.Point(12, 12);
            this.TextBoxSPBFilePath.Name = "TextBoxSPBFilePath";
            this.TextBoxSPBFilePath.Size = new System.Drawing.Size(735, 20);
            this.TextBoxSPBFilePath.TabIndex = 0;
            // 
            // ButSearchSPB
            // 
            this.ButSearchSPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButSearchSPB.Location = new System.Drawing.Point(753, 12);
            this.ButSearchSPB.Name = "ButSearchSPB";
            this.ButSearchSPB.Size = new System.Drawing.Size(106, 23);
            this.ButSearchSPB.TabIndex = 1;
            this.ButSearchSPB.Text = "Выбор СПБ...";
            this.ButSearchSPB.UseVisualStyleBackColor = true;
            this.ButSearchSPB.Click += new System.EventHandler(this.ButSearchSPB_Click);
            // 
            // ButLoadSData
            // 
            this.ButLoadSData.Location = new System.Drawing.Point(12, 38);
            this.ButLoadSData.Name = "ButLoadSData";
            this.ButLoadSData.Size = new System.Drawing.Size(112, 23);
            this.ButLoadSData.TabIndex = 2;
            this.ButLoadSData.Text = "Загрузка СПБ";
            this.ButLoadSData.UseVisualStyleBackColor = true;
            this.ButLoadSData.Click += new System.EventHandler(this.ButLoadSData_Click);
            // 
            // ButMakeReport
            // 
            this.ButMakeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButMakeReport.Location = new System.Drawing.Point(550, 38);
            this.ButMakeReport.Name = "ButMakeReport";
            this.ButMakeReport.Size = new System.Drawing.Size(151, 23);
            this.ButMakeReport.TabIndex = 3;
            this.ButMakeReport.Text = "Сформировать отчет";
            this.ButMakeReport.UseVisualStyleBackColor = true;
            this.ButMakeReport.Click += new System.EventHandler(this.ButMakeReport_Click);
            // 
            // ButSaveReport
            // 
            this.ButSaveReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButSaveReport.Location = new System.Drawing.Point(707, 38);
            this.ButSaveReport.Name = "ButSaveReport";
            this.ButSaveReport.Size = new System.Drawing.Size(152, 23);
            this.ButSaveReport.TabIndex = 4;
            this.ButSaveReport.Text = "Сохранить отчет в файл";
            this.ButSaveReport.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox_info);
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 462);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчет:";
            // 
            // textBox_info
            // 
            this.textBox_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_info.Location = new System.Drawing.Point(547, 19);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(294, 437);
            this.textBox_info.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(6, 19);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(535, 433);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // DialogOpenFile
            // 
            this.DialogOpenFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButSaveReport);
            this.Controls.Add(this.ButMakeReport);
            this.Controls.Add(this.ButLoadSData);
            this.Controls.Add(this.ButSearchSPB);
            this.Controls.Add(this.TextBoxSPBFilePath);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSPBFilePath;
        private System.Windows.Forms.Button ButSearchSPB;
        private System.Windows.Forms.Button ButLoadSData;
        private System.Windows.Forms.Button ButMakeReport;
        private System.Windows.Forms.Button ButSaveReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog DialogOpenFile;
        private System.Windows.Forms.SaveFileDialog DialogSaveFile;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox_info;
    }
}

