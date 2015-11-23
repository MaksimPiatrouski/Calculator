using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operations
    {


        public static double sum(double a, double b)
        {
            return a + b;
        }

        public static double residual(double a, double b)
        {
            return a - b;
        }


        public static double multiplication(double a, double b)
        {

            return a * b;
        }

        public static double quotient(double a, double b)
        {
            if (b != 0)
            {
                double result = a / b;
                return Math.Round(result, 5);
            }
            else
            {
                Console.WriteLine("Unable to divide by 0\n");
                return 0;
            }
        }

        public static void printResult(double result)
        {
            Console.WriteLine("result: " + result + "\n");
        }
    }
}
