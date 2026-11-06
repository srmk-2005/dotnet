using System;
using System.IO;

class DemoFileRead
{
    public static void Main()
    {
        string path = @"C:\Users\Ramamuthukumaran s\OneDrive\Desktop\projects\ups\NewConsole\demo.txt";

        FileStream file = new FileStream(
            path, FileMode.Open, FileAccess.Read);

        StreamReader sr = new StreamReader(file);

        string line;

        while ((line = sr.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        sr.Close();
        file.Close();
    }
}