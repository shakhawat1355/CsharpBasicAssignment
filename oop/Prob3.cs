using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


/*Show different type of class inheritance*/

namespace oop
{
    public class Prob3
    {

    }
}

//Multi - level Inheritance

public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Mammal : Animal
{
    public void Breathe()
    {
        Console.WriteLine("Breathing...");
    }
}

public class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}


//Multiple Inheritance

public interface IShape
{
    void Draw();
}

public interface IColor
{
    void Colorize();
}

public class Rectangle : IShape, IColor
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle...");
    }

    public void Colorize()
    {
        Console.WriteLine("Coloring the rectangle...");
    }
}




//Hierarchical Inheritance

public class Vehicle
{
    public void StartVehicle()
    {
        Console.WriteLine("Vehicle is starting");
    }
}

public class Car : Vehicle
{
    public void StartCar()
    {
        Console.WriteLine("Car is starting");
    }
}

public class Truck : Vehicle
{
    public void StartTruck()
    {
        Console.WriteLine("Truck is starting");
    }
}


