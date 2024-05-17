//Date: 17 May 2024
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using Rect = (int L, int B);
using System.Buffers;

namespace C__12_Features.AnyTypeAlias
{
    public class AliasAnyType
    {
        /*  You can use the using alias directive to alias any type, not just named types.
        That means you can create semantic aliases for tuple types, array types, pointer types, or other unsafe types.*/
        #region Member Functions
        /// <summary>
        /// use of any type of alias i.e.Rect
        /// </summary>
        
        public void CalArea(int l, int b)
        {
            try
            {
                Rect r = new Rect(l, b);
                Console.WriteLine($"Area of rectangle is {r.L * r.B}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        #endregion
    }
}
