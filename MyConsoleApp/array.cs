using System;
class Arra
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the elements of the array:");
        // int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The elements of the array are:");
        int[] arr1 = new int[size];
        Array.Copy(arr, arr1, size);
        arr[0] = 100;
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine(string.Join(" ", arr1));
        Console.WriteLine(arr.GetUpperBound(0));
    }
}