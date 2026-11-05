using System;
class Bank
{
    public event
}
class Program
{
    static void Main()
    {
        Func<int, int, int> square = (n, m) => n * m;
        Console.WriteLine(square(5, 3));
        Predicate<int> isevn = n => n % 2 != 0;
        Console.WriteLine(isevn(5));
    }
}