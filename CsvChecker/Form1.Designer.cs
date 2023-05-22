namespace CsvChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBoxFilePath = new TextBox();
            buttonCheckCsv = new Button();
            numericNbColumn = new NumericUpDown();
            labelNbColumn = new Label();
            labelFilePath = new Label();
            buttonAutodetectColumnNumber = new Button();
            dataGridView1 = new DataGridView();
            buttonExportInvalid = new Button();
            buttonExportClean = new Button();
            ((System.ComponentModel.ISupportInitialize)numericNbColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(841, 65);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Open File";
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(23, 68);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(790, 31);
            textBoxFilePath.TabIndex = 1;
            textBoxFilePath.Text = "C:\\Users\\JEROME\\Downloads\\creatio - Extraction Compte client\\creatio - Extraction Compte client.csv";
            // 
            // buttonCheckCsv
            // 
            buttonCheckCsv.Location = new Point(23, 197);
            buttonCheckCsv.Name = "buttonCheckCsv";
            buttonCheckCsv.Size = new Size(112, 34);
            buttonCheckCsv.TabIndex = 2;
            buttonCheckCsv.Text = "Check Csv";
            buttonCheckCsv.UseVisualStyleBackColor = true;
            buttonCheckCsv.Click += buttonCheckCsv_Click;
            // 
            // numericNbColumn
            // 
            numericNbColumn.Location = new Point(160, 125);
            numericNbColumn.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericNbColumn.Name = "numericNbColumn";
            numericNbColumn.Size = new Size(131, 31);
            numericNbColumn.TabIndex = 3;
            // 
            // labelNbColumn
            // 
            labelNbColumn.AutoSize = true;
            labelNbColumn.Location = new Point(19, 125);
            labelNbColumn.Name = "labelNbColumn";
            labelNbColumn.Size = new Size(112, 25);
            labelNbColumn.TabIndex = 4;
            labelNbColumn.Text = "Nb colonnes";
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Location = new Point(23, 40);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(197, 25);
            labelFilePath.TabIndex = 5;
            labelFilePath.Text = "Emplacement du fichier";
            // 
            // buttonAutodetectColumnNumber
            // 
            buttonAutodetectColumnNumber.Location = new Point(316, 123);
            buttonAutodetectColumnNumber.Name = "buttonAutodetectColumnNumber";
            buttonAutodetectColumnNumber.Size = new Size(157, 34);
            buttonAutodetectColumnNumber.TabIndex = 6;
            buttonAutodetectColumnNumber.Text = "Auto-Detect";
            buttonAutodetectColumnNumber.UseVisualStyleBackColor = true;
            buttonAutodetectColumnNumber.Click += buttonAutodetectColumnNumber_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1163, 392);
            dataGridView1.TabIndex = 7;
            // 
            // buttonExportInvalid
            // 
            buttonExportInvalid.Location = new Point(379, 197);
            buttonExportInvalid.Name = "buttonExportInvalid";
            buttonExportInvalid.Size = new Size(254, 34);
            buttonExportInvalid.TabIndex = 8;
            buttonExportInvalid.Text = "Exporter les invalides";
            buttonExportInvalid.UseVisualStyleBackColor = true;
            buttonExportInvalid.Click += buttonExport_Click;
            // 
            // buttonExportClean
            // 
            buttonExportClean.Location = new Point(679, 197);
            buttonExportClean.Name = "buttonExportClean";
            buttonExportClean.Size = new Size(254, 34);
            buttonExportClean.TabIndex = 9;
            buttonExportClean.Text = "Exporter Clean";
            buttonExportClean.UseVisualStyleBackColor = true;
            buttonExportClean.Click += buttonExportClean_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 641);
            Controls.Add(buttonExportClean);
            Controls.Add(buttonExportInvalid);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAutodetectColumnNumber);
            Controls.Add(labelFilePath);
            Controls.Add(labelNbColumn);
            Controls.Add(numericNbColumn);
            Controls.Add(buttonCheckCsv);
            Controls.Add(textBoxFilePath);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericNbColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBoxFilePath;
        private Button buttonCheckCsv;
        private NumericUpDown numericNbColumn;
        private Label labelNbColumn;
        private Label labelFilePath;
        private Button buttonAutodetectColumnNumber;
        private DataGridView dataGridView1;
        private Button buttonExportInvalid;
        private Button buttonExportClean;
    }
}