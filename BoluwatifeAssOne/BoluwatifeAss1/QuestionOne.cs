using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoluwatifeAss1
{
    public static class QuestionOne
    {
        public static void NumberOne()
        {
            // Area of Trapezium

            // Prompt and read the first base from the user
            Console.Write("Enter the length of the first base (Base1): ");
            double base1 = Convert.ToDouble(Console.ReadLine());

            // Prompt and read the second base from the user
            Console.Write("Enter the length of the second base (Base2): ");
            double base2 = Convert.ToDouble(Console.ReadLine());

            // Prompt and read the height from the user
            Console.Write("Enter the height of the trapezium: ");
            double height = Convert.ToDouble(Console.ReadLine());

            //  Calculate the sum of Base1 and Base2
            double sum = base1 + base2;

            //  Multiply the sum by the height
            double product = sum * height;

            //  Divide the product by 2 to get the area
            double area = product / 2;

            // Display the area as output
            Console.WriteLine($"The area of the trapezium is: {area}");

        }


        public static void NumberTwo()
        {
            // CALCULATOR
            Console.WriteLine("Welcome to Boluwatifes Calculator!");

            // Step 1: Get the first number
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Step 2: Get the second number
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Step 3: Ask the user if they want to add or subtract
            Console.WriteLine("Enter an operator+, -, *, /, %): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;
            bool validOperation = true;


            // Step 4: Perform the operation
            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '%')
            {
                result = num1 % num2;
            }
            else if (operation == '/')
            {
                if (num2 == 0)

                {
                    Console.WriteLine("Error! Division by Zero is not allowed");
                    validOperation = false;
                }
                else
                { result = num1 / num2; }
            }
            else
            {
                Console.WriteLine("Invalid operation! Please enter + or - or * or /.");
                validOperation = false;
            }

            // Step 5: Display the result
            if (validOperation)
            {
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }

            // Step 6: End
            Console.WriteLine("Thank you for using Boluwatifes calculator!");

        }
     }
}
