using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//Declare a list of int,string,double. Find out all list manipulation methods and implement them.

namespace CsharpP2
{
    public class Prob19
    {
        public void ListManipulator()
        {
            List<int> intList = new List<int>();

            // Add some integers to the list
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);

            // Declare a list of strings
            List<string> stringList = new List<string>();

            // Add some strings to the list
            stringList.Add("apple");
            stringList.Add("banana");
            stringList.Add("cherry");
            stringList.Add("date");

            // Declare a list of doubles
            List<double> doubleList = new List<double>();

            // Add some doubles to the list
            doubleList.Add(3.14);
            doubleList.Add(2.71);
            doubleList.Add(1.618);

            // Display the initial contents of each list
            Console.WriteLine("Initial contents of intList:");
            foreach (int num in intList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Initial contents of stringList:");
            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Initial contents of doubleList:");
            foreach (double dbl in doubleList)
            {
                Console.WriteLine(dbl);
            }

            // Find the index of an element in intList
            int index = intList.IndexOf(3);
            Console.WriteLine("Index of 3 in intList: " + index);

            // Remove an element from intList
            intList.RemoveAt(2);

            // Insert an element into stringList
            stringList.Insert(2, "grape");

            // Sort doubleList in descending order
            doubleList.Sort();
            doubleList.Reverse();

            // Check if an element exists in intList
            bool exists = intList.Contains(4);
            Console.WriteLine("Does intList contain 4? " + exists);

            // Clear all elements from stringList
            stringList.Clear();

            // Display the final contents of each list
            Console.WriteLine("Final contents of intList:");
            foreach (int num in intList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Final contents of stringList:");
            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Final contents of doubleList:");
            foreach (double dbl in doubleList)
            {
                Console.WriteLine(dbl);
            }
        }
    }





}

