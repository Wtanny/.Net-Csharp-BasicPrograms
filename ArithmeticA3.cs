using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAssignment
{
    public class ArithmeticA3
    {
        public int Add(int a, int b) => a + b;
        public int Multiply(int a, int b) => a * b;

        delegate int Operation(int a, int b);

        public class Calculator
        {
            public void PerformOperation()
            {
                ArithmeticA3 arithmetic = new ArithmeticA3();
                Operation operation;

                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Multiplication");
                Console.WriteLine("3. Both");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                
                 {
                    case 1:
                        operation = arithmetic.Add;
                        break;
                    case 2:
                        operation = arithmetic.Multiply;
                        break;
                    case 3:
                        operation = (a, b) =>
                        {
                            int sum = arithmetic.Add(a, b);
                            int product = arithmetic.Multiply(a, b);
                            Console.WriteLine($"Sum: {sum}, Product: {product}");
                            return sum + product;
                            Console.ReadKey();

                        };
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        return;
                }

                int result = operation.Invoke(num1, num2);
                Console.WriteLine($"Result: {result}");
                Console.ReadKey();
            }
        }
    }
}




















    
             
       
