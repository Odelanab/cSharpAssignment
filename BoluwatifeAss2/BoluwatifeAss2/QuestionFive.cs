using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoluwatifeAss2
{
    public static class QuestionFive
    {
        public static void NumberOne()
        {
            //Count the number of words in the file
            string filePath = @"C:\Users\AMICHAELS\Desktop\Optimus ETL\BoluwatifeAss2\BoluwatifeAss2\test.txt";

            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("Number of words in the file: " + words.Length);
            }
            else
                Console.WriteLine("Rest");
        }

        public static void NumberTwo()
        {
            //string words = Console.ReadLine();
            string filePath = @"C:\Users\AMICHAELS\Desktop\Optimus ETL\BoluwatifeAss2\BoluwatifeAss2\test.txt";

            // Count the number of words in the file
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("Number of words in the file: " + words.Length);

            //Find the longest word in the file
                string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
                Console.WriteLine("Longest word in the file: " + longestWord);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
