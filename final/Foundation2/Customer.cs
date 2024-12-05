class Customer
{
    private string _customerName { get; set; } = "";
    private Address _address = new Address();
    private int _shippingCost { get; set; }
    
    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

    public Address GetAddress()
    {
        return _address;
    }
    
    public void SetAddress(Address address)
    {
        _address = address;
    }

    public int internationalOrDomestic()
    {
        if (_address.GetCountry() == "USA")
        {
            _shippingCost = 5;
        }
        if (_address.GetCountry() != "USA")
        {
            _shippingCost = 35;
        }
        return _shippingCost;
    }

    public string GetCustomerInfo()
    {
        return $"Name: {GetCustomerName()}, Address: {_address.FullAddress()}";
    }
}