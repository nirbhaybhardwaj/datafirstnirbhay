using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    //Swaping Two Number
    class Program1
    {
        static void Main(String[] args)
        {
            int x, y;
            x = 10;
            y = 5;
            Console.WriteLine("Before Swap x="+ x + "y="+y);
            x = x * y;
            y = x / y;
            x = x / y;
            Console.WriteLine("After Swap x=" + x + "y=" + y);
        }
    }
}
