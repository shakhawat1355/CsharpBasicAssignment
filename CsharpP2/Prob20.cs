using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Declare an array of int,string,double. Find out all array manipulation methods and implement them.

namespace CsharpP2
{
    public class Prob20
    {
        public void ArrryManipulator()
        {
            int[] intArr = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            string[] strArr = { "apple", "banana", "cherry", "date" };
            double[] dblArr = { 3.14, 1.23, 4.56, 7.89 };

            // Print original arrays
            Console.WriteLine("Original arrays:");
            Console.WriteLine("intArr: " + string.Join(", ", intArr));
            Console.WriteLine("strArr: " + string.Join(", ", strArr));
            Console.WriteLine("dblArr: " + string.Join(", ", dblArr));

            // Sort int array in ascending order
            Array.Sort(intArr);
            Console.WriteLine("\nSorted int array (ascending order):");
            Console.WriteLine("intArr: " + string.Join(", ", intArr));

            // Reverse string array
            Array.Reverse(strArr);
            Console.WriteLine("\nReversed string array:");
            Console.WriteLine("strArr: " + string.Join(", ", strArr));

            // Get index of first occurrence of 5 in int array
            int index = Array.IndexOf(intArr, 5);
            Console.WriteLine("\nIndex of first occurrence of 5 in int array: " + index);

            // Copy a range of elements from double array to new array
            double[] dblArrCopy = new double[3];
            Array.Copy(dblArr, 1, dblArrCopy, 0, 3);
            Console.WriteLine("\nCopied range of double array:");
            Console.WriteLine("dblArrCopy: " + string.Join(", ", dblArrCopy));

            // Insert new element in string array at index 2
            Array.Resize(ref strArr, strArr.Length + 1);
            Array.Copy(strArr, 2, strArr, 3, strArr.Length - 3);
            strArr[2] = "coconut";
            Console.WriteLine("\nString array with new element inserted:");
            Console.WriteLine("strArr: " + string.Join(", ", strArr));

            // Remove element from int array at index 3
            for (int i = 3; i < intArr.Length - 1; i++)
            {
                intArr[i] = intArr[i + 1];
            }
            Array.Resize(ref intArr, intArr.Length - 1);
            Console.WriteLine("\nInt array with element at index 3 removed:");
            Console.WriteLine("intArr: " + string.Join(", ", intArr));
        }
    }
}
