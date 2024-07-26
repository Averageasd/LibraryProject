using System;
public abstract class LibraryItem : ILoanable, IPrintable
{
    private string _title;
    private string _borrower;

    public const int BOOK_LOAN_PERIOD = 21;
    public const int DVD_LOAN_PERIOD = 7;
    public const int CD_LOAN_PERIOD = 14;

    public LibraryItem(string _title)
    {
        Title = _title;
        _borrower = null;
    }

    public string Borrower { set; get; } = null;

    public string Title
    {
        set
        {
            if (value == null || value.Length == 0)
            {
                Console.WriteLine("invalid title. Title has to have at last 1 character");
                return;
            }
            _title = value;
        }

        get
        {
            return _title;
        }
    }

    public void Borrow(string borrower)
    {
        if (Borrower == null)
        {
            Borrower = borrower;
            Console.WriteLine($"{Borrower} borrowed item {Title}");
            return;
        }

        Console.WriteLine($"Cannot borrow. {Borrower} already borrowed item {Title}");

    }

    public void Return()
    {

        if (Borrower == null)
        {
            Console.WriteLine($"Item {Title} already in stock");
            return;
        }
        Console.WriteLine($"Item {Title} returned successfully by {Borrower}");
        Borrower = null;
    }

    public abstract int LoanPeriod { get; }


    public abstract void Print();
}

