using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer) => _customer = customer;

    public void AddProduct(Product product) => _products.Add(product);

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculateTotalPrice();
        }
        return total + (_customer.IsInUSA() ? 5 : 35);
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetProductDetails()}\n";
        }
        return label;
    }

    public string GetShippingLabel() => 
        $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
}