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

            // declaring the input of the user
            double num1 = 0; double num2 = 0;

            // greating the user
            Console.WriteLine("Super awesome Calculator");
            Console.WriteLine("");

            //ask user for first number
            Console.Write("Type a number, than press enter: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            // ask user for secong number
            Console.WriteLine("Type another number, and then press enter: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            // Asking the user what they wanna do with these numbers
            Console.WriteLine("Choose from the following list: ");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtact");
            Console.WriteLine("\tm - mulltiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option?");

            // statement to do math
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

            // letting the user see the result than exit
            Console.Write("Press enter to close app bro bro");
            Console.ReadLine();



        }
    }
}
