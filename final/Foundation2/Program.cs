using Foundation2;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("233 River Oaks Dr", "Galax", "Missouri", "Africa");

        Customer customer1 = new Customer("Jenny Witcrumb", address1);

        Order order1 = new Order(customer1);
        
        Product item1 = new Product("Bingo", "AB2354", 25.99, 20);
        Product item2 = new Product("Bluey", "AB2345", 25.99, 25);
        Product item3 = new Product("Muffin", "AB2245", 20.99, 15);
        order1.AddProductsToList(item1);
        order1.AddProductsToList(item2);
        order1.AddProductsToList(item3);
        
        order1.DisplayOrder();
     
        Address address2 = new Address("234 W Hampton Dr.", "Ozark", "VA", "USA");
        
        Customer customer2 = new Customer("Jerry Jerryman", address2);
        
        Order order2 = new Order(customer2);
        
        Product item4 = new Product("BYU Helmet", "BYU1235", 45.79, 2);
        Product item5= new Product("BYU Football", "BYU1976", 29.99, 1);
        Product item6 = new Product("BYU Jersey", "BYU0010", 79.99, 4);
        order2.AddProductsToList(item4);
        order2.AddProductsToList(item5);
        order2.AddProductsToList(item6);
        
        order2.DisplayOrder();
        
 
        
    }
}