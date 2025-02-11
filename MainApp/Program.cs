using Domain;
using Infrastructure;

Product product= new Product("Telephone",2550);
Customer customer= new Customer("Bezhan");
ShoppingCart shoppingCart = new ShoppingCart();
OrderStatus orderStatus= new OrderStatus();

ECommerceSystem shop= new ECommerceSystem();
shop.AddProduct(product);
shop.AddCustomer(customer);
shop.PlaceOrder(customer,shoppingCart);
shop.UpdateOrderStatus(Guid.NewGuid().ToString(),orderStatus);
shop.DisplayAllOrders();