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

        private void button2_Click(object sender, EventArgs e)
        {
            var employee = new Employee() { FirstName = Fname.Text, SurName = Sname.Text, Position = Enum.Parse<Position>(Position.Text), Salary = Convert.ToInt32(Salary.Text), YearOfBirth = Convert.ToInt32(Year.Text) };
            Context.CreateEmployee(employee);
            Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
