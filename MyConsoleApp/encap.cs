
using System;

class Student
{
    private int rollNo;
    private string name;
    private double marks;

    public int RollNo
    {
        get { return rollNo; }
        set
        {
            if (value > 0)
                rollNo = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
        }
    }

    public double Marks
    {
        get { return marks; }
        set
        {
            if (value >= 0 && value <= 100)
                marks = value;
        }
    }

    public void Display()
    {
        Console.WriteLine("Roll Number: " + RollNo);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Marks: " + Marks);
    }
}

class encap
{
    static void Main()
    {
        Student s = new Student();

        s.RollNo = 101;
        s.Name = "Ram";
        s.Marks = 95;

        s.Display();
    }
}
