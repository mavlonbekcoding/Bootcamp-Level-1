namespace HT20_1;

public class MilliyHumo : IDebitCard
{
    public MilliyHumo(string cardNumber)
    {
        CardNumber = cardNumber;
        BankName = "Milly Humo";
    }

    public string CardNumber { get; }
    public string BankName { get; }
    public decimal Balance { get; set; } = 1_00_00;
}
