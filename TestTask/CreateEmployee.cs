using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestTask.Models;
using TestTask.Persistence;

namespace TestTask
{
    public partial class CreateEmployee : Form
    {
        public DbContext Context = new DbContext();
        public CreateEmployee()
        {
            InitializeComponent();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    var employee = new Employee() { FirstName = Fname.Text, SurName = Sname.Text, Position = Enum.Parse<Position>(Position.Text), Salary = Convert.ToInt32(Salary.Text), YearOfBirth = Convert.ToInt32(Year.Text) };
        //    Context.CreateEmployee(employee);
        //    Close();
        //}

        //private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //}

        private void btCreateForm_Click(object sender, EventArgs e)
        {
            try
            {
                CheckErrors();
                var employee = new Employee() { FirstName = Fname.Text, SurName = Sname.Text, Position = Enum.Parse<Position>(Position.Text), Salary = Convert.ToInt32(Salary.Text), YearOfBirth = Convert.ToInt32(Year.Text) };
                Context.CreateEmployee(employee);
                Close();
            }
            catch(Exception ex)
            {
                labelErrors.Text = String.Concat(ex.Message);
            }
        }
        private void CheckErrors()
        {
            if (String.IsNullOrEmpty(Fname.Text) || String.IsNullOrEmpty(Sname.Text) || String.IsNullOrEmpty(Position.Text) || String.IsNullOrEmpty(Salary.Text) || String.IsNullOrEmpty(Year.Text))
                throw new Exception("All values are required");

            if (Convert.ToInt32(Salary.Text) < 0)
                throw new Exception("Salary must be > 0");

            if (Convert.ToInt32(Year.Text) > 2008 || Convert.ToInt32(Year.Text) < 1923)
                throw new Exception("Date birth year must be more than\n" +
                    " 2008(15 years) and less than 1923(100 years)");

        }

        private void btCloseForm_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
