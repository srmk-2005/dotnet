class Marks
{
    static void Main(string[] args)
    {
        int marks;
        Console.WriteLine("Enter your marks: ");
        marks = Convert.ToInt32(Console.ReadLine());
        try
        {
            if (marks < 0 || marks > 100)
            {
                throw new ArgumentOutOfRangeException("Marks should be between 0 and 100.");
            }
            else if (marks >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Thank you for using the grading system.");
        }
    }
}