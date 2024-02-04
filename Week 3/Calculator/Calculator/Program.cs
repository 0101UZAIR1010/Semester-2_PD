using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Calculator meraCalculator= null;
            int option = 0;

            while (option != 8)
            {
                Console.WriteLine("\n");
                Console.WriteLine("===========Welcome to My Calculator=========");
                Console.WriteLine("| 1. Create a Single Object of Calculator    |"); 
                Console.WriteLine("| 2. Change Values of Attributes             |");
                Console.WriteLine("| 3. Add                                     |");
                Console.WriteLine("| 4. Subtract                                |");
                Console.WriteLine("| 5. Multiply                                |");
                Console.WriteLine("| 6. Divide                                  |");
                Console.WriteLine("| 7. Modulo                                  |");
                Console.WriteLine("| 8. Exit                                    |");
                Console.WriteLine("============================================");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    meraCalculator= new Calculator();
                    Console.WriteLine("Object of the Calculator is succesfully created with give/default values.");
                }
                else if (option == 2)
                {
                    if (meraCalculator!= null)
                    {
                        Console.Write("Enter new value for 1st Number ==>");
                        float newNumber1 = float.Parse(Console.ReadLine());
                        Console.Write("Enter new value for 2nd Number ==>");
                        float newNumber2 = float.Parse(Console.ReadLine());
                        meraCalculator.ChangeValues(newNumber1, newNumber2);
                    }
                    else
                    {
                        Console.WriteLine("Default object not created so go to option 1 and first create it and then TRY AGAIN!!!!");
                    }
                }
                else if (option == 3)
                {
                    if (meraCalculator!= null)
                    {
                        Console.WriteLine("Additon: " + meraCalculator.Add());
                    }
                    else
                    {
                        Console.WriteLine("Object tou create kr lai bhai/behn pehly!");
                    }
                }
                else if (option == 4)
                {
                    if (meraCalculator!= null)
                    {
                        Console.WriteLine("Subtraction: " + meraCalculator.Subtract());
                    }
                    else
                    {
                        Console.WriteLine("Object tou create kr lai bhai/behn pehly!");
                    }
                }
                else if (option == 5)
                {
                    if (meraCalculator!= null)
                    {
                        Console.WriteLine("Multiply: " + meraCalculator.Multiply());
                    }
                    else
                    {
                        Console.WriteLine("Object tou create kr lai bhai/behn pehly!");
                    }
                }
                else if (option == 6)
                {
                    if (meraCalculator!= null)
                    {
                        Console.WriteLine("Divide: " + meraCalculator.Divide());
                    }
                    else
                    {
                        Console.WriteLine("Object tou create kr lai bhai/behn pehly!");
                    }
                }
                else if (option == 7)
                {
                    if (meraCalculator!= null)
                    {
                        Console.WriteLine("Modulo: " + meraCalculator.Modulo());
                    }
                    else
                    {
                        Console.WriteLine("Object tou create kr lai bhai/behn pehly!");
                    }
                }
                else if (option == 8)
                {
                    Console.WriteLine("Calculator bnd ho rha hai........");
                }
                else
                {
                    Console.WriteLine("Ghalat Choice hai bhai! 1-8 kai b/w enter kro!");
                }
            }
            Console.Read();
        }
    }
}


