using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoluwatifeAss2
{
    public static class QuestionOne
    {
        public static void NumberOne()
        {
            //Validate Number Between 1 and 10
            Console.WriteLine("Enter a number between 1 and 10"); // Prompt user for input
            int number = Convert.ToInt32(Console.ReadLine());  // Read input and convert to integer

            if (number >= 1 && number <=10)

                Console.WriteLine("Valid"); // Display "Valid" if within range
            else
                Console.WriteLine("Invalid"); // Display "Invalid" if out of range
        }
        public static void NumberTwo()
        {
            //Find Maximum of Two Numbers
            Console.WriteLine("Enter first numer"); // Prompt user for input
            int num1 = Convert.ToInt32(Console.ReadLine());  // Read the first number

            Console.WriteLine("Enter second numer"); // Prompt user for input
            int num2 = Convert.ToInt32(Console.ReadLine());// Read the second number

            // Use Math.Max to find and display the maximum of the two numbers
            Console.WriteLine("Maximum: " + Math.Max(num1, num2));
        }

        public static void NumberThree()
        {
            //Determine Image Orientation
            Console.WriteLine("Enter the width of the image"); // Prompt user for input
            int width = Convert.ToInt32(Console.ReadLine()); // Read image width

            Console.WriteLine("Enter the height of the image"); // Prompt user for input
            int height = Convert.ToInt32(Console.ReadLine()); // Read image height

            // Determine if the image is Landscape or Portrait
            if (width>height)
                Console.WriteLine("Landscape"); // Width is greater, so it's a landscape
            else
                Console.WriteLine("Portrait");  // Otherwise, it's a portrait
        }

        public static void NumberFour()
        {
            //Speed Camera Logic
            Console.WriteLine("Enter the speed Limit"); // Prompt user for input
            int speedLimit = Convert.ToInt32(Console.ReadLine()); // Read speed limit

            Console.WriteLine("Enter the car Limit"); // Prompt user for input
            int carSpeed = Convert.ToInt32(Console.ReadLine());  // Read car speed

            if (carSpeed <= speedLimit)
                Console.WriteLine("OK");  // If speed is within limit, display "Ok"
            else
            {
                // Calculate the number of demerit points (1 point for every 5 km/h over the limit)
                int demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine("Demerit points: " + demeritPoints);

                // If demerit points exceed 12, the license is suspended
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
            }
        }
    }
}
