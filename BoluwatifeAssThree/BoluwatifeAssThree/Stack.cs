using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoluwatifeAssThree
{
    class Stack : IStack
    {

        // Internal list to store stack elements
        private List<object> _items = new List<object>();

        /// <summary>
        /// Adds an object to the stack.
        /// Throws an exception if the object is null.
        /// </summary>
        /// <param name="obj">The object to be added to the stack.</param>
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null values cannot be added to the stack.");

            _items.Add(obj); // Add object to the end of the list (top of stack)
        }

        /// <summary>
        /// Removes and returns the last object added to the stack.
        /// Throws an exception if the stack is empty.
        /// </summary>
        /// <returns>The last object added (top of the stack).</returns>
        public object Pop()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Stack is empty. Cannot pop an item.");

            // Get the last item in the stack
            object topItem = _items[_items.Count - 1];

            // Remove it from the list
            _items.RemoveAt(_items.Count - 1);

            return topItem; // Return the removed item
        }

        /// <summary>
        /// Clears all elements from the stack.
        /// </summary>
        public void Clear()
        {
            _items.Clear(); // Removes all items from the list
        }
    }
}