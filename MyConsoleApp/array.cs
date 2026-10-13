using System;
class Array
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the elements of the array:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        // for (int i = 0; i < size; i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }
        Console.WriteLine("The elements of the array are:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i]+" ");
        }
        // Console.WriteLine();
    }
}