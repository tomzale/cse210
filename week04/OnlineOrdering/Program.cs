using System;

class Program
{
    static void Main(string[] args)
    {
        // First order - Benin City customer
        Address beninAddress = new Address("45 Airport Road", "Benin City", "Edo", "Nigeria");
        Customer beninCustomer = new Customer("Chinedu Okonkwo", beninAddress);
        Order order1 = new Order(beninCustomer);
        
        order1.AddProduct(new Product("Wireless Earbuds", "P345", 45.99, 2));
        order1.AddProduct(new Product("Power Bank", "P678", 29.50, 1));
        
        Console.WriteLine("ORDER 1 DETAILS:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ₦{order1.CalculateTotalCost() * 1500:0}\n"); // Converted to Naira

        // Second order - Abuja customer
        Address abujaAddress = new Address("22 Maitama Avenue", "Abuja", "FCT", "Nigeria");
        Customer abujaCustomer = new Customer("Aisha Bello", abujaAddress);
        Order order2 = new Order(abujaCustomer);
        
        order2.AddProduct(new Product("Smart Watch", "P901", 89.99, 1));
        order2.AddProduct(new Product("Phone Case", "P234", 12.75, 3));
        order2.AddProduct(new Product("Tablet", "P567", 199.99, 1));
        
        Console.WriteLine("ORDER 2 DETAILS:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ₦{order2.CalculateTotalCost() * 1500:0}");
    }
}