namespace Foundation2;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUsa()
    {
       
        return _address.ReturnUsaOrNot();
    }
    public string ReturnCustomer()
    {
        return $"{_name} \n{_address.GetAddress()}";
    }
}