using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAssignment
{
    internal class ArithmeticA1
    {
        public delegate void Operation(int num1, int num2);
        internal class Assignment1_que1
        {
            public void AddNumber(int num1, int num2)
            {
                int sum = num1 + num2;
                Console.WriteLine($"Addition of {num1} and {num2} is: {sum}");
            }

            public void MultiplyNumber(int num1, int num2)
            {
                int product = num1 * num2;
                Console.WriteLine($"Multiplication of {num1} and {num2} is: {product}");
            }
        }
    }
}
