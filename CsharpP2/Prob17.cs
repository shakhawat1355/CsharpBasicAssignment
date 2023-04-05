using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP2
{
    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public class Prob17
    {
        public void printer()
        {
            // convert string to enum
            string colorStr = "Green";
            Color colorEnum = (Color)Enum.Parse(typeof(Color), colorStr);
            Console.WriteLine("Color enum value: " + colorEnum);

            // convert int to enum
            int colorInt = 2;
            colorEnum = (Color)colorInt;
            Console.WriteLine("Color enum value: " + colorEnum);

            // convert enum to string
            string colorStr2 = colorEnum.ToString();
            Console.WriteLine("Color string value: " + colorStr2);

            // convert enum to int
            int colorInt2 = (int)colorEnum;
            Console.WriteLine("Color int value: " + colorInt2);
        }


    }
}
