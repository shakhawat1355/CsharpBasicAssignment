using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP2
{

    //Declare arrays of size 15. Array type should be bool,char,int,long,double,string etc
    //Insert dummy value to those arrays and print them.While printing skip index no 5 and print until index 10. (use for,while,foreach,break,continue)

    public class Prob15_16
    {
        // Declare an array of bool
        bool[] boolArray = new bool[15];

        // Declare an array of char
        char[] charArray = new char[15];

        // Declare an array of int
        int[] intArray = new int[15];

        // Declare an array of long
        long[] longArray = new long[15];

        // Declare an array of double
        double[] doubleArray = new double[15];

        // Declare an array of string
        string[] stringArray = new string[15];

        public void print()
        {
            // Set some values in the arrays
            for (int i = 0; i < 15; i++)
            {
                boolArray[i] = (i % 2 == 0);
                charArray[i] = (char)(i + 65);
                intArray[i] = i * 10;
                longArray[i] = (long)Math.Pow(i, 3);
                doubleArray[i] = i * 1.5;
                stringArray[i] = $"String {i}";
            }

            // Print the arrays
            // Using a for loop
            Console.WriteLine("Using a for loop:");
            for (int i = 0; i < 15; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                if (i > 10)
                {
                    break;
                }

                Console.Write($"boolArray[{i}] = {boolArray[i]}; ");
                Console.Write($"charArray[{i}] = {charArray[i]}; ");
                Console.Write($"intArray[{i}] = {intArray[i]}; ");
                Console.Write($"longArray[{i}] = {longArray[i]}; ");
                Console.Write($"doubleArray[{i}] = {doubleArray[i]}; ");
                Console.Write($"stringArray[{i}] = {stringArray[i]}; ");
                Console.WriteLine();
            }



            // Using a while loop
            Console.WriteLine("Using a while loop:");
            int j = 0;
            while (j < 15)
            {
                if (j == 5)
                {
                    j++;
                    continue;
                }

                if (j > 10)
                {
                    break;
                }

                Console.Write($"boolArray[{j}] = {boolArray[j]}; ");
                Console.Write($"charArray[{j}] = {charArray[j]}; ");
                Console.Write($"intArray[{j}] = {intArray[j]}; ");
                Console.Write($"longArray[{j}] = {longArray[j]}; ");
                Console.Write($"doubleArray[{j}] = {doubleArray[j]}; ");
                Console.Write($"stringArray[{j}] = {stringArray[j]}; ");
                Console.WriteLine();

                j++;
            }


            // Using a foreach loop
            Console.WriteLine("Using a foreach loop:");
            foreach (var item in boolArray)
            {
                int i = Array.IndexOf(boolArray, item);

                if (i == 5)
                {
                    continue;
                }

                if (i > 10)
                {
                    break;
                }

                Console.Write($"boolArray[{i}] = {boolArray[i]}; ");
                Console.Write($"charArray[{i}] = {charArray[i]}; ");
                Console.Write($"intArray[{i}] = {intArray[i]}; ");
                Console.Write($"longArray[{i}] = {longArray[i]}; ");
                Console.Write($"doubleArray[{i}] = {doubleArray[i]}; ");
                Console.Write($"stringArray[{i}] = {stringArray[i]}; ");

            }


        }


    }
}
