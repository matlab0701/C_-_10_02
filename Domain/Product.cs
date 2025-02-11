namespace Domain;

public class Product
{
    public string? ProductId { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public Product(string productId, string name, decimal price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }
}
