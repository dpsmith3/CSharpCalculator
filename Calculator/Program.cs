using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");

            Console.WriteLine("Please enter the operator: ");
            string operator1 = Console.ReadLine();

            Console.WriteLine("How many numbers to do you want to {0}", operator1);
            int iterations = int.Parse(Console.ReadLine());

            float[] numbers = new float[iterations];
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine("Please enter number {0}:", i + 1);
                numbers[i] = float.Parse(Console.ReadLine());
            }

            if (operator1 == "+")
            {
                double result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += numbers[i];
                }
                Console.WriteLine("The result is {0}", result);
            } else if (operator1 == "-") {
                double result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result -= numbers[i];
                }
                Console.WriteLine("The result is {0}", result);
            } else if (operator1 == "*")
            {
                double result = 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result *= numbers[i];
                }
                Console.WriteLine("The result is {0}", result);
            } else if (operator1 == "/")
            {
                double result = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    result /= numbers[i];
                }
                Console.WriteLine("The result is {0}", result);
            } else
            {
                Console.WriteLine("The operator you entered is not valid");

            }

            Console.ReadLine();
        }
    }
}
