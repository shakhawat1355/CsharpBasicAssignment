using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;



//Class upcasting and downcasting

namespace oop
{
    public class Prob5
    {

    }
}

public class Airplane
{
    public virtual void Fly()
    {
        Console.WriteLine("The airplane is flying.");
    }
}

public class Jet : Airplane
{
    public override void Fly()
    {
        Console.WriteLine("The jet is flying at supersonic speed.");
    }

    public void Afterburner()
    {
        Console.WriteLine("The jet's afterburner is engaged.");
    }
}


//Jet myJet = new Jet();
//Airplane myAirplane = myJet; // Upcasting


//Airplane myAirplane2 = new Jet();
//Jet myJet2 = (Jet)myAirplane2; // Downcasting
//myJet2.Afterburner();