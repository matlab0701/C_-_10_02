namespace Domain;

public class Customer
{
    public string? CustomerId { get; set; }
    public string? Name { get; set; }
    public Customer(string customerId,string name)
    {
        CustomerId= customerId;
        Name=name;
    }
}
