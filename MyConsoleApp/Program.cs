using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the UPS Eligibility Checker!");
        Console.Write("Enter your 12th marks:");
        double marks_12th = Convert.ToDouble(Console.ReadLine());
        if (marks_12th >= 85)
        {
            Console.Write("Enter your 10th mark: ");
            double marks_10th = Convert.ToDouble(Console.ReadLine());
            if (marks_10th >= 85)
            {
                Console.Write("Enter your CGPA: ");
                double cgpa = Convert.ToDouble(Console.ReadLine());
                if (cgpa >= 8.5)
                {
                    Console.WriteLine("You are eligible for UPS.");
                }
                else
                {
                    Console.WriteLine("You are not eligible for UPS.");
                }
            }
            else
            {
                Console.WriteLine("You are not eligible for UPS.");
            }
        }
        else
        {
            Console.WriteLine("You are not eligible for UPS.");
        }

    }
}