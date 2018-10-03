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
                mode = UserInput.GetStringInput("Which calculator mode do you want?\n\t1\tNumber mode\n\t2\tDate mode");
            } while (!(mode == "1" | mode == "2"));
            return mode;
        }

        public static void Main(string[] args)
        {
            PrintWelcomeMessage();

            while (true)
            {
                string calculationMode = GetCalculationMode();
                if (calculationMode == "1")
                {
                    NumberCalculator.PerformOneNumberCalculation();
                } else if (calculationMode == "2")
                {
                    DateCalculator.PerformOneDateCalculation();
                }
            }            
        }
    }
    
    

}
