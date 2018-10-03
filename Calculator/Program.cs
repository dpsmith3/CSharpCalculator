using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public enum Modes {

            numberModeId = 1,
            dateModeId = 2,
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }

        private static int GetCalculationMode()
        {
            int mode;
            
            do
            {
                mode = UserInput.GetInteger("Which calculator mode do you want?\n\t1\tNumber mode\n\t2\tDate mode");
            } while (!Enum.IsDefined(typeof(Modes), mode));
            Logger.logAppend($"Mode {mode} chosen");
            return mode;
        }

        public static void Main(string[] args)
        {
            Logger.startLog($"Starting the calculator");
            PrintWelcomeMessage();
            
            while (true)
            {
                int calculationMode = GetCalculationMode();
                if (calculationMode == (int) Modes.numberModeId)
                {
                    NumberCalculator.PerformOneNumberCalculation();
                } else if (calculationMode == (int) Modes.dateModeId)
                {
                    DateCalculator.PerformOneDateCalculation();
                }
            }            
        }
    }
    
    

}
