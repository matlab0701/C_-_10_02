namespace Domain;

public class Order
{

    public string OrderId { get; set; }
    public Customer Customers { get; set; }
    public Dictionary<Product, int> OrderedItems { get; set; } = new Dictionary<Product, int>();
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime OrderDate { get; set; }


    public Order(Customer customer, Dictionary<Product, int> orderItems, decimal amount)
    {
        OrderId = Guid.NewGuid().ToString();
        Customers = customer;
        OrderedItems = orderItems;
        TotalAmount = amount;
        Status = OrderStatus.Placed;
        OrderDate = DateTime.Now;
    }
    public string UpdateStatus(OrderStatus status)
    {
        Status = status;
        return "Succes";
    }
}

