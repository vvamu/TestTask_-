﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SurName { get; set; }
        public Position? Position { get; set; }
        public int? YearOfBirth { get; set; }
        public int? Salary { get; set; }
    }
}
