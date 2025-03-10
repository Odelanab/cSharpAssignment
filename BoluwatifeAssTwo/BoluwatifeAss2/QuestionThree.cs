using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoluwatifeAss2
{
    public static class QuestionThree
    {
        public static void NumberOne()
        {
            //Facebook Likes
            List<string> likes = new List<string>(); // Create a list to store names
            while (true) // Infinite loop to collect names
            {
                Console.Write("Enter a name (or press Enter to finish): ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name)) // If user presses Enter without input, exit loop
                    break;
                likes.Add(name); // Add name to the list
            }
            // Display message based on the number of likes
            if (likes.Count == 1)
                Console.WriteLine($"{likes[0]} likes your post.");
            else if (likes.Count == 2)
                Console.WriteLine($"{likes[0]} and {likes[1]} like your post.");
            else if (likes.Count > 2)
                Console.WriteLine($"{likes[0]}, {likes[1]} and {likes.Count - 2} others like your post.");

        }
        public static void NumberTwo()
        {
            //Reverse Name
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine(); // Read name input
            char[] reversedArray = userName.ToCharArray();  // Convert name to character array
            Array.Reverse(reversedArray); // Reverse the character array
            string reversedName = new string(reversedArray); // Convert back to string
            Console.WriteLine("Reversed Name: " + reversedName);
        }

        public static void NumberThree()
        {
            //Unique Sorted Numbers
            HashSet<int> uniqueNumbers = new HashSet<int>(); // HashSet to store unique numbers
            while (uniqueNumbers.Count < 5) // Loop until 5 unique numbers are entered
            {
                Console.Write("Enter a unique number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (!uniqueNumbers.Add(number)) // Add returns false if number is already in the set
                    Console.WriteLine("Number already entered. Try again.");
            }
            // Convert HashSet to List and sort it
            var sortedNumbers = uniqueNumbers.ToList();
            sortedNumbers.Sort(); // Sort numbers in ascending order
            Console.WriteLine("Sorted Numbers: " + string.Join(", ", sortedNumbers));
        }
        public static void NumberFour()
        {
            //Display Unique Numbers 
            HashSet<int> enteredNumbers = new HashSet<int>(); // HashSet to store unique entries
            while (true) //// Infinite loop to collect numbers
            {
                Console.Write("Enter a number or type 'Quit' to exit: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit") // Exit loop when user types "Quit"
                    break;
                enteredNumbers.Add(Convert.ToInt32(input)); // Convert and add number to set
            }
            Console.WriteLine("Unique numbers entered: " + string.Join(", ", enteredNumbers));
        }
        public static void NumberFive()
        {
            //Display 3 Smallest Numbers
            while (true) // Loop until valid input is provided
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                string inpt = Console.ReadLine();
                // Split input by commas, remove empty spaces, and filter out empty values
                var numberList = inpt.Split(',').Select(n => n.Trim()).Where(n => !string.IsNullOrEmpty(n)).ToList();

                if (numberList.Count < 5) // Validate that at least 5 numbers are entered
                {
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                    continue; // Restart the loop for new input
                }
                // Convert list of strings to integers and sort them
                var number = numberList.Select(int.Parse).OrderBy(n => n) // Sort numbers in ascending order
                    .ToList();
                Console.WriteLine("Smallest 3 numbers: " + string.Join(", ", number.Take(3)));// Display first 3 numbers
                break;// Exit the loop after processing valid input
            }
            }
        }
}
