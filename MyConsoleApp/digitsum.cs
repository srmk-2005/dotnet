using System;
class Digit
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to calculate the sum of its digits: ");
        int number=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        while (number != 0)
        {
            sum+=number%10;
            number/=10;
        }
        Console.WriteLine("The sum of the digits is: " + sum);
    }
}