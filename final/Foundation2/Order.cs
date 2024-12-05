class Order
{
    public List <Product> _products = new List<Product>();
    private Customer _customer = new Customer();

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int TotalPrice()
    {
        int totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.GetTotalProductPrice();
        }
        totalPrice += _customer.internationalOrDomestic();
        return totalPrice;
    }

    public string PackagingLabel()
    {
        string label = "Packaging label:\n";
        foreach (var product in _products)
        {
            label += $"Product: {product.GetProductName()} (ID: {product.GetProductId()}), Quantity: {product.GetProductQuantity()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Customer name: {_customer.GetCustomerName()}. \nAddress: {_customer.GetAddress().FullAddress()}\n";
    }
}