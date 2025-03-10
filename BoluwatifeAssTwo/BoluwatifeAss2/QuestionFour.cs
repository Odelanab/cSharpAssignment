using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoluwatifeAss2
{
    public static class QuestionFour
    {
        public static void NumberOne()
        {
            //Check if numbers are consecutive
            Console.Write("Enter numbers separated by hyphens: ");
            string input = Console.ReadLine();
            // Convert input string into a list of integers
            var numbers = input.Split('-').Select(int.Parse).ToList();
            // Assume numbers are consecutive in both ascending and descending order
            bool isAscending = true, isDescending = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1) // Check for ascending sequence
                    isAscending = false;
                if (numbers[i] != numbers[i - 1] - 1) // Check for descending sequence
                    isDescending = false;
            }
            // If either ascending or descending is true, numbers are consecutive
            Console.WriteLine(isAscending || isDescending ? "Consecutive" : "Not Consecutive");
        }

        public static void NumberTwo()
        {
            //Check for duplicates
            Console.Write("Enter numbers separated by hyphens: ");
            string input = Console.ReadLine();
            // If input is empty, exit the program
            if (string.IsNullOrWhiteSpace(input))
                return;
            // Convert input into a list of integers
            var numList = input.Split('-').Select(int.Parse).ToList();
            // Check if the list contains duplicates by comparing its count with the distinct count
            bool hasDuplicates = numList.Count != numList.Distinct().Count();
            Console.WriteLine(hasDuplicates ? "Duplicate" : "No Duplicates");
        }

        public static void NumberThree()
        {
            //Validate 24-hour time format
            Console.Write("Enter a time in 24-hour format (HH:MM): ");
            string input = Console.ReadLine();
            // Use TimeSpan.TryParse to check if input is in correct HH:MM format and within valid range
            if (TimeSpan.TryParse(input, out TimeSpan time) && time.TotalMinutes >= 0 && time.TotalMinutes < 1440)
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid Time");
        }

        public static void NumberFour()
        {
            //Convert to PascalCase
            Console.Write("Enter words separated by spaces: ");
            string input = Console.ReadLine();
            // Convert input into PascalCase by capitalizing the first letter of each word
            var pascalCase = string.Join("", input.Split(' ').Select(w => char.ToUpper(w[0]) + w.Substring(1).ToLower()));
            Console.WriteLine("PascalCase: " + pascalCase);

        }
        public static void NumberFive()
        {
            //Count vowels in a word
            Console.Write("Enter a word: ");
            string input = Console.ReadLine().ToLower();// Convert input to lowercase for case-insensitive comparison
            int vowelCount = input.Count(c => "aeiou".Contains(c)); // Count occurrences of vowels (a, e, i, o, u) in the input word
            Console.WriteLine("Number of vowels: " + vowelCount);
        }

        }
}
