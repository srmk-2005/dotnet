using System;
class Factorial
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a non-negative integer to calculate its factorial:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            long result = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is {result}.");
        }
    }
    public static long CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * CalculateFactorial(n - 1);
        }
    }
}