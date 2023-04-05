using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP2
{
    public class Prob23
    {
        public void StringBuilderManipulator()
        {
            string original = "Hello, world!";
            StringBuilder builder = new StringBuilder(original);

            // change the 'o' in 'world' to a capital 'O'
            builder[7] = 'O';

            // insert a space between 'Hello,' and 'world!'
            builder.Insert(5, " ");

            // remove the exclamation mark from the end of the string
            builder.Remove(builder.Length - 1, 1);

            // convert the StringBuilder back to a string
            string modified = builder.ToString();

            Console.WriteLine("Original string: " + original);
            Console.WriteLine("Modified string: " + modified);

        }

        public void StirngBuilderMethods()
        {
            StringBuilder sb = new StringBuilder("Hello, World!");

            // Append a string to the end of the StringBuilder object
            sb.Append(" How are you?");

            // Append a line to the end of the StringBuilder object
            sb.AppendLine(" I hope you're doing well!");

            // Insert a string at the specified position in the StringBuilder object
            sb.Insert(7, "there, ");

            // Remove a specified number of characters from the StringBuilder object
            sb.Remove(0, 7);

            // Replace all occurrences of a specified string in the StringBuilder object
            sb.Replace("you", "everyone");

            // Clear all characters from the StringBuilder object
            sb.Clear();

            // Set the maximum capacity of the StringBuilder object
            sb.Capacity = 50;

            // Set the length of the StringBuilder object
            sb.Length = 10;

            // Convert the StringBuilder object to a string
            string result = sb.ToString();

            Console.WriteLine(result);
        }
    }
}
