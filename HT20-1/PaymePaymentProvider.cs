namespace HT20_1;

public class PaymePaymentProvider : IPaymentProvider
{
    public decimal TransferInterest { get; } = 0.02m;

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

