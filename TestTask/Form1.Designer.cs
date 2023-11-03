using TestTask.Models;

namespace TestTask
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            employeeBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            Filter = new ComboBox();
            FilterText = new Label();
            RefreshBtn = new Button();
            employeeBindingSource1 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            positionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, surNameDataGridViewTextBoxColumn, positionDataGridViewTextBoxColumn, yearOfBirthDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn });
            dataGridView1.DataSource = employeeBindingSource;
            dataGridView1.Location = new Point(12, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(805, 311);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Employee);
            // 
            // button1
            // 
            button1.Location = new Point(837, 114);
            button1.Name = "button1";
            button1.Size = new Size(141, 50);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(837, 205);
            button2.Name = "button2";
            button2.Size = new Size(141, 50);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Filter
            // 
            Filter.FormattingEnabled = true;
            Filter.Items.AddRange(new object[] { "All", "Junior", "SuperJunior", "Senior", "SEO" });
            Filter.Location = new Point(154, 31);
            Filter.Name = "Filter";
            Filter.Size = new Size(151, 28);
            Filter.TabIndex = 3;
            Filter.SelectedIndexChanged += Filter_SelectedIndexChanged;
            Filter.SelectionChangeCommitted += Filter_SelectionChangeCommitted;
            // 
            // FilterText
            // 
            FilterText.AutoSize = true;
            FilterText.Location = new Point(47, 34);
            FilterText.Name = "FilterText";
            FilterText.Size = new Size(42, 20);
            FilterText.TabIndex = 4;
            FilterText.Text = "Filter";
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(385, 36);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(94, 29);
            RefreshBtn.TabIndex = 5;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // employeeBindingSource1
            // 
            employeeBindingSource1.DataSource = typeof(Employee);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
            surNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            surNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            positionDataGridViewTextBoxColumn.HeaderText = "Position";
            positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearOfBirthDataGridViewTextBoxColumn
            // 
            yearOfBirthDataGridViewTextBoxColumn.DataPropertyName = "YearOfBirth";
            yearOfBirthDataGridViewTextBoxColumn.HeaderText = "YearOfBirth";
            yearOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            yearOfBirthDataGridViewTextBoxColumn.Name = "yearOfBirthDataGridViewTextBoxColumn";
            yearOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 450);
            Controls.Add(RefreshBtn);
            Controls.Add(FilterText);
            Controls.Add(Filter);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private BindingSource employeeBindingSource;
        private Button button2;
        private ComboBox Filter;
        private Label FilterText;
        private Button RefreshBtn;
        private BindingSource employeeBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    }
}