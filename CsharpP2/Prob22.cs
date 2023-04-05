using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP2
{
    public class Prob22
    {
        public void StringManipulator()
        {
            string text = "Hello, world!";

            // get the length of the string
            int length = text.Length;

            // convert the string to uppercase
            string uppercase = text.ToUpper();

            // convert the string to lowercase
            string lowercase = text.ToLower();

            // get the index of the first occurrence of a character or substring
            int index = text.IndexOf(",");

            // remove a substring from the string
            string withoutComma = text.Remove(index, 1);

            // replace a substring in the string with another substring
            string replaced = text.Replace("world", "everyone");

            // split the string into an array of substrings
            string[] substrings = text.Split(',');

            // trim whitespace from the beginning and end of the string
            string trimmed = text.Trim();

            // check if the string starts with a certain substring
            bool startsWith = text.StartsWith("Hello");

            // check if the string ends with a certain substring
            bool endsWith = text.EndsWith("!");

            // concatenate two strings
            string greeting = "Hi";
            string message = "there";
            string fullMessage = string.Concat(greeting, " ", message);

        }
    }
}
