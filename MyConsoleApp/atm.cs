using System;
class Atm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ATM!");
        // Console.Write("Enter your account balance: ");
        double balance = 5000;
        Console.Write("Enter the amount to withdraw: ");
        double withdrawAmount = Convert.ToDouble(Console.ReadLine());

        if (withdrawAmount <= balance)
        {
            balance -= withdrawAmount;
            Console.WriteLine("Withdrawal successful. Remaining balance: " + balance);
        }
        else
        {
            Console.WriteLine("Insufficient funds. Withdrawal failed.");
        }
    }
}