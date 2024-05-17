//Date: 17 May 2024
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__12_Features.Primary_Constructor
{
    //we can declare constructor at time of class creation also check validations for passed values
    /// <summary>
    /// declare constructor at time of class creation and pass value for parent class also
    /// </summary>
    public class Employee(string name, int salary) : Department("Sales")
    {
        #region Data Members
        /// <summary>
        /// check validations for passed values
        /// <summary>
        /// </summary>
        public string Name { get; set; } = name.Length > 3 ? name : throw new ArgumentException("name greater than 4 chars");
        public int Salary { get; set; } = salary > 1000 ? salary : throw new ArgumentException("salary greater 1000 ");

        public string Code { get; set; }
        #endregion
        #region Other Constructors
        /// <summary>
        /// default constructor uses value from prime constructors using this
        /// </summary>

        public Employee() : this("don2", 2200)
        {

        }
        /// <summary>
        /// parameterized constructor with different parameter than prime constructor
        /// </summary>
        public Employee(string name, string code, string deptName) : this()
        {
            Name = name;
            Code = code;
            DeptName = deptName;
        }
        #endregion
    }

}
