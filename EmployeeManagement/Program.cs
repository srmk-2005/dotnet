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
        }
    }
}