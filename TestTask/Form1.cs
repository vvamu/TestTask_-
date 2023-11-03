using System.Data;
using TestTask.Models;
using TestTask.Persistence;

namespace TestTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Employee> Employees = new List<Employee>();
        public DataTable Table;
        public DbContext Context = new DbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            Employees = Context.GetAllEmployees();
            employeeBindingSource.DataSource = Employees;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var createForm = new CreateEmployee();
            createForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    var id = Convert.ToInt32(row.Cells[0].Value);
                    Context.DeleteEmployee(id);
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
        }
        private void RefreshTable()
        {
            FilterTable();
        }
        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FilterTable();
        }
        private void FilterTable()
        {
            var filterText = Filter.SelectedItem.ToString();
            if (filterText == "All")
            {
                employeeBindingSource.DataSource = Context.GetAllEmployees();
            }
            else
            {
                employeeBindingSource.DataSource = Context.GetAllEmployees()
                    .Where(e => e.Position == Enum.Parse<Position>(Filter.SelectedItem.ToString()))
                    .ToList();
            }
        }

        private void Filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterTable();
        }
    }
}