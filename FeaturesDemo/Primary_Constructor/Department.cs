//Date: 17 May 2024
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__12_Features.Primary_Constructor
{
    public class Department(string deptName)
    {
        #region Data Members
        public string DeptName { get; set; } = deptName;
        #endregion
    }
}
