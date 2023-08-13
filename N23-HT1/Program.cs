var products = new List<Product>
        {
            new Product("iPhone 12", 4, 60),
            new Product("Samsung Galaxy S21", 4, 75),
            new Product("Google Pixel 5", 4, 50),
            new Product("OnePlus 9 Pro", 4, 60),
            new Product("Xiaomi Mi 11", 4, 80),
            new Product("Sony Xperia 1 III", 3, 40),
            new Product("LG Wing", 3, 30),
            new Product("Motorola Edge+", 3, 35),
            new Product("Iphone 14", 5, 10),
            new Product("Asus ROG Phone 5", 4, 70)
        };

var orderedProducts = products.OrderByDescending(product => product.Stars)
                             .ThenBy(product => product.Inventory)
                             .Take(5);

foreach (var product in orderedProducts)
{
    Console.WriteLine($"{product.Name} - {product.Inventory} in stock");
}