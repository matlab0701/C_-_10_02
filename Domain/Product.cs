namespace Domain;

public class Product
{
    public string? ProductId { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public Product( string name, decimal price)
    {
        ProductId =Guid.NewGuid().ToString();
        Name = name;
        Price = price;
    }
}
