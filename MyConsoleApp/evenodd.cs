using System;
class evenodd
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        List<int> arr = new List<int>();
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr.Add(Convert.ToInt32(Console.ReadLine()));
        }
        // Console.WriteLine("The even numbers in the array are: ");
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();
        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 == 0)
            {
                evenNumbers.Add(arr[i]);
            }
            else
            {
                oddNumbers.Add(arr[i]);
            }
        }
        Console.WriteLine("\nThe odd numbers in the array are: ");
        foreach (int num in oddNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine("\nThe even numbers in the array are: ");
        foreach (int num in evenNumbers)
        {
            Console.Write(num + " ");
        }
    }
}