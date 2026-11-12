using Linq.Datas;
using Linq.Model;
using System;
using System.Linq;

namespace CIT
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var employees = DataProvider.GetEmployees();
            var managers = DataProvider.GetManagers();
            Console.WriteLine("-------- Method Syntax --------");
            var result = employees.Where(e => e.Dept == "IT");
            foreach (var emp in result)
            {
                Console.WriteLine(
                    $"Id: {emp.Id}, Name: {emp.Name}, Dept: {emp.Dept}"
                );
            }
            Console.WriteLine("\n-------- Query Syntax --------");
            var result1 = from e in employees
                          where e.Salary > 40000
                          select e;
            foreach (var emp in result1)
            {
                Console.WriteLine(
                    $"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}"
                );
            }

            Console.WriteLine("\n-------- Anonymous Type --------");

            var result2 = employees
                .Where(e => e.Experience > 3)
                .Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Dept,
                    e.Age,
                    e.Salary,
                    e.Experience
                });

            foreach (var emp in result2)
            {
                Console.WriteLine(
                    $"Id: {emp.Id}, Name: {emp.Name}, Dept: {emp.Dept}, Age: {emp.Age}, Salary: {emp.Salary}, Experience: {emp.Experience}"
                );
            }
            var result3 = employees.ElementAtOrDefault(2);
            Console.WriteLine("\n-------- ElementAt --------");
            Console.WriteLine(
                $"Id: {result3.Id}, Name: {result3.Name}, Dept: {result3.Dept}, Age: {result3.Age}, Salary: {result3.Salary}, Experience: {result3.Experience}"
            );
            if (result3 == null)
            {
                Console.WriteLine("No employee found at index 7.");
            }
            bool result4 = employees.Any(e => e.Dept == "Finance");
            Console.WriteLine("\n-------- Any --------");
            Console.WriteLine($"Any employees in Finance department: {result4}");
            Console.WriteLine("\n-------- FirstOrDefault --------");
            // if (result4 != null)
            // {
            //     Console.WriteLine(
            //         $"Id: {result4.Id}, Name: {result4.Name}, Dept: {result4.Dept}, Age: {result4.Age}, Salary: {result4.Salary}, Experience: {result4.Experience}"
            //     );
            // }
            // else
            // {
            //     Console.WriteLine("No employee found in Finance department.");
            // }
            var result5 = employees.GroupBy(e => e.Dept);
            Console.WriteLine("\n-------- GroupBy --------");
            foreach (var g in result5)
            {
                Console.WriteLine($"Department: {g.Key}");
                foreach (var emp in g)
                {
                    Console.WriteLine(
                        $"Id: {emp.Id}, Name: {emp.Name}, Dept: {emp.Dept}, Age: {emp.Age}, Salary: {emp.Salary}, Experience: {emp.Experience}"
                    );
                }
            }
            var result6 = employees.Join(managers, employee => employee.Dept, managers => managers.dept, (employee, managers) => new
            {
                EmployeeName = employee.Name,
                ManagerName = managers.name,
                Department = employee.Dept
            });
            Console.WriteLine("\n-------- Join --------");
            foreach (var item in result6)
            {
                Console.WriteLine(
                    $"Employee Name: {item.EmployeeName}, Manager Name: {item.ManagerName}, Department: {item.Department}"
                );
            }
            Console.WriteLine("\n----------ToList----------");
            var result7 = employees.Where(e => e.Age > 25).ToList();
            Console.WriteLine(result7.Count);
            foreach (var emp in result7)
            {
                Console.WriteLine(
                    $"Id: {emp.Id}, Name: {emp.Name}, Dept: {emp.Dept}, Age: {emp.Age}, Salary: {emp.Salary}, Experience: {emp.Experience}"
                );
            }
            Console.WriteLine("\n----------ToDictionary----------");
            var result8 = employees.ToDictionary(e => e.Id, e => e.Name);
            foreach (var emp in result8)
            {
                Console.WriteLine($"Id: {emp.Key}, Name: {emp.Value}");
            }
        }
    }
}