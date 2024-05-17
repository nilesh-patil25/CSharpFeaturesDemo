using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace C__12_Features.RefReadOnly
{
    public class RefReadOnly
    {
        //The ref readonly parameter modifier is used to pass a reference to a value type by reference, but the value cannot be modified. This is useful when you want to pass a large value type to a method without copying it. The ref readonly modifier can be used with both value types and reference types.
        //The ref readonly modifier can only be used with in parameters.
        //The in parameter modifier is used to pass a value type by reference, but the value cannot be modified.
        //The in parameter modifier is used to optimize performance by avoiding unnecessary copying of large value types.
        //The in parameter modifier can be used with both value types and reference
        #region Member Functions
        /// <summary>
        /// implement In type parameter instead of the ref readonly
        /// </summary>
        /// <param name="number"></param>
        public void Main(int number)
        {
            try
            {
                int num = 90;
                PrintNumber(in num);
                Console.WriteLine(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        /// <summary>
        /// print and try to update value
        /// </summary>
        public void PrintNumber(in int number)
        {
            Console.WriteLine(number);
             //number++ cannot modify the number in this methods;
        }
        #endregion
    }
}
