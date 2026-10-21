using System;

class ThreeDArray
{
    static void Main(String[] args) 
    {
        int[,,] arr =
        {
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            },
            {
                { 13, 14, 15, 16 },
                { 17, 18, 19, 20 },
                { 21, 22, 23, 24 }
            },
            {
                { 25, 26, 27, 28 },
                { 29, 30, 31, 32 },
                { 33, 34, 35, 36 }
            }
        };

        int sums = 0;
        int maxs = int.MinValue;
        int mins = int.MaxValue;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    int val = arr[i, j, k];

                    sums += val;

                    if (val > maxs)
                        maxs = val;

                    if (val < mins)
                        mins = val;
                }
            }
        }

        Console.WriteLine($"Sum: {sums}");
        Console.WriteLine($"Maximum: {maxs}");
        Console.WriteLine($"Minimum: {mins}");
    }
}