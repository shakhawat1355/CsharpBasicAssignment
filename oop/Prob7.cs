using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Method overriding


namespace oop
{
    public class Prob7
    {

    }
}

public class Pen
{
    public virtual void Write()
    {
        Console.WriteLine("The pen writes with black ink.");
    }
}

public class RedPen : Pen
{
    public override void Write()
    {
        Console.WriteLine("The red pen writes with red ink.");
    }
}
