using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Runner
    {

        static void Main(string[] args)
        {
            string expression;
            double a = 0;
            double b = 0;
            string sign;
            bool loop = true;
            double result = 0;
            bool wrong;

            const string SUM = "+";
            const string RESIDUAL = "-";
            const string MULTIPLICATION = "*";
            const string QUOTIENT = "/";
            const string EXIT = "exit";

            while (loop)
            {
                wrong = false;

                Console.Write("Enter math expression (example: a + b): ");
                expression = Console.In.ReadLine();

                string[] elements = expression.Split(' ');

                if (elements[0].Equals(EXIT))
                {
                    loop = false;
                    continue;
                }

                if (elements.Length == 3)
                {

                    try
                    {
                        a = Convert.ToDouble(elements[0]);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("\nYou have entered wrong value 'a' (" + e.Message + ")\n");

                        wrong = true;
                    }

                    sign = elements[1];

                    try
                    {
                        b = Convert.ToDouble(elements[2]);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("\nYou have entered wrong value 'b' (" + e.Message + ")\n");
                        wrong = true;
                    }

                    if (wrong)
                    {
                        continue;
                    }

                    switch (sign)
                    {
                        case SUM:
                            result = Operations.sum(a, b);
                            Operations.printResult(result);
                            break;

                        case RESIDUAL:

                            result = Operations.residual(a, b);
                            Operations.printResult(result);
                            break;

                        case MULTIPLICATION:

                            result = Operations.multiplication(a, b);
                            Operations.printResult(result);
                            break;

                        case QUOTIENT:

                            result = Operations.quotient(a, b);
                            Operations.printResult(result);
                            break;

                        default:
                            Console.WriteLine("Wrong input. Only '+', '-', '*', '/' operators allowed. Input format: a + b\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input. Input format: a + b\n");
                }
            }
        }
    }
}
