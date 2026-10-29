
using System;

class Student
{
    public string Name;

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Uppercase: " + Name.ToUpper());
        Console.WriteLine("Lowercase: " + Name.ToLower());
        Console.WriteLine("Length: " + Name.Length);
        Console.WriteLine("Reversed: " + new string(Name.ToCharArray().Reverse().ToArray()));
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        Console.Write("Enter student name: ");
        s.Name = Console.ReadLine();

        s.Display();
    }
}
