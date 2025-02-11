namespace Domain;

public class ShoppingCart
{
    public Dictionary<Product, int> cartItems { get; set; } = new Dictionary<Product, int>();

    public void AddToCart(Product product, int quantity)
    {
        cartItems.Add(product,quantity);
       System.Console.WriteLine("Succes");
    }

    public Dictionary<Product, int> GetCartItems()
    {
        return cartItems;
    }
}
