using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Declare a 2 class containing the same method.
//One method should be static. Now access the method from main class

namespace CsharpP2
{
    public class Prob18
    {


    }
}
class MyClass
{
    public void PrintMessage()
    {
        Console.WriteLine("Instance method called.");
    }
}

class MyStaticClass
{
    public static void PrintMessage()
    {
        Console.WriteLine("Static method called.");
    }
}
