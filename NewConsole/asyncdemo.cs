using System;
using System.Threading;
using System.Threading.Tasks;

class FoodOrder
{
    public static async Task PrepareFood(CancellationToken token)
    {
        for (int progress = 0; progress <= 100; progress += 20)
        {
            token.ThrowIfCancellationRequested();

            Console.WriteLine($"Food preparation: {progress}%");

            await Task.Delay(2000, token);
        }

        Console.WriteLine("Food prepared successfully!");
    }

    public static async Task Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();

        Console.WriteLine("Food preparation started!");
        Console.WriteLine("Press C to cancel.");

        Task key = Task.Run(() =>
        {
            while (!cts.IsCancellationRequested)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.C)
                    {
                        cts.Cancel();
                        break;
                    }
                }
            }
        });

        try
        {
            await PrepareFood(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Food preparation cancelled!");
        }
        finally
        {
            cts.Cancel();
            cts.Dispose();
        }

        await key;

        Console.WriteLine("Process completed!");
    }
}