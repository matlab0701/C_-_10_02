namespace Domain;

public class Customer
{
    public string? CustomerId { get; set; }
    public string? Name { get; set; }
    public Customer(string name)
    {
        CustomerId = Guid.NewGuid().ToString();
        Name = name;
    }
}
