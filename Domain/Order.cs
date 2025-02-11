namespace Domain;

public class Order
{

    public string OrderId { get; set; }
    public Customer Customers { get; set; }
    public Dictionary<Product,int> OrderedItems { get; set; } = new Dictionary<Product, int>();
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime OrderDate { get; set; }


    public Order(string orderId, Customer customer, Dictionary<Product, int> orderItems)
    {
        OrderId = orderId;
        Customers = customer;
        OrderedItems = orderItems;
        TotalAmount = 210000;
        Status = OrderStatus.Placed;
        OrderDate = DateTime.Now;
    }
    public void UpdateStatus(OrderStatus status)
    {
        Status = status;
    }
}

