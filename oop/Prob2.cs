using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Declare a class with different type of constructor*/


namespace oop
{
    public class Prob2
    {

    }
}




public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Default constructor with no parameters
    public Person()
    {
        FirstName = "";
        LastName = "";
        Age = 0;
    }

    // Constructor with parameters for first and last name
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = 0;
    }

    // Constructor with parameters for all properties
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}
