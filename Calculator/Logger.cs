using System;
using System.IO;

namespace Calculator
{
    class Logger
    {
        public static void startLog(string text)
        {
            File.WriteAllText(@"C:\Work\CSharpTutorial\Calculator\log.txt", $"{DateTime.Now}\t{text}\r\n");
        }
        public static void logAppend(string text)
        { 
            using (StreamWriter file =
                new StreamWriter(@"C:\Work\CSharpTutorial\Calculator\log.txt", true))
            {
                file.WriteLine($"{DateTime.Now} \t {text}");
            }
        }
    }
}
