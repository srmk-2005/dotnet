using System;

class NestedFor
{
    static void Main()
    {
        int[,] arr = new int[3, 4];

        for (int i = 0; i < 3; i++)
        {
            int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < 4; j++)
            {
                arr[i, j] = row[j];
                // Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        int sums = 0;
        int maxs = 0;
        int mins = int.MaxValue;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                // val=arr[i,j];
                if (arr[i, j] > maxs)
                {
                    maxs = arr[i, j];
                }
                if (arr[i, j] < mins)
                {
                    mins = arr[i, j];
                }
                sums += arr[i, j];
            }
        }
        Console.WriteLine($"The sum of all elements in the array is: {sums}");
        Console.WriteLine($"The maximum value in the array is: {maxs}");
        Console.WriteLine($"The minimum value in the array is: {mins}");
    }
}