namespace Foundation2;

public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productID = productId;
        _price = price;
        _quantity = quantity;
    }
    
    public double TotalCost()
    { 
        double total =  _price * _quantity;
        return total;
    }

    public string GetProduct()
    {
        return $"Product: {_name}; Product ID: {_productID}";
    }

}