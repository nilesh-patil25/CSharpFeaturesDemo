//Date: 17 May 2024
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace InterceptorDemo
{
    /*
     * An interceptor is a method that can declaratively substitute a call to an interceptable method with a call to itself at compile time. This substitution occurs by having the interceptor declare the source locations of the calls that it intercepts.*/
    public static class InterceptorMethods
    {
        /// <summary>
        /// defines the intercept location for the replacing current method with InterceptorDisplayName at runtime
        /// </summary>

        [InterceptsLocation("D:\\Year2024\\NET-8\\C#12\\C#_12_Features\\InterceptorDemo\\Program.cs", line:9,character:10)]
        [InterceptsLocation("D:\\Year2024\\NET-8\\C#12\\C#_12_Features\\InterceptorDemo\\Program.cs", line: 7, character: 10)]
        #region Member Functions
        public static void InterceptorDisplayName(this Employee employee, string name)
        {
            Console.WriteLine("Hello from Interceptor methods = " + name);
        }
        #endregion
    }
}
