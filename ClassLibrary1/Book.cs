using System;

public class Book : LibraryItem
{
    private string _author;
    private string _isbn;

    public Book(string _title, string _author, string _isbn) : base(_title)
    {
        Author = _author;
        ISBN = _isbn;
    }

    public string Author
    {
        set
        {
            if (value == null || value.Length == 0)
            {
                Console.WriteLine("invalid author name. Author has to have at last 1 character");
                return;
            }
            _author = value;
        }

        get
        {
            return _author;
        }
    }

    public string ISBN
    {
        set
        {
            if (value == null || value.Length < 4)
            {
                Console.WriteLine("invalid isbn. ISBN has to have at last 4 character");
                return;
            }
            _isbn = value;
        }

        get
        {
            return _isbn;
        }
    }

    public override int LoanPeriod
    {
        get
        {
            return BOOK_LOAN_PERIOD;
        }
    }

    public override void Print()
    {
        Console.WriteLine($"{Title} authored by {Author}, ISBN is: {ISBN}. Book loan period is : {LoanPeriod}");
    }
}

