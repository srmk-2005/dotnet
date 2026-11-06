using System;
using System.IO;

class Files
{
    static void Main()
    {
        string path = @"C:\Users\Ramamuthukumaran s\OneDrive\Desktop\projects\ups\NewConsole\students.txt";

        FileStream file = new FileStream(
            path, FileMode.Create, FileAccess.Write);

        StreamWriter sw = new StreamWriter(file);

        string choice = "yes";

        while (choice.ToLower() == "yes")
        {
            Console.Write("Enter Register Number: ");
            string regNo = Console.ReadLine();

            Console.Write("Enter Maths Mark: ");
            int maths = int.Parse(Console.ReadLine());

            Console.Write("Enter Physics Mark: ");
            int physics = int.Parse(Console.ReadLine());

            Console.Write("Enter Chemistry Mark: ");
            int chemistry = int.Parse(Console.ReadLine());

            sw.WriteLine($"{regNo},{maths},{physics},{chemistry}");

            Console.Write("Do you want to add another student? (yes/no): ");
            choice = Console.ReadLine();
        }

        sw.Close();
        file.Close();

        Console.WriteLine("Student details saved successfully!");
    }
}