using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0; double num2 = 0;
            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("");


            Console.Write("Type a number, than press enter: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type another number, and then press enter: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose from the following list: ");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtact");
            Console.WriteLine("\tm - mulltiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option?");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;

                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;

                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;

                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.Write("Press enter to close app bro bro");
            Console.ReadLine();



        }
    }
}
