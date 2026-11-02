
using System;

class Student
{
    public string Name = "Ram";

    // Nested class
    public class Address
    {
        public string City = "Chennai";
        public string State = "Tamil Nadu";

        public void DisplayAddress()
        {
            Console.WriteLine("City: " + City);
            Console.WriteLine("State: " + State);
        }
    }

    public void DisplayStudent()
    {
        Console.WriteLine("Student Name: " + Name);
    }
}

class P
{
    static void Main()
    {
        Student s = new Student();
        s.DisplayStudent();

        Student.Address a = new Student.Address();
        a.DisplayAddress();
    }
}
