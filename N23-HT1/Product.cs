public class Product
{
    public string Name { get; set; }
    public int Stars { get; set; }
    public int Inventory { get; set; }
    public Product(string name, int stars,int invertory) 
    { 
        this.Name = name;
        this.Stars = stars;
        this.Inventory = Inventory;
    }
}