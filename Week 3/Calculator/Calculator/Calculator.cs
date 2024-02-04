using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        public float Number1;
        public float Number2;
        public Calculator(float number1 = 10, float number2 = 10)
        {
            Number1 = number1;
            Number2 = number2;
        }
        public void ChangeValues(float number1, float number2)
        {
            Number1 = number1;
            Number2 = number2;
            Console.WriteLine("Values changed successfully.");
        }
        public float Add()
        {
            return Number1 + Number2;
        }
        public float Subtract()
        {
            return Number1 - Number2;
        }
        public float Multiply()
        {
            return Number1 * Number2;
        }
        public float Divide() 
        {
                float result = Number1 / Number2;
                return result;
        }
        public float Modulo()
        {
                float result = Number1 % Number2;
                return result;
        }
    }
}
