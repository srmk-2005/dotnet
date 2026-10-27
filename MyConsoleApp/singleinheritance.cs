
using System;

class Person
{
    public string name = "Ram";
    public int age = 21;

    public void DisplayPerson()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Student : Person
{
    public int rollNo = 101;

    public void DisplayStudent()
    {
        Console.WriteLine("Roll Number: " + rollNo);
    }
}

class singleInheritance
{
    static void Main()
    {
        Student s = new Student();

        s.DisplayPerson();
        s.DisplayStudent();
    }
}
