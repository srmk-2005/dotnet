/*
 * StringBuilder Example
 */
using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");

        sb.Append(" World");
        Console.WriteLine("Append: " + sb);
        sb.Insert(5, " C#");
        Console.WriteLine("Insert: " + sb);

        sb.Replace("World", "Student");
        Console.WriteLine("Replace: " + sb);

        sb.Remove(5, 3);
        Console.WriteLine("Remove: " + sb);

        Console.WriteLine("Length: " + sb.Length);

        string result = sb.ToString();
        Console.WriteLine("Final String: " + result);
    }
}
/*
collections
generic collections
constructors
methods
fields
properties
scheme
*/

