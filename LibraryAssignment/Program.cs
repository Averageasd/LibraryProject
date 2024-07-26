using System;

public class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("title1", "author1", "isbn");
        book.Borrow("borrower1");
        book.Borrow("borrower2");
        book.Return();
        book.Borrow("borrower2");
        book.Return();
        book.Return();
        book.Print();
        Console.ReadKey();
    }
}

