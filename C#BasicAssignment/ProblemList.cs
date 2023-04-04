using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicAssignment
{
    public class ProblemList
    {
        public void No_1()
        {
            Console.WriteLine("hello world");
        }

        public void No_2() {

            bool boolType = true;
            char charType = 'C';
            int intType = 123;
            long longType = 1234567890L;
            double doubleType = 123.456;
            float floatType = 12.345f;
            string stringType = "Hello World!";

            Console.WriteLine("boolType: " + boolType);
            Console.WriteLine("charType: " + charType);
            Console.WriteLine("intType: " + intType);
            Console.WriteLine("longType: " + longType);
            Console.WriteLine("doubleType: " + doubleType);
            Console.WriteLine("floatType: " + floatType);
            Console.WriteLine("stringType: " + stringType);

        }
        public void No_3()
        {
            int a = int.MaxValue;
            int b = 2;

            try
            {
                checked
                {
                    int c = a * b;
                    Console.WriteLine(c);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Overflow occurred: {0}", e.Message);
            }
        }
        public void No_4()
        {
            // Implicit conversion from int to double
            int a = 10;
            double b = a;
            Console.WriteLine("Implicit conversion: " + b); // Output: 10.0

            // Explicit conversion from double to int
            double c = 3.14159;
            int d = (int)c;
            Console.WriteLine("Explicit conversion: " + d); // Output: 3

            // Implicit conversion from string to int
            string e = "25";
            int f = Convert.ToInt32(e);
            Console.WriteLine("Implicit conversion: " + f); // Output: 25

            // Explicit conversion from int to string
            int g = 50;
            string h = g.ToString();
            Console.WriteLine("Explicit conversion: " + h); // Output: "50"

            // Implicit conversion from string to long
            string i = "1234567890123";
            long j = Convert.ToInt64(i);
            Console.WriteLine("Implicit conversion: " + j); // Output: 1234567890123

            // Explicit conversion from long to string
            long k = 9876543210;
            string l = k.ToString();
            Console.WriteLine("Explicit conversion: " + l); // Output: "9876543210"

            // Implicit conversion from string to double
            string m = "3.14159";
            double n = Convert.ToDouble(m);
            Console.WriteLine("Implicit conversion: " + n); // Output: 3.14159

            // Explicit conversion from double to string
            double o = 2.71828;
            string p = o.ToString();
            Console.WriteLine("Explicit conversion: " + p); // Output: "2.71828"

            // Implicit conversion from string to float
            string q = "1.2345";
            float r = Convert.ToSingle(q);
            Console.WriteLine("Implicit conversion: " + r); // Output: 1.2345

            // Explicit conversion from float to string
            float s = 6.789f;
            string t = s.ToString();
            Console.WriteLine("Explicit conversion: " + t); // Output: "6.789"

            // Implicit conversion from string to bool
            string u = "true";
            bool v = Convert.ToBoolean(u);
            Console.WriteLine("Implicit conversion: " + v); // Output: True

            // Explicit conversion from bool to string
            bool w = false;
            string x = w.ToString();
            Console.WriteLine("Explicit conversion: " + x); // Output: "False"

            // Implicit conversion from int to long
            int y = 123;
            long z = y;
            Console.WriteLine("Implicit conversion: " + z); // Output: 123

            // Explicit conversion from long to int
            long aa = 9876543210;
            int bb = (int)aa;
            Console.WriteLine("Explicit conversion: " + bb); // Output: -131176846
                                                             // note that this is because the long value is too large to fit in an int, and the conversion causes overflow.

            // Explicit conversion from char to ASCII int
            char cc = 'A';
            int dd = (int)cc;
            Console.WriteLine("Explicit conversion: " + dd); // Output: 65

            // Explicit conversion from ASCII int to char
            int ee = 97;
            char ff = (char)ee;
            Console.WriteLine("Explicit conversion: " + ff); // Output: 'a'

        }
        public void No_5()
        {
            // Addition operator (+)
            int a = 10;
            int b = 20;
            int result = a + b;
            Console.WriteLine("a + b = " + result);

            // Subtraction operator (-)
            int c = 50;
            int d = 30;
            int result2 = c - d;
            Console.WriteLine("c - d = " + result2);

            // Multiplication operator (*)
            int e = 5;
            int f = 6;
            int result3 = e * f;
            Console.WriteLine("e * f = " + result3);

            // Division operator (/)
            int g = 40;
            int h = 8;
            int result4 = g / h;
            Console.WriteLine("g / h = " + result4);

            // Modulus operator (%)
            int i = 17;
            int j = 5;
            int result5 = i % j;
            Console.WriteLine("i % j = " + result5);

            // Bitwise OR operator (|)
            int k = 12; // 1100 in binary
            int l = 25; // 11001 in binary
            int result6 = k | l;
            Console.WriteLine("k | l = " + result6);

            // Bitwise XOR operator (^)
            int m = 12; // 1100 in binary
            int n = 25; // 11001 in binary
            int result7 = m ^ n;
            Console.WriteLine("m ^ n = " + result7);

            // Bitwise AND operator (&)
            int o = 12; // 1100 in binary
            int p = 25; // 11001 in binary
            int result8 = o & p;
            Console.WriteLine("o & p = " + result8);

        }
        public void No_6()
        {
            // Example 1: if statement
            int a = 10;
            if (a > 0)
            {
                Console.WriteLine("a is positive");
            }

            // Output: a is positive

            // Example 2: if else statement
            int b = -5;
            if (b > 0)
            {
                Console.WriteLine("b is positive");
            }
            else
            {
                Console.WriteLine("b is non-positive");
            }

            // Output: b is non-positive

            // Example 3: else if statement
            int c = 0;
            if (c > 0)
            {
                Console.WriteLine("c is positive");
            }
            else if (c < 0)
            {
                Console.WriteLine("c is negative");
            }
            else
            {
                Console.WriteLine("c is zero");
            }

            // Output: c is zero

        }
        public void No_7()
        {
            // Example 1: using &&
            int age = 30;
            bool hasLicense = true;

            if (age >= 18 && hasLicense)
            {
                Console.WriteLine("You can legally drive.");
            }
            else
            {
                Console.WriteLine("You cannot legally drive.");
            }

            // Output: You can legally drive.

            // Example 2: using ||
            int num1 = 10;
            int num2 = 20;

            if (num1 == 5 || num2 == 10)
            {
                Console.WriteLine("At least one condition is true.");
            }
            else
            {
                Console.WriteLine("Both conditions are false.");
            }

            // Output: Both conditions are false.

        }
        public void No_8()
        {
            // Example 1: using ternary operator for a simple condition
            int a = 10;
            string result = (a > 5) ? "a is greater than 5" : "a is less than or equal to 5";
            Console.WriteLine(result);

            // Output: a is greater than 5

            // Example 2: using ternary operator with multiple conditions
            int b = 15;
            string result2 = (b > 20) ? "b is greater than 20" :
                             (b > 10) ? "b is greater than 10 but less than or equal to 20" :
                             "b is less than or equal to 10";
            Console.WriteLine(result2);

            // Output: b is greater than 10 but less than or equal to 20

        }
        public void No_9()
        {
            // Single-line comment

            /*
            Multi-line
            comment
            */

            /// <summary>
            /// XML documentation comment
            /// </summary>
            int a = 5; // initialize the variable 'a' with the value 5
            /*
                int a = 5;
                int b = 10;
            */
            /// <summary>
            /// This method adds two numbers together and returns the result.
            /// </summary>
            /// <param name="a">The first number to add.</param>
            /// <param name="b">The second number to add.</param>
            /// <returns>The sum of the two numbers.</returns>
    




        }
        public void No_10()
        {
            
            //Using for loop
            for (int iterator = 1; iterator <= 100; iterator++)
            {
                if (iterator == 95)
                {
                    // Skip number 95
                    continue;
                }

                Console.WriteLine(iterator);

                if (iterator == 99)
                {
                    // Break the loop at number 99
                    break;
                }
            }

            //Using while loop
            int whileIterator = 1;
            while (whileIterator <= 100)
            {
                if (whileIterator == 95)
                {
                    // Skip number 95
                    whileIterator++;
                    continue;
                }

                Console.WriteLine(whileIterator);

                if (whileIterator == 99)
                {
                    // Break the loop at number 99
                    break;
                }

                whileIterator++;
            }

            //Using do while loop
            int doWhileiterator = 1;
            do
            {
                if (doWhileiterator == 95)
                {
                    // Skip number 95
                    doWhileiterator++;
                    continue;
                }

                Console.WriteLine(doWhileiterator);

                if (doWhileiterator == 99)
                {
                    // Break the loop at number 99
                    break;
                }

                doWhileiterator++;
            } while (doWhileiterator <= 100);




            //Using foreach loop
            int[] numbers = Enumerable.Range(1, 100).ToArray();

            foreach (int number in numbers)
            {
                if (number == 95)
                {
                    // Skip number 95
                    continue;
                }

                Console.WriteLine(number);

                if (number == 99)
                {
                    // Break the loop at number 99
                    break;
                }
            }

        }
        public void No_11()
        {
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

        }


    }
}
