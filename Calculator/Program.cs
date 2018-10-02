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

        private static string GetCalculationMode()
        {
            string mode;
            do
            {
                mode = GetStringInput("Which calculator mode do you want?\n\t1\tNumber mode\n\t2\tDate mode");
            } while (!(mode == "1" | mode == "2"));
            return mode;
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

        private static float GetFloat(string prompt)
        {
            string rawInput;
            do
            {
                rawInput = GetStringInput(prompt);
            } while (!float.TryParse(rawInput, out float result));
            float number = float.Parse(rawInput);
            return number;
        }

        private static int GetInteger(string prompt)
        {
            string rawInput;
            do
            {
                rawInput = GetStringInput(prompt);
            } while (!int.TryParse(rawInput, out int result));
            int integer = int.Parse(rawInput);
            return integer;
        }

        private static float[] GetNumberArray(string op)
        {
            int iterations;
            do
            {
                iterations = GetInteger($"How many numbers to do you want to {op}");
            } while (iterations < 1);

            float[] numbers = new float[iterations];
            for (int i = 0; i < iterations; i++)
            {
                numbers[i] = GetFloat($"Please enter number {i + 1}");
            }
            return numbers;
        }

        private static float CalculateAnswer(string op, float[] numbers)
        {
            float result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
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
        private static void PerformOneNumberCalculation()
        {
            string op = GetOperator("\nPlease enter the operator: ");
            float[] numbers = GetNumberArray(op);
            float result = CalculateAnswer(op, numbers);
            Console.WriteLine($"The answer is {result}");
        }

        private static DateTime GetDate()
        {
            string rawDate;
            do
            {
                rawDate = GetStringInput("Please enter a date in the format mm/dd/yy");
            } while (!DateTime.TryParse(rawDate, out DateTime result));
            DateTime date = DateTime.Parse(rawDate);
            return date;
        }

        private static DateTime CalculateDate(DateTime date, int daysToAdd)
        {
            DateTime newDate = date.AddDays(daysToAdd);
            return newDate;            
        }
        private static void PerformOneDateCalculation()
        {
            DateTime date = GetDate();
            int daysToAdd = GetInteger("How many days would you like to add?");
            DateTime newDate = CalculateDate(date, daysToAdd);
            Console.WriteLine($"The result is {newDate}");
        }

        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            while (true)
            {
                string calculationMode = GetCalculationMode();
                if (calculationMode == "1")
                {
                    PerformOneNumberCalculation();
                } else if (calculationMode == "2")
                {
                    PerformOneDateCalculation();
                }
            }            
        }
    }
}
