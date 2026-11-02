using System;

enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Schedule
{
    public void DisplayDay()
    {
        WeekDays day = WeekDays.Wednesday;

        Console.WriteLine("Day: " + day);
        Console.WriteLine("Day Number: " + ((int)day + 1));
    }
}

class Program
{
    static void Main()
    {
        Schedule s = new Schedule();
        s.DisplayDay();
    }
}