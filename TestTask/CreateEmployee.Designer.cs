namespace TestTask
{
    partial class CreateEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Sname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCloseForm = new System.Windows.Forms.Button();
            this.btCreateForm = new System.Windows.Forms.Button();
            this.Position = new System.Windows.Forms.ComboBox();
            this.labelErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(12, 83);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(125, 27);
            this.Fname.TabIndex = 1;
            // 
            // Sname
            // 
            this.Sname.Location = new System.Drawing.Point(153, 83);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(125, 27);
            this.Sname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Должность";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(428, 83);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(125, 27);
            this.Year.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Год рождения";
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(572, 83);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(125, 27);
            this.Salary.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Зарплата (в $)";
            // 
            // btCloseForm
            // 
            this.btCloseForm.Location = new System.Drawing.Point(12, 144);
            this.btCloseForm.Name = "btCloseForm";
            this.btCloseForm.Size = new System.Drawing.Size(94, 29);
            this.btCloseForm.TabIndex = 10;
            this.btCloseForm.Text = "Отмена";
            this.btCloseForm.UseVisualStyleBackColor = true;
            this.btCloseForm.Click += new System.EventHandler(this.btCloseForm_Click);
            // 
            // btCreateForm
            // 
            this.btCreateForm.Location = new System.Drawing.Point(112, 145);
            this.btCreateForm.Name = "btCreateForm";
            this.btCreateForm.Size = new System.Drawing.Size(94, 29);
            this.btCreateForm.TabIndex = 11;
            this.btCreateForm.Text = "Создать";
            this.btCreateForm.UseVisualStyleBackColor = true;
            this.btCreateForm.Click += new System.EventHandler(this.btCreateForm_Click);
            // 
            // Position
            // 
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "Junior",
            "SuperJunior",
            "Senior",
            "SEO"});
            this.Position.Location = new System.Drawing.Point(284, 82);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(138, 28);
            this.Position.TabIndex = 12;
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelErrors.Location = new System.Drawing.Point(212, 149);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 20);
            this.labelErrors.TabIndex = 13;
            // 
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 194);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.btCreateForm);
            this.Controls.Add(this.btCloseForm);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label1);
            this.Name = "CreateEmployee";
            this.Text = "CreateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Fname;
        private TextBox Sname;
        private Label label2;
        private Label label3;
        private TextBox Year;
        private Label label4;
        private TextBox Salary;
        private Label label5;
        private Button btCloseForm;
        private Button btCreateForm;
        private ComboBox Position;
        private Label labelErrors;
    }
}