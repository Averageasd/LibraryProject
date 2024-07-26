
public interface ILoanable
{
    int LoanPeriod { get; }
    string Borrower { get; set; }
    void Borrow(string borrower);
    void Return();

}
