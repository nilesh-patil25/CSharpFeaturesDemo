//Date: 17 May 2024
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C__12_Features.InlineArray
{
    //Inline arrays are used by the runtime team and other library authors to improve performance in your apps.
    //Inline arrays enable a developer to create an array of fixed size in a struct type. 
    //A struct with an inline buffer should provide performance characteristics similar to an unsafe fixed size buffer.
    public class InlineArray
    {
        /// <summary>
        /// create struct with inline array having i integer data member
        /// </summary>
        [System.Runtime.CompilerServices.InlineArray(10)]
        public struct NumberBuffer
        {
            private int _element0;
        }
        #region Member Functions
        /// <summary>
        /// Add value in struct created by inline array
        /// </summary>
        public void Main()
        {
            try
            {
                var buffer = new NumberBuffer();
                for (int i = 0; i < 10; i++)
                {
                    buffer[i] = i;
                }

                foreach (var i in buffer)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        #endregion

    }
}
