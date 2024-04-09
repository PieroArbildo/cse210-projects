
public class Order
{

    private List<Product> _Products;
    private Customer _Customer;
    public Order(Customer customer)
    {
        _Customer=customer;
        _Products = new List<Product>();
    }
        public void AddProduct(Product product)
    {
        _Products.Add(product);
    }

    public double GetTotalCost()
    {
    
        double totalPrice = 0;
        foreach (var product in _Products)
        {
            totalPrice += product.GetTotalCost();
        }

        if (_Customer.IsInUSA())
        {
            totalPrice += 5; 
        }
        else
        {
            totalPrice += 35; 
        }
        return totalPrice;
    }
public string GetPackingLabel()
{
    string label = "Packing :\n";
    foreach (var product in _Products)
    {
        label += $"{product.GetName()} - ID: {product.GetId()}\n";
    }
    return label;
}

    public string GetShippingLabel()
    {
        string label = "Shipping :\n";
        label += $"Name: {_Customer.GetName()}\n";
        label += $"Address:\n{_Customer.GetAddress().GetFullAddress()}";
        return label;
    }

}