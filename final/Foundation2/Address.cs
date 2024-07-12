namespace Foundation2;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvidance; 
    private string _country;
    
    public bool ReturnUsaOrNot()
    {
        string country = _country;
        
        if (country == "USA")
        {
            return true;
        } else
        
            return false;
    }

    public Address(string street, string city, string stateOrProvidance, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvidance = stateOrProvidance;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvidance}, {_country}";
    }
    
    
}