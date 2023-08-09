namespace HT20_1;

public class KapitalUzcard : IDebitCard
{
    public KapitalUzcard(string cardNumber)
    {
        CardNumber = cardNumber;
        BankName = "Kapital Uzcard";
    }

    public string CardNumber { get; }
    public string BankName { get; }
    public decimal Balance { get; set; } = 1_00_00;
}
