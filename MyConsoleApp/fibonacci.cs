using System;
class Fibonacci
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of terms for fibonacci series: ");
        int terms=Convert.ToInt32(Console.ReadLine());
        int first=0;
        int second=1;
        int next;
        Console.WriteLine("Fibonacci series: ");
        Console.WriteLine(first);
        Console.WriteLine(second);
        int i=2;
        while (i<terms)
        {
            next=first+second;
            Console.WriteLine(next);
            first=second;
            second=next;
            i++;
        }
    }
}