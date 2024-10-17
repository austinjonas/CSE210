class bin
{
   // attributes
   private string _denomination
    private float _value
    private int _quantity

    // methods
    public void ModifyQuantity(int exchange)
    {
        _quantity += exchange;
    }

    public float CountValue()
    {
        return _quantity * _value;
    }
}