using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoluwatifeAssThree
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Creating a stack instance using the IStack interface
                IStack stack = new Stack();

                // Adding items to the stack
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                // Removing and printing items from the stack (LIFO order)
                Console.WriteLine(stack.Pop()); // Output: 3
                Console.WriteLine(stack.Pop()); // Output: 2
                Console.WriteLine(stack.Pop()); // Output: 1

                // Uncomment this to test popping from an empty stack
                // Console.WriteLine(stack.Pop()); // Should throw an exception
            }
            catch (Exception ex)
            {
                // Catches and displays any errors that occur
                Console.WriteLine("Error: " + ex.Message);
            }

            // Keeps the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}

