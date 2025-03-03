using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoluwatifeAss2
{
    public static class QuestionTwo
    {
        public static void NumberOne()
        {
            //Count Numbers Divisible by 3 
            int count = 0;
            for (int i = 1; i <= 100; i++)  // Loop from 1 to 100
            {

                if (i % 3 == 0)  // Check if number is divisible by 3
                {
                    count++;  // Increment count
                }
            }
            Console.WriteLine("Numbers between 1 and 100 that are divisible by 3: " + count);
        }

        public static void NumberTwo()
        {
            //Sum of Entered Numbers Until "ok"

            int sum = 0;
            while (true)  // Infinite loop until "ok" is entered
            {
                Console.Write("Enter a number or type 'ok' to exit: "); // Prompt user for input
                string input = Console.ReadLine();
               if (input.ToLower() == "ok") // Check if user wants to exit
                    break;
               sum += Convert.ToInt32(input); // Convert input to integer and add to sum
            }
            Console.WriteLine("Sum of numbers: " + sum);
        }

        public static void NumberThree()
        {
            //Compute Factorial

            Console.Write("Enter a number to compute factorial: ");
            int number = Convert.ToInt32(Console.ReadLine()); // Read number input
            int factorial = 1;
            for (int i = number; i > 1; i--) // Loop from number down to 1
            {
                factorial *= i;  // Multiply factorial by current number
            }
            Console.WriteLine($"{number}! = {factorial}");  // Display factorial result
        }

        public static void NumberFour()
        {
            //Guess the Random Number
            Random random = new Random();
            int secretNumber = random.Next(1, 11); // Generates number between 1 and 10
            Console.WriteLine("(Secret Number: " + secretNumber + ")"); // Display secret number (for testing)

            bool isGuessed = false;
            for (int attempts = 0; attempts < 4; attempts++)  // Give user 4 chances to guess
            {
                Console.Write("Guess the number (1-10): ");
                int guess = Convert.ToInt32(Console.ReadLine()); // Read user guess

                if (guess == secretNumber) // Check if guess is correct
                {
                    Console.WriteLine("You won!");
                   isGuessed = true; // Set flag to true
                    break; // Exit loop since user guessed correctly
                }
            }
            if (!isGuessed) // If user did not guess correctly in 4 attempts
                Console.WriteLine("You lost!");
        }

        public static void NumberFive()
        {
            //Find the Maximum Number in a Series

            Console.Write("Enter numbers separated by commas: ");
            string[] inputs = Console.ReadLine().Split(','); // Read input and split by comma
            int[] numbers = Array.ConvertAll(inputs, int.Parse); // Convert input string array to integer array
            Console.WriteLine("Maximum number: " + numbers.Max());  // Use LINQ to get max value
        }
    }
}
