using System;
class Star
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows ");
        int r=Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= r; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*"+" ");
            }
            Console.WriteLine();
        }
    }
}