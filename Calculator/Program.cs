using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 * num2;
            Console.WriteLine("The product of those two numbers is: {0}", result);
            Console.ReadLine();
        }
    }
}
