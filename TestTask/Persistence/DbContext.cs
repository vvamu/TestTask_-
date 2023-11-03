using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Persistence
{
    public class DbContext
    {
        private static string _connection = "Server=localhost;Database=TestDB;Trusted_Connection=True;TrustServerCertificate=True";
        private static SqlConnection _dbConnection;
        public DbContext()
        {
            _dbConnection = new SqlConnection(_connection);
            _dbConnection.Open();
        }
        public void CreateEmployee(Employee model)
        {
            var id = new Random().Next();
            var createCommand = _dbConnection.CreateCommand();
            createCommand.CommandText = $"insert into Employees (Firstname, Lastname, Salary, Position, YearOfBirth)" +
                $" values('{model.FirstName}','{model.SurName}',{model.Salary},'{model.Position}',{model.YearOfBirth});";
            createCommand.ExecuteNonQuery();
        }
        public void DeleteEmployee(int id)
        {
            var deleteCommand = _dbConnection.CreateCommand();
            deleteCommand.CommandText = $"delete from Employees where id = {id}";
            deleteCommand.ExecuteNonQuery();
        }
        public List<Employee> GetAllEmployees()
        {
            var getCommand = _dbConnection.CreateCommand();
            getCommand.CommandText = $"select * from Employees";
            var reader = getCommand.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    employees.Add(new Employee()
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        SurName = reader.GetString(2),
                        Salary = reader.GetInt32(3),
                        Position = Enum.Parse<Position>(reader.GetString(4)),
                        YearOfBirth = reader.GetInt32(5),
                    });
                }
            }
            reader.Close();
            return employees;
        }
    }
}
