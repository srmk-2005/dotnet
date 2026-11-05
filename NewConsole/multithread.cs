class Multithread
{
    public void testing1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Testing1: " + i);
            // Thread.Sleep(1000);
        }
    }
    public void testing2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Testing2: " + i);
            // Thread.Sleep(1000);
        }
    }
    public void testing3()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Testing3: " + i);
            // Thread.Sleep(1000);
        }
    }
}
class MultithreadDemo
{
    public static void Main()
    {
        Multithread mt = new Multithread();
        Console.WriteLine("Main thread started");
        Thread t1 = new Thread(mt.testing1);
        Thread t2 = new Thread(mt.testing2);
        Thread t3 = new Thread(mt.testing3);
        Console.WriteLine("Thread 1 started");
        t1.Start();
        Console.WriteLine("Thread 2 started");
        t2.Start();
        Console.WriteLine("Thread 3 started");
        t3.Start();
        Console.WriteLine("Main thread completed");
    }
}   