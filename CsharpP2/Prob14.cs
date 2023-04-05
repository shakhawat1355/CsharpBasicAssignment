using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP2
{


    class Person
    {
        public string Name { get; set; }
    }

    public class Prob14
    {

        public void print()
        {

            // Creating two Person objects
            Person person1 = new Person { Name = "Alice" };
            Person person2 = new Person { Name = "Bob" };

            // Assigning person2 to person1
            person1 = person2;

            // Changing the Name property of person2
            person2.Name = "Charlie";

            // Printing the Name property of person1 and person2
            Console.WriteLine(person1.Name); // Output: "Charlie"
            Console.WriteLine(person2.Name); // Output: "Charlie"

            // Creating two integer variables
            int x = 5;
            int y = 10;

            // Assigning y to x
            x = y;

            // Changing the value of y
            y = 15;

            // Printing the values of x and y
            Console.WriteLine(x); // Output: 10
            Console.WriteLine(y); // Output: 15

        }
    }

}
}
