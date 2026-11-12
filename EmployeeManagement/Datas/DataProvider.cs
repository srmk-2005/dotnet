using Linq.Model;
using System.Collections.Generic;

namespace Linq.Datas
{
    public static class DataProvider
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee { Id = 101, Name = "Ram", Dept = "IT", Age = 22, Salary = 35000, Experience = 2 },

                new Employee { Id = 102, Name = "Arun", Dept = "HR", Age = 25, Salary = 45000, Experience = 4 },

                new Employee { Id = 103, Name = "Kumar", Dept = "IT", Age = 28, Salary = 60000, Experience = 6 },

                new Employee { Id = 104, Name = "Priya", Dept = "Finance", Age = 24, Salary = 30000, Experience = 1 },

                new Employee { Id = 105, Name = "Divya", Dept = "HR", Age = 27, Salary = 55000, Experience = 5 },

                new Employee { Id = 106, Name = "Sanjay", Dept = "IT", Age = 30, Salary = 75000, Experience = 8 }
                
            };
        }
        public static List<Manager> GetManagers()
        {
            return new List<Manager>()
            {
                new Manager { id = 201, name = "Ramesh", dept = "IT", age = 35 },

                new Manager { id = 202, name = "Suresh", dept = "HR", age = 40 },

                new Manager { id = 203, name = "Anita", dept = "Finance", age = 38 }
            };
        }
    }
}