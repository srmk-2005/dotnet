
using System;

abstract class Employee
{
    public string Name;
    public int Id;

    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Employee Name: " + Name);
    }

    public abstract double CalculateSalary();
}

class FullTimeEmployee : Employee
{
    public double MonthlySalary;

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }
}

class PartTimeEmployee : Employee
{
    public int HoursWorked;
    public double HourlyRate;

    public override double CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }
}

class abstracts
{
    static void Main()
    {
        FullTimeEmployee e1 = new FullTimeEmployee();
        e1.Id = 101;
        e1.Name = "Ram";
        e1.MonthlySalary = 50000;

        PartTimeEmployee e2 = new PartTimeEmployee();
        e2.Id = 102;
        e2.Name = "Kumar";
        e2.HoursWorked = 80;
        e2.HourlyRate = 200;

        Console.WriteLine("--- Full-Time Employee ---");
        e1.DisplayDetails();
        Console.WriteLine("Salary: " + e1.CalculateSalary());

        Console.WriteLine("\n--- Part-Time Employee ---");
        e2.DisplayDetails();
        Console.WriteLine("Salary: " + e2.CalculateSalary());
    }
}
