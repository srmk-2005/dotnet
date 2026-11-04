using System;
using System.Collections.Generic;

delegate void Notify(string message);

class Book
{
    public string Name;
    public bool Issued = false;

    public Book(string name)
    {
        Name = name;
    }
}

class SMS
{
    public void Send(string msg) =>
        Console.WriteLine("SMS: " + msg);
}

class Email
{
    public void Send(string msg) =>
        Console.WriteLine("Email: " + msg);
}

class Library
{
    List<Book> books = new List<Book>();
    Notify notification;

    public Library(Notify notify)
    {
        notification = notify;
    }

    public void AddBook(string name)
    {
        books.Add(new Book(name));
        Console.WriteLine("Book added!");
    }

    public void Display()
    {
        foreach (Book b in books)
            Console.WriteLine($"{b.Name} - {(b.Issued ? "Issued" : "Available")}");
    }

    public void Issue(string name)
    {
        Book b = books.Find(x => x.Name == name);

        if (b != null && !b.Issued)
        {
            b.Issued = true;
            notification?.Invoke(name + " issued successfully!");
        }
        else
            Console.WriteLine("Book unavailable!");
    }

    public void Return(string name)
    {
        Book b = books.Find(x => x.Name == name);

        if (b != null && b.Issued)
        {
            b.Issued = false;
            notification?.Invoke(name + " returned successfully!");
        }
        else
            Console.WriteLine("Invalid return!");
    }
}

class Program
{
    static void Main()
    {
        SMS sms = new SMS();
        Email email = new Email();

        Notify notify = sms.Send;
        notify += email.Send;

        Library lib = new Library(notify);

        lib.AddBook("C# Programming");
        lib.AddBook("Java Programming");

        Console.WriteLine("\nAvailable Books:");
        lib.Display();

        Console.WriteLine("\nIssuing Book:");
        lib.Issue("C# Programming");

        Console.WriteLine("\nReturning Book:");
        lib.Return("C# Programming");
    }
}