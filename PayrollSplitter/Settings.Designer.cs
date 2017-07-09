namespace PayrollSplitter
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.EmployeeList = new System.Windows.Forms.ListBox();
            this.EditGroup = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UniqueIdTxt = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EditGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeList
            // 
            this.EmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeList.FormattingEnabled = true;
            this.EmployeeList.ItemHeight = 22;
            this.EmployeeList.Location = new System.Drawing.Point(12, 98);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(230, 268);
            this.EmployeeList.TabIndex = 0;
            this.EmployeeList.SelectedIndexChanged += new System.EventHandler(this.EmployeeList_SelectedIndexChanged);
            // 
            // EditGroup
            // 
            this.EditGroup.Controls.Add(this.Save);
            this.EditGroup.Controls.Add(this.Delete);
            this.EditGroup.Controls.Add(this.tableLayoutPanel1);
            this.EditGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditGroup.Location = new System.Drawing.Point(248, 98);
            this.EditGroup.Name = "EditGroup";
            this.EditGroup.Size = new System.Drawing.Size(398, 276);
            this.EditGroup.TabIndex = 1;
            this.EditGroup.TabStop = false;
            this.EditGroup.Text = "Edit";
            this.EditGroup.Visible = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Save.Location = new System.Drawing.Point(247, 200);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(145, 70);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delete.Location = new System.Drawing.Point(12, 200);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(145, 70);
            this.Delete.TabIndex = 2;
            this.Delete.TabStop = false;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.80981F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.19019F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NameTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmailTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTxt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UniqueIdTxt, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 164);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unique ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(145, 3);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(201, 30);
            this.NameTxt.TabIndex = 1;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(145, 44);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(201, 30);
            this.EmailTxt.TabIndex = 2;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(145, 85);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(201, 30);
            this.PasswordTxt.TabIndex = 3;
            // 
            // UniqueIdTxt
            // 
            this.UniqueIdTxt.Location = new System.Drawing.Point(145, 126);
            this.UniqueIdTxt.Name = "UniqueIdTxt";
            this.UniqueIdTxt.Size = new System.Drawing.Size(201, 30);
            this.UniqueIdTxt.TabIndex = 4;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(12, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(230, 44);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add New Employee";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Employees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "*Unique ID is used to identify a specific employee\'s paystub";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 386);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditGroup);
            this.Controls.Add(this.EmployeeList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.EditGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeeList;
        private System.Windows.Forms.GroupBox EditGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UniqueIdTxt;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}