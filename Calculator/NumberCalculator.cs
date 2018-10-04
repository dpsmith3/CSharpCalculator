using System;
using System.Linq;
using System.Collections.Generic;

namespace Calculator
{
    class NumberCalculator
    {
        private static List<float> GetNumbers(string op)
        {
            List<float> numbers = new List<float>();
            Console.WriteLine($"Please enter the numbers you would like to {op}");
            
            bool keepReadingNumbers = true;
            while (keepReadingNumbers)
            {
                Console.WriteLine("  Please enter the next number (or press return to perform calculation): ");
                if (float.TryParse(Console.ReadLine(), out float result))
                {
                    numbers.Add(result);
                }
                else if (numbers.Count < 1)
                {

                }
                else
                {
                    keepReadingNumbers = false;
                }
            }
            return numbers;
        }

        private static float CalculateAnswer(string op, List<float> numbers)
        {
            string logMessage = $"{numbers[0]} ";
                        
            for (int i = 1; i < numbers.Count; i++)
            {
                logMessage += $"{op} {numbers[i]} ";
            }

            float result;

            switch (op)
            {
                case "+":
                    result = numbers.Sum();
                    break;
                case "-":
                    result = numbers.Aggregate((acc, curr) => (acc - curr));
                    break;
                case "*":
                    result = numbers.Aggregate((acc, curr) => (acc * curr));
                    break;
                case "/":
                    result = numbers.Aggregate((acc, curr) => (acc / curr));
                    break;
                default:
                    result = -1;
                    throw new Exception("Error calculating answer.");
            }

            logMessage += $"= {result}";
            Logger.logAppend(logMessage);
            return result;
        }
        public static void PerformOneNumberCalculation()
        {
            string op = UserInput.GetOperator("\nPlease enter the operator: ");
            List<float> numbers = GetNumbers(op);

            try
            {
                float result = CalculateAnswer(op, numbers);
                Console.WriteLine($"The answer is {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error when calculating the number: " + e.Message);
                Logger.logAppend("There was an error when calculating the number: " + e.Message);
            }
        }
    }
}
