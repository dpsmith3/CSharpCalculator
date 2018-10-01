using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }

        static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
            }

        static void PerformOneCalculation()
        {
            string op = GetStringInput("Please enter the operator: ");

            int iterations = int.Parse(GetStringInput($"How many numbers to do you want to {op}"));

            float[] numbers = new float[iterations];
            for (int i = 0; i < iterations; i++)
            {
                numbers[i] = float.Parse(GetStringInput($"Please enter number {i + 1}"));
            }

            if (op == "+")
            {
                double result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += numbers[i];
                }
                Console.WriteLine("The result is {0}", result);
            }
            else if (op == "-")
            {
                double result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result -= numbers[i];
                }
                Console.WriteLine("The result is {0}", result);
            }
            else if (op == "*")
            {
                double result = 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result *= numbers[i];
                }
                Console.WriteLine("The result is {0}", result);
            }
            else if (op == "/")
            {
                double result = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    result /= numbers[i];
                }
                Console.WriteLine("The result is {0}", result);
            }
            else
            {
                Console.WriteLine("The operator you entered is not valid");
            }
        }
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            PerformOneCalculation();
            Console.ReadLine();
        }
    }
}
