using System;
using System.Collections.Generic;
using System.Linq;

namespace CircleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Welcome to the Circle Tester");
            bool runProgram = true;
            List<Circle> inputList = new List<Circle>();
            while (runProgram)
            {
                Console.WriteLine("Enter radius");
                try
                {
                    double radius = double.Parse(Console.ReadLine());
                    if (radius <= 0)
                    {
                        Console.WriteLine("Please enter a number more than 0");
                    }
                    else if (radius > 0)
                    {
                        Circle circle = new Circle(radius);
                        count++;
                        inputList.Add(circle);
                        Console.WriteLine("Circumference: " + circle.CalculateFormattedCircumference());
                        Console.WriteLine("Area:" + circle.CalculateFormattedArea());
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                runProgram = GetContinue();
                if (runProgram == false)
                {
                    Console.WriteLine($"Goodbye. You created {inputList.Count} circles.");
                }
            }
        }
        static bool GetContinue()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine("Would you like to continue? y/n");
                String input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    result = true;
                    break;
                }
                else if (input == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That wasn't a valid input.");
                }
            }
            return result;
        }
    }
}
