using System;

partial class Student
{
    public string Name = "Ram";

    partial void DisplayMessage();

    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);
        DisplayMessage();
    }
}