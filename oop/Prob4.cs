using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Show constructor inheritance

namespace oop
{
    public class Prob4
    {

    }
}


public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        Console.WriteLine("Product constructor called");
    }
}

public class ElectronicProduct : Product
{
    public string Manufacturer { get; set; }

    public ElectronicProduct(string name, decimal price, string manufacturer) : base(name, price)
    {
        Manufacturer = manufacturer;
        Console.WriteLine("ElectronicProduct constructor called");
    }
}
