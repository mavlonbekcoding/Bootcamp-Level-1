namespace HT20_1;

public interface IDebitCard
{
    
        string CardNumber { get; }
        string BankName { get; }
        decimal Balance { get; set; }
    
}
