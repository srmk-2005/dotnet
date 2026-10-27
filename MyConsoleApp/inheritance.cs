
using System;

class Person
{
    public string name = "Kumar";

    public void DisplayPerson()
    {
        Console.WriteLine("Name: " + name);
    }
}
class Staff : Person
{
    public string department = "CSE";

    public void DisplayStaff()
    {
        Console.WriteLine("Department: " + department);
    }
}
class Admin : Staff
{
    public string role = "Administrator";

    public void DisplayAdmin()
    {
        Console.WriteLine("Role: " + role);
    }
}
class inheritance
{
    static void Main()
    {
        Admin a = new Admin();
        a.DisplayPerson();
        a.DisplayStaff();
        a.DisplayAdmin();
    }
}
