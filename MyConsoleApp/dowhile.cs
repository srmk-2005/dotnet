using System;

class Dowhile
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("1. Pizza");
            Console.WriteLine("2. Burger");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Pizza");
                    break;
                case 2:
                    Console.WriteLine("You selected Burger");
                    break;
                default:
                    if (choice != 3)
                        Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 3);

        Console.WriteLine("Thank you!");
    }
}