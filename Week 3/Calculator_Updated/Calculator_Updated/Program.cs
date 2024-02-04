using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Updated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator meraCalculator = null;
            int option = 0;

            while (option != 8)
            {
                Console.WriteLine("\n");
                Console.WriteLine("===========Welcome to My Calculator=========");
                Console.WriteLine("| 1  Create a Single Object of Calculator    |");
                Console.WriteLine("| 2  Change Values of Attributes             |");
                Console.WriteLine("| 3  Add                                     |");
                Console.WriteLine("| 4  Subtract                                |");
                Console.WriteLine("| 5  Multiply                                |");
                Console.WriteLine("| 6  Divide                                  |");
                Console.WriteLine("| 7  Modulo                                  |");
                Console.WriteLine("| 8  Exit                                    |");
                Console.WriteLine("| 9  Square Root (sqrt)                      |");
                Console.WriteLine("| 10 Exponential Function (exp)             |");
                Console.WriteLine("| 11 Logarithm (log)                        |");
                Console.WriteLine("| 12 Sine (sin)                             |");
                Console.WriteLine("| 13 Cosine (cos)                           |");
                Console.WriteLine("| 14 Tangent (tan)                          |");
                Console.WriteLine("============================================");

                option = int.Parse(Console.ReadLine()); 

                if (option == 1)
                {
                    meraCalculator = new Calculator();
                    Console.WriteLine("Object of the Calculator is successfully created with given/default values.");
                }
                else if (option == 2)
                {
                    if (meraCalculator != null)
                    {
                        Console.Write("Enter new value for 1st Number ==>");
                        float newNumber1 = float.Parse(Console.ReadLine());
                        Console.Write("Enter new value for 2nd Number ==>");
                        float newNumber2 = float.Parse(Console.ReadLine());
                        meraCalculator.ChangeValues(newNumber1, newNumber2);
                    }
                    else
                    {
                        Console.WriteLine("Default object not created. Please go to option 1 and create it first.");
                    }
                }
                else if (option == 3)
                {
                    PerformOperation(meraCalculator, meraCalculator.Add, "Addition");
                }
                else if (option == 4)
                {
                    PerformOperation(meraCalculator, meraCalculator.Subtract, "Subtraction");
                }
                else if (option == 5)
                {
                    PerformOperation(meraCalculator, meraCalculator.Multiply, "Multiplication");
                }
                else if (option == 6)
                {
                    PerformOperation(meraCalculator, meraCalculator.Divide, "Division");
                }
                else if (option == 7)
                {
                    PerformOperation(meraCalculator, meraCalculator.Modulo, "Modulo");
                }
                else if (option == 8)
                {
                    PerformScientificOperation(meraCalculator, meraCalculator.Sqrt, "Square Root");
                }
                else if (option == 9)
                {
                    PerformScientificOperation(meraCalculator, meraCalculator.Exp, "Exponential Function");
                }
                else if (option == 10)
                {
                    PerformScientificOperation(meraCalculator, meraCalculator.Log, "Logarithm");
                }
                else if (option == 11)
                {
                    PerformScientificOperation(meraCalculator, meraCalculator.Sin, "Sine");
                }
                else if (option == 12)
                {
                    PerformScientificOperation(meraCalculator, meraCalculator.Cos, "Cosine");
                }
                else if (option == 13)
                {
                    PerformScientificOperation(meraCalculator, meraCalculator.Tan, "Tangent");
                }
                else if (option == 14)
                {
                    Console.WriteLine("Calculator bnd ho rha hai ........");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 14.");
                }
            }
        }
        public static void PerformOperation(Calculator calculator, Func<float> operation, string operationName)
        {
            if (calculator != null)
            {
                Console.WriteLine($"{operationName}: {operation()}");
            }
            else
            {
                Console.WriteLine("Calculator object not created. Please go to option 1 and create it first.");
            }
        }
        public static void PerformScientificOperation(Calculator calculator, Func<float, float> operation, string operationName)
        {
            if (calculator != null)
            {
                Console.Write($"Enter the parameter for {operationName}: ");
                float parameter = float.Parse(Console.ReadLine());
                Console.WriteLine($"{operationName}: {operation(parameter)}");
            }
            else
            {
                Console.WriteLine("Calculator object not created. Please go to option 1 and create it first.");
            }
            Console.Read();
        }
    }
}
