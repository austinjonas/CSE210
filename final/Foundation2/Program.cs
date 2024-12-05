using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        //New address
        Address address = new Address();
        address.SetCountry("USA");
        address.SetStateOrProvince("Utah");
        address.SetCity("Orem");
        address.SetStreet("123 spruce lane");

        //New Customer
        Customer customer = new Customer();
        customer.SetCustomerName("Bob Jones");
        customer.SetAddress(address);

        Product product = new Product();
        product.SetProductName("Laptop");
        product.SetProductId("LPT123");
        product.SetProductPrice(1000);
        product.SetProductQuantity(2);

        Product product2 = new Product();
        product2.SetProductName("Mouse");
        product2.SetProductId("MSE456");
        product2.SetProductPrice(50);
        product2.SetProductQuantity(3);
        
        Product product3 = new Product();
        product3.SetProductName("Book");
        product3.SetProductId("NNEEE6");
        product3.SetProductPrice(15);
        product3.SetProductQuantity(6);

        Order order = new Order();
        order.SetCustomer(customer);
        order.AddProduct(product);
        order.AddProduct(product2);
        order.AddProduct(product3);

        Console.WriteLine();
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine(order.PackagingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Price: {order.TotalPrice()}");
        Console.WriteLine();
    }
}