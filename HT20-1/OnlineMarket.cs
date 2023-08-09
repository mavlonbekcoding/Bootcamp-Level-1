namespace HT20_1;
public class OnlineMarket
{
    private readonly IPaymentProvider _provider;
    private readonly List<Product> _products = new List<Product>();

    public OnlineMarket(IPaymentProvider provider)
    {
        _provider = provider;
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Buy(string name, int number, IDebitCard card)
    {
        Product productToBuy = _products.Find(p => p.Name == name);
        if (productToBuy != null && card.Balance >= productToBuy.Price)
        {
            _provider.Transfer(card, card, productToBuy.Price);
            Console.WriteLine($"You've successfully bought {productToBuy.Name} for {productToBuy.Price} from your card.");
        }
        else
        {
            Console.WriteLine("Not enough balance or product not found.");
        }
    }
}



