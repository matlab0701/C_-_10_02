using Domain;
namespace Infrastructure;

public class ECommerceSystem
{
    public List<Product> products { get; set; } = new List<Product>();
    public List<Customer> customers { get; set; } = new List<Customer>();
    public List<Order> orders { get; set; } = new List<Order>();


    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }
    public Order PlaceOrder(Customer customer, ShoppingCart cart)
    {
        decimal tottalAmount = 0;
        foreach (var item in cart.cartItems)
        {
            tottalAmount += item.Key.Price * item.Value;
        }
        var order = new Order(customer, cart.GetCartItems(), tottalAmount);
        orders.Add(order);
        return order;
    }
    public void UpdateOrderStatus(string orderId, OrderStatus status)
    {
        foreach (var item in orders)
        {
            if (item.OrderId == orderId)
            {
                item.Status = status;
                System.Console.WriteLine($"Status order Update to {status}");
            }
        }
        System.Console.WriteLine("Error");
    }

    public void DisplayAllOrders()
    {
        foreach (var order in orders)
        {
            Console.WriteLine($"Заказ {order.OrderId} - {order.Customers.Name} - Статус: {order.Status} - Сумма: {order.TotalAmount} - дата: {order.OrderDate}");
            System.Console.WriteLine();
        }
    }
}