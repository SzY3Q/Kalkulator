using System;
using System.Collections.Generic;
using System.Text;

namespace MyFunctions
{
    class Functions
    {
        public static double Addition(Single a, Single b)
        {
            return a + b;
        }

        public static double Subtraction(Single a, Single b)
        {
            return a - b;
        }

        public static double Multiplication(Single a, Single b)
        {
            return a * b;
        }

        public static double Division(Single a, Single b)
        {
            return a / b;
        }

        public static double Delta(Single a, Single b, Single c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

       
    }
}
