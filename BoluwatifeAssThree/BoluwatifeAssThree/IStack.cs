using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoluwatifeAssThree
{
    public interface IStack
    {

        /// <summary>
        /// Adds an object to the stack.
        /// </summary>
        /// <param name="obj">The object to be added.</param>
        void Push(object obj);


        /// <summary>
        /// Removes and returns the last object added to the stack.
        /// Throws an exception if the stack is empty.
        /// </summary>
        /// <returns>The last object added to the stack.</returns>
        object Pop();

        /// <summary>
        /// Removes all objects from the stack.
        /// </summary>
        void Clear();

    }
}
   
