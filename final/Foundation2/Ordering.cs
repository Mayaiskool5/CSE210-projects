class Ordering
{
    private List<Product> _products;
    private Customer _customer;

    public Ordering(Customer customer)
    {
        this._customer = customer;
        this._products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double _total = 0;
        foreach (Product product in _products)
        {
            _total += product.GetTotalCost();
        }

        if (_customer.IsInUSA())
        {
            _total += 5;
        }
        else
        {
            _total += 35;
        }

        return _total;
    }

    public string GetPackingLabel()
    {
        string result = "";
        foreach (Product product in _products)
        {
            result += product.GetName() + " (" + product.GetProductId() + ")\n";
        }
        return result;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}