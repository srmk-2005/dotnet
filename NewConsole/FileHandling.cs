using System;
using System.IO;

class DemoFilehandle
{
    public static void Main()
    {
        string path = @"C:\Users\Ramamuthukumaran s\OneDrive\Desktop\projects\ups\NewConsole\demo.txt";

        // Create and write to file
        FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
        StreamWriter sw = new StreamWriter(file);

        sw.WriteLine("This is the first line of C# File Handling.");
        sw.WriteLine("Welcome to C#.");

        sw.Close();
        file.Close();

        // Append additional content
        FileStream fs2 = new FileStream(path, FileMode.Append, FileAccess.Write);
        StreamWriter stream = new StreamWriter(fs2);

        stream.WriteLine("How can I help you?");
        stream.WriteLine("Thank you!");

        stream.Close();
        fs2.Close();
    }
}