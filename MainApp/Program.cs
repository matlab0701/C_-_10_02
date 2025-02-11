using Domain;
using Infrastructure;

Product product= new Product("Telephone",2550);
Customer customer= new Customer("Bezhan");
OrderStatus orderStatus= new OrderStatus();
ShoppingCart shoppingCart = new ShoppingCart();
shoppingCart.AddToCart(product,2450);
shoppingCart.GetCartItems();

ECommerceSystem shop= new ECommerceSystem();
shop.AddProduct(product);
shop.AddCustomer(customer);
shop.PlaceOrder(customer,shoppingCart);
shop.UpdateOrderStatus(Guid.NewGuid().ToString(),orderStatus);
shop.DisplayAllOrders();