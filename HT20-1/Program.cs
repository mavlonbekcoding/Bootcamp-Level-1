using HT20_1;

public class Program
{
    static void Main(string[] args)
    {
        KapitalUzcard kapitalCard = new KapitalUzcard("1234-5678-9012-3456");
        MilliyHumo millyCard = new MilliyHumo("9876-5432-1098-7654");

        PaymePaymentProvider paymeProvider = new PaymePaymentProvider();
        UzumPaymentProvider uzumProvider = new UzumPaymentProvider();

        OnlineMarket onlineMarketPayme = new OnlineMarket(paymeProvider);
        OnlineMarket onlineMarketUzum = new OnlineMarket(uzumProvider);

        Product laptop = new Product { Name = "Laptop", Price = 1500 };
        Product phone = new Product { Name = "Phone", Price = 800 };
        Product headphones = new Product { Name = "Headphones", Price = 100 };

        onlineMarketPayme.Add(laptop);
        onlineMarketPayme.Add(phone);
        onlineMarketUzum.Add(phone);
        onlineMarketUzum.Add(headphones);

        onlineMarketPayme.Buy("Laptop", 1, kapitalCard);
        onlineMarketUzum.Buy("Headphones", 1, kapitalCard);

        Console.WriteLine($"KapitalUzcard balance: {kapitalCard.Balance}");
        Console.WriteLine($"MillyHumo balance: {millyCard.Balance}");
    }
}



