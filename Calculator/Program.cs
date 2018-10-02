using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }

        private static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        private static string GetOperator(string prompt)
        {
            string op;
            do
            {
                op = GetStringInput(prompt);
            } while (!(op == "+" | op == "-" | op == "/" | op == "*"));
            return op;
        }

        private static float GetNumber(string prompt)
        {
            string rawInput;
            float number;
            do
            {
                rawInput = GetStringInput(prompt);
            } while (!float.TryParse(rawInput, out float result));
            number = float.Parse(rawInput);
            return number;
        }

        private static float[] GetNumberArray(string op)
        {
            int iterations = int.Parse(GetStringInput($"How many numbers to do you want to {op}"));

            float[] numbers = new float[iterations];
            for (int i = 0; i < iterations; i++)
            {
                numbers[i] = GetNumber($"Please enter number {i + 1}");
            }
            return numbers;
        }

        private static float CalculateAnswer(string op, float[] numbers)
        {
            float result = numbers[0];
            for (int i = 1; i < numbers.Length; i ++)
            {
                if (op == "+")
                {
                    result += numbers[i];
                }
                else if (op == "-")
                {
                    result -= numbers[i];
                }
                else if (op == "*")
                {
                    result *= numbers[i];
                }
                else if (op == "/")
                {
                    result /= numbers[i];
                }
            }
            return result;
        }
        private static void PerformOneCalculation()
        {
            string op = GetOperator("\nPlease enter the operator: ");
            float[] numbers = GetNumberArray(op);
            float result = CalculateAnswer(op, numbers);
            Console.WriteLine($"The answer is {result}");
        }
        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            while (true)
            {
                PerformOneCalculation();
            }            
        }
    }
}
