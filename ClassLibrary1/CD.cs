using System;

public class CD : LibraryItem
{
    private string _artist;
    private int _numberOfTracks;
    public CD(string _title, string _artist, int _numberOfTracks) : base(_title)
    {
        Artist = _artist;
        NumberOfTracks = _numberOfTracks;
    }

    public string Artist
    {
        set
        {
            if (value == null || value.Length == 0)
            {
                Console.WriteLine("artist has to have length of at least 1");
                return;
            }
            _artist = value;
        }

        get
        {
            return _artist;
        }
    }

    public int NumberOfTracks
    {
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Number of track has to be at least 0");
                return;
            }

            _numberOfTracks = value;
        }

        get
        {
            return _numberOfTracks;
        }
    }
    public override int LoanPeriod
    {
        get
        {
            return CD_LOAN_PERIOD;
        }
    }

    public override void Print()
    {
    {
        Console.WriteLine($"{Title} composed by ${Artist}. Number of tracks is {NumberOfTracks}. Length of period is {CD_LOAN_PERIOD}");
    }
}
