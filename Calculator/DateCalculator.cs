using System;

namespace Calculator
{
    class DateCalculator
    {
        private static DateTime GetDate()
        {
            string rawDate;
            DateTime date;
            do
            {
                rawDate = UserInput.GetStringInput("Please enter a date in the format mm/dd/yy");
            } while (!DateTime.TryParse(rawDate, out date));
            return date;
        }

        private static DateTime CalculateDate(DateTime date, int daysToAdd)
        {
            DateTime newDate = date.AddDays(daysToAdd);
            return newDate;
        }
        public static void PerformOneDateCalculation()
        {
            DateTime date = GetDate();
            int daysToAdd = UserInput.GetInteger("How many days would you like to add?");
            DateTime newDate = CalculateDate(date, daysToAdd);
            Console.WriteLine($"The result is {newDate}");
            string logMessage = $"{daysToAdd} days after {date} is {newDate}";
            Logger.logAppend(logMessage);
        }
    }
}
