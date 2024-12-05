class Address
{
    public List <Address> _addresses = new List<Address>();
    private string _streetAddress { get; set; } = "";
    private string _city { get; set; } = "";
    private string _stateOrProvince { get; set; } = "";
    private string _country { get; set; } = "";
    

    public string GetStreet()
    {
        return _streetAddress;
    }
    public void SetStreet(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }

    public void AddAddress(string streetAddress, string city, string stateOrProvince, string country)
    {
        Address address = new Address();
        address.SetStreet(streetAddress);
        address.SetCity(city);
        address.SetStateOrProvince(stateOrProvince);
        address.SetCountry(country);
        _addresses.Add(address);
    }
    public string FullAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}";
    }
}