using System;

namespace Calculator
{
    class UserInput
    {
        public static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static string GetOperator(string prompt)
        {
            string op;
            do
            {
                op = GetStringInput(prompt);
            } while (!(op == "+" | op == "-" | op == "/" | op == "*"));
            return op;
        }

        public static float GetFloat(string prompt)
        {
            string rawInput;
            float number;
            do
            {
                rawInput = GetStringInput(prompt);
            } while (!float.TryParse(rawInput, out number));
            return number;
        }

        public static int GetInteger(string prompt)
        {
            string rawInput;
            int integer;
            do
            {
                rawInput = GetStringInput(prompt);
            } while (!int.TryParse(rawInput, out integer));
            return integer;
        }
    }
}
