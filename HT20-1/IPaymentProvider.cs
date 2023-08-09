namespace HT20_1
{
    public interface IPaymentProvider
    {
        
         decimal TransferInterest { get; }
         void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount);
        
    }
}
