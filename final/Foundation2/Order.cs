using System.Text;

using System.Linq;

namespace Foundation2;

public class Order
{
   
    List<Product> _products;
    private Customer _customer;
    private double _shippingPrice;
    private double _totalPrice;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProductsToList(Product product)
    {
 
            _products.Add(product);
        
    }

    public double ShippingCost()
    {
        if (_customer.LivesInUsa() == true)
        {
            _shippingPrice = 5.00;
        }
        else
            _shippingPrice = 35.00;

        return _shippingPrice;

    }
    
    public string CalculatePrice()
    {
        _totalPrice = _products.Sum(product => product.TotalCost());
        _totalPrice += ShippingCost();
        
        return $"Total Cost: ${_totalPrice.ToString("F2")}";
    }

    public string GetShippingLabel()
    {

        return _customer.ReturnCustomer();
    }

    public string DisplayProduct()
    {
        StringBuilder productsDisplay = new StringBuilder();
        
        foreach (Product product in _products)
        {
             productsDisplay.AppendLine(product.GetProduct()); 
        }

        return productsDisplay.ToString();
    }

    public void DisplayOrder()
    {
        Console.WriteLine("----------SHIPPING LABEL-----------");
        
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine(" ");
        
        Console.WriteLine("----------PACKING LABEL-----------");
        
        Console.WriteLine(DisplayProduct());
        Console.WriteLine(CalculatePrice());
        Console.WriteLine(" ");
    }
    
    
}