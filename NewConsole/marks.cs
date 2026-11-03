class Marks
{
    static void Main(string[] args)
    {
        // int marks;
        int [] marksArray = new int[5];
        Console.WriteLine("Enter your marks: ");
        try
        {
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write("Enter marks for subject {0}: ", i+1);
                    int mark=Convert.ToInt32(Console.ReadLine());
                    if (mark < 0 || mark > 100)
                    {
                        Console.WriteLine("Invalid marks. Please enter a value between 0 and 100.");
                    }
                    else
                    {
                        marksArray[i] = mark;
                        break;
                    }
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }
}