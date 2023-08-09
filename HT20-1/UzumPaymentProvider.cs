namespace HT20_1;

public class UzumPaymentProvider : IPaymentProvider
{
    public decimal TransferInterest { get; } = 0.015m;

    public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount)
    {
        decimal transferFee = amount * TransferInterest;
        if (sourceCard.Balance >= amount + transferFee)
        {
            sourceCard.Balance -= amount + transferFee;
            destinationCard.Balance += amount;
        }
    }
}
