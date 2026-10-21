using System;
class String
{
    static void Main(string[] args)
    {
        Console.Write("Enter a String: ");
        string str = Console.ReadLine();
        Console.WriteLine("The length of the string is: " + str.Length);
        Console.WriteLine("The string in uppercase is: " + str.ToUpper());
        Console.WriteLine("The string in lowercase is: " + str.ToLower());
        // Console
    }
}