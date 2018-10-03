using System;

namespace Calculator
{
    class NumberCalculator
    {
        private static float[] GetNumberArray(string op)
        {
            int iterations;
            do
            {
                iterations = UserInput.GetInteger($"How many numbers to do you want to {op}");
            } while (iterations < 1);

            float[] numbers = new float[iterations];
            for (int i = 0; i < iterations; i++)
            {
                numbers[i] = UserInput.GetFloat($"Please enter number {i + 1}");
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
        public static void PerformOneNumberCalculation()
        {
            string op = UserInput.GetOperator("\nPlease enter the operator: ");
            float[] numbers = GetNumberArray(op);
            float result = CalculateAnswer(op, numbers);
            Console.WriteLine($"The answer is {result}");
        }
    }
}
