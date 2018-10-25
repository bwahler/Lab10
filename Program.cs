using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCircles = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the radius of the circle!");
                    double userInput = double.Parse(Console.ReadLine());

                    Circle myCircle = new Circle(userInput);
                    Console.WriteLine($"Circumference: {myCircle.CalculateCircumference()}");
                    Console.WriteLine($"Circumference Formatted! {myCircle.CalculateFormattedCircumference()}");
                    Console.WriteLine($"Area: {myCircle.CalculateArea()}");
                    Console.WriteLine($"Area Formatted: {myCircle.CalculateFormattedArea()}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format is invalid, please try again");
                }

                Console.WriteLine("Would you like to keep going? (y/n)");
                string userContinue = Console.ReadLine().ToLower();
                numberOfCircles++;
                if (userContinue == "y" || userContinue == "Y")
                {
                    continue;
                }
                else if (userContinue == "n" || userContinue == "N")
                {
                    Console.WriteLine("Goodbye. You have created {0} circle objects", + numberOfCircles);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, I did not understand that! Try again (y/n)");
                    userContinue = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
