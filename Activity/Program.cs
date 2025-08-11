using System;
using Book1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Book 1: Default Constructor ---");
        Book book1 = new Book();
        book1.DisplayBookInfo();

        Console.WriteLine("\n--- Book 2: Basic Constructor ---");
        Book book2 = new Book("The Traitor", "Thomas Dixon, Jr. ");
        book2.DisplayBookInfo();

        Console.WriteLine("\n--- Book 3: Detailed Constructor ---");
        Book book3 = new Book("Mill On The Floss", "George Eliot", 2000);
        book3.DisplayBookInfo();

        Console.WriteLine("\n--- Book 4: Complete Constructor ---");
        Book book4 = new Book("The Scribe Method", "Tucker Max and Zach Obront", 1957, "Self-Help Book");
        book4.DisplayBookInfo();
    }
}