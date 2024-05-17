using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptorDemo
{
    public class Employee
    {
        #region Member Functions
        /// <summary>
        /// display the name string
        /// </summary>
        /// <param name="name"></param>
        public void DisplayName(string name)
        {
            Console.WriteLine(name);
        }
        #endregion
    }
}