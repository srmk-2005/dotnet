using System;
class BankAccount
{
    public event Action LowBalance;
    public int balance = 1000;
    public void Withdraw(int amount)
    {
        balance -= amount;
        Console.WriteLine("Remaining balance: " + balance);
        if (balance < 500)
        {
            LowBalance?.Invoke();
        }
    }
}

class Notification
{
    public void SendAlert()
    {
        Console.WriteLine("Alert! Your bank balance is low.");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        Notification notification = new Notification();
        account.LowBalance += notification.SendAlert;
        account.Withdraw(400);
    }
}