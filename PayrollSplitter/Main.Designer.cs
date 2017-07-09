namespace PayrollSplitter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.previewList = new System.Windows.Forms.ListBox();
            this.PreviewLabel3 = new System.Windows.Forms.Label();
            this.PreviewBtn = new System.Windows.Forms.Button();
            this.PreviewLabel2 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PreviewLabel1 = new System.Windows.Forms.Label();
            this.FinishLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChoosePDFBtn = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ChoosePDFBtn);
            this.groupBox1.Controls.Add(this.FilePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payroll";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.previewList);
            this.panel1.Controls.Add(this.PreviewLabel3);
            this.panel1.Controls.Add(this.PreviewBtn);
            this.panel1.Controls.Add(this.PreviewLabel2);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.PreviewLabel1);
            this.panel1.Controls.Add(this.FinishLbl);
            this.panel1.Location = new System.Drawing.Point(6, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 407);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "STEP 2: PREVIEW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "(Click on items in the list)";
            // 
            // previewList
            // 
            this.previewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewList.FormattingEnabled = true;
            this.previewList.ItemHeight = 22;
            this.previewList.Location = new System.Drawing.Point(3, 29);
            this.previewList.Margin = new System.Windows.Forms.Padding(4);
            this.previewList.Name = "previewList";
            this.previewList.Size = new System.Drawing.Size(249, 246);
            this.previewList.TabIndex = 4;
            this.previewList.SelectedIndexChanged += new System.EventHandler(this.previewList_SelectedIndexChanged);
            // 
            // PreviewLabel3
            // 
            this.PreviewLabel3.AutoSize = true;
            this.PreviewLabel3.Location = new System.Drawing.Point(260, 181);
            this.PreviewLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreviewLabel3.Name = "PreviewLabel3";
            this.PreviewLabel3.Size = new System.Drawing.Size(0, 17);
            this.PreviewLabel3.TabIndex = 14;
            // 
            // PreviewBtn
            // 
            this.PreviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewBtn.Location = new System.Drawing.Point(336, 41);
            this.PreviewBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PreviewBtn.Name = "PreviewBtn";
            this.PreviewBtn.Size = new System.Drawing.Size(130, 36);
            this.PreviewBtn.TabIndex = 8;
            this.PreviewBtn.Text = "Preview File";
            this.PreviewBtn.UseVisualStyleBackColor = true;
            this.PreviewBtn.Visible = false;
            this.PreviewBtn.Click += new System.EventHandler(this.PreviewBtn_Click);
            // 
            // PreviewLabel2
            // 
            this.PreviewLabel2.AutoSize = true;
            this.PreviewLabel2.Location = new System.Drawing.Point(260, 151);
            this.PreviewLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreviewLabel2.Name = "PreviewLabel2";
            this.PreviewLabel2.Size = new System.Drawing.Size(0, 17);
            this.PreviewLabel2.TabIndex = 13;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(8, 323);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(272, 69);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save All PDFs to Folder";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PreviewLabel1
            // 
            this.PreviewLabel1.AutoSize = true;
            this.PreviewLabel1.Location = new System.Drawing.Point(260, 120);
            this.PreviewLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreviewLabel1.Name = "PreviewLabel1";
            this.PreviewLabel1.Size = new System.Drawing.Size(0, 17);
            this.PreviewLabel1.TabIndex = 12;
            // 
            // FinishLbl
            // 
            this.FinishLbl.AutoSize = true;
            this.FinishLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishLbl.Location = new System.Drawing.Point(3, 294);
            this.FinishLbl.Name = "FinishLbl";
            this.FinishLbl.Size = new System.Drawing.Size(170, 25);
            this.FinishLbl.TabIndex = 11;
            this.FinishLbl.Text = "STEP 3: FINISH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "STEP 1: OPEN PAYSTUB FILE";
            // 
            // ChoosePDFBtn
            // 
            this.ChoosePDFBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosePDFBtn.Location = new System.Drawing.Point(415, 56);
            this.ChoosePDFBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChoosePDFBtn.Name = "ChoosePDFBtn";
            this.ChoosePDFBtn.Size = new System.Drawing.Size(150, 29);
            this.ChoosePDFBtn.TabIndex = 3;
            this.ChoosePDFBtn.Text = "Choose PDF";
            this.ChoosePDFBtn.UseVisualStyleBackColor = true;
            this.ChoosePDFBtn.Click += new System.EventHandler(this.ChoosePDFBtn_Click);
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(7, 61);
            this.FilePath.Margin = new System.Windows.Forms.Padding(4);
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(391, 22);
            this.FilePath.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SettingsBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(590, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 517);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
     
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.Location = new System.Drawing.Point(99, 164);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(203, 80);
            this.SettingsBtn.TabIndex = 1;
            this.SettingsBtn.Text = "Go to settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "to intelligently split your payroll file.";
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "in the settings. We use the employee settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make sure you have defined your employees";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PDF File|*.pdf";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Title";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FinishLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button PreviewBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox previewList;
        private System.Windows.Forms.Button ChoosePDFBtn;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label PreviewLabel3;
        private System.Windows.Forms.Label PreviewLabel2;
        private System.Windows.Forms.Label PreviewLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}