using System;
using System.Net.Mime;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int radius;
            string userInput;
            Circle testCircle;
            double circumference;
            double area;
            bool NotANumber;

            //Initializations
            radius = 0;
            userInput = "";
            testCircle = new Circle();
            circumference = 0;
            area = 0;
            NotANumber = true;

            Console.WriteLine("Please enter the radius for the circle: ");
            try
            {
                radius = int.Parse(Console.ReadLine());
                if (radius <= 0)
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a number.");
            }

            do
            {
                Console.WriteLine("1. Get Circle Radius");
                Console.WriteLine("2. Change Circle Radius");
                Console.WriteLine("3. Get Circle Circumference");
                Console.WriteLine("4. Get Circle Area");
                Console.WriteLine("5. Exit");
                userInput = Console.ReadLine();
                if (userInput != "")
                {
                    NotANumber = false;
                }
                else
                {
                    NotANumber = true;
                }
            } while (!NotANumber);

            if (userInput == "1")
            {
                radius = testCircle.GetRadius();
                Console.WriteLine("Radius Retrieved: " + radius.ToString());
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Please enter a new radius: ");
                radius = int.Parse(Console.ReadLine());
                if (radius >= 1)
                {
                    testCircle.SetRadius(radius);
                    Console.WriteLine("Radius Successfully Changed: " + testCircle.GetRadius());
                }
            }
            else if (userInput == "3")
            {
                circumference = testCircle.GetCircumference();
                Console.WriteLine("The circumference of the circle is: " + circumference);
            }
            else if (userInput == "4")
            {
                area = testCircle.GetArea();
                Console.WriteLine("The area of the circle is: " + area);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
