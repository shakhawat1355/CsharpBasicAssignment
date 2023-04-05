using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Use abstract class


namespace oop
{
    public class Prob9
    {

    }
}

public abstract class Laptop
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }

    public abstract void TurnOn();
    public abstract void TurnOff();

    public void Use()
    {
        Console.WriteLine("Using the laptop.");
    }
}

public class Dell : Laptop
{
    public override void TurnOn()
    {
        Console.WriteLine("Turning on the Dell laptop.");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Turning off the Dell laptop.");
    }
}

public class HP : Laptop
{
    public override void TurnOn()
    {
        Console.WriteLine("Turning on the HP laptop.");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Turning off the HP laptop.");
    }
}
