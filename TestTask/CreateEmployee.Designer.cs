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
            label1 = new Label();
            Fname = new TextBox();
            Sname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Year = new TextBox();
            label4 = new Label();
            Salary = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            Position = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // Fname
            // 
            Fname.Location = new Point(12, 83);
            Fname.Name = "Fname";
            Fname.Size = new Size(125, 27);
            Fname.TabIndex = 1;
            // 
            // Sname
            // 
            Sname.Location = new Point(153, 83);
            Sname.Name = "Sname";
            Sname.Size = new Size(125, 27);
            Sname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 28);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 28);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Должность";
            // 
            // Year
            // 
            Year.Location = new Point(428, 83);
            Year.Name = "Year";
            Year.Size = new Size(125, 27);
            Year.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 28);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 6;
            label4.Text = "Год рождения";
            // 
            // Salary
            // 
            Salary.Location = new Point(572, 83);
            Salary.Name = "Salary";
            Salary.Size = new Size(125, 27);
            Salary.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(580, 28);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 8;
            label5.Text = "Зарплата (в $)";
            // 
            // button1
            // 
            button1.Location = new Point(211, 144);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(357, 144);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Создать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Position
            // 
            Position.FormattingEnabled = true;
            Position.Items.AddRange(new object[] { "Junior", "SuperJunior", "Senior", "SEO" });
            Position.Location = new Point(284, 82);
            Position.Name = "Position";
            Position.Size = new Size(138, 28);
            Position.TabIndex = 12;
            // 
            // CreateEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 194);
            Controls.Add(Position);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Salary);
            Controls.Add(label5);
            Controls.Add(Year);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Sname);
            Controls.Add(label2);
            Controls.Add(Fname);
            Controls.Add(label1);
            Name = "CreateEmployee";
            Text = "CreateEmployee";
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
        private Button button2;
        private ComboBox Position;
    }
}