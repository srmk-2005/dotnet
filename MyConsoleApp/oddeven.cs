using System;

class Oddeven
{
    static void Main()
    {
        int[,,] arr =
        {
            {
                { 1, 3, 5 },
                { 7, 9, 11 }
            },
            {
                { 2, 4, 6 },
                { 8, 10, 12 }
            }
        };

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Layer " + (i + 1));

            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(arr[i, j, k] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}