using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Author} - {Title} ({Year})");
    }
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>
        {
            new Book("Преступление и наказание", "Фёдор Достоевский", 1866),
            new Book("Мастер и Маргарита", "Михаил Булгаков", 1967),
            new Book("Война и мир", "Лев Толстой", 1869)
        };

        foreach (var book in books)
        {
            book.PrintInfo();
        }
    }
}