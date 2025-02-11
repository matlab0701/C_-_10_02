namespace Domain;

public class ShoppingCart
{
    public Dictionary<Product, int> cartItems { get; set; } = new Dictionary<Product, int>();

    public void AddToCart(Product product, int quantity)
    {
        if (cartItems.ContainsKey(product))
        {
            cartItems[product] += quantity;
        }
        else
        {
            cartItems[product] = quantity;
        }
    }

    public Dictionary<Product, int> GetCartItems()
    {
        return cartItems;
    }
}
