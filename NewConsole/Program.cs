public class Person
{
    public void Test1()
    {
        Console.WriteLine("This is a public method");
    }
    private void Test2()
    {
        Console.WriteLine("This is a private method");
    }
    protected void Test3()
    {
        Console.WriteLine("This is a protected method");
    }
    internal void Test4()
    {
        Console.WriteLine("This is an internal method");
    }
    internal protected void Test5()
    {
        Console.WriteLine("This is an internal protected method");
    }
}