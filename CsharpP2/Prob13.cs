using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP2
{
    public class Prob13
    {
        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public void Move(int deltaX, int deltaY)
            {
                X += deltaX;
                Y += deltaY;
            }
        }

    }
}
