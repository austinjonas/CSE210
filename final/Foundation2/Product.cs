class Product
{
    private string _productName = "";
    private string _productId = "";
    private int _productQuantity;
    private int _productPrice;
    private int _totalPrice;

    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string productName)
    {
        _productName = productName;
    }
        public string GetProductId()
    {
        return _productId;
    }
    public void SetProductId(string productId)
    {
        _productId = productId;
    }
    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    public void SetProductQuantity(int productQuantity)
    {
        _productQuantity = productQuantity;
    }

    public int GetProductPrice()
    {
        return _productPrice;
    }
    public void SetProductPrice(int productPrice)
    {
        _productPrice = productPrice;
    }
    public int GetTotalProductPrice()
    {
        return GetProductPrice() * GetProductQuantity();
    }
    public void SetProductName(int totalPrice)
    {
        _totalPrice = totalPrice;
    }
}