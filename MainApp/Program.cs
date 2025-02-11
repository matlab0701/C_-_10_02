using Domain;
using Infrastructure;

Product product= new Product("1","Telephone",2550);
Customer customer= new Customer("1","Bezhan");
ShoppingCart shoppingCart = new ShoppingCart();
OrderStatus orderStatus= new OrderStatus();

ECommerceSystem shop= new ECommerceSystem();
shop.AddProduct(product);
shop.AddCustomer(customer);
shop.PlaceOrder(customer,shoppingCart);
shop.UpdateOrderStatus("1",orderStatus);
shop.DisplayAllOrders();