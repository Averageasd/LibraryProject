using System;

public class DVD : LibraryItem
{
    private string _director;
    private int _lengthInMinutes;
    public DVD(string _title, string director, int lengthInMinutes) : base(_title)
    {
        Director = director;
        LengthInMinutes = lengthInMinutes;
    }

    public string Director
    {
        set
        {
            if (value == null || value.Length == 0)
            {
                Console.WriteLine("director length has to be at least 1");
                return;
            }
            _director = value;
        }
        get
        {
            return _director;

        }
    }

    public int LengthInMinutes
    {
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Length of dvd has to be at least 1");
            }
            _lengthInMinutes = value;
        }
        get
        {
            return _lengthInMinutes;
        }
    }

    public override int LoanPeriod
    {
        get
        {
            return DVD_LOAN_PERIOD;
        }
    }

    public override void Print()
    {
        Console.WriteLine($"{Title} directed by {Director}. Length dvd is {LengthInMinutes}. Loan period is {LoanPeriod}");
    }
}
