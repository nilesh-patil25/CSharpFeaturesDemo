//Date: 17 May 2024
using System.Xml.Linq;
using WebFeatures.Models;
using WebFeatures.Services.Interfaces;

namespace WebFeatures.Services
{
    public class EmployeeService:IEmployeeService
    {
        #region Object Creation
        /// <summary>
        /// static Employee List
        /// </summary>
        List<Employee> Employees { get; } = new List<Employee>
        {
            new Employee { Id = 1, Name = "Test", Salary = 90000 },
            new Employee { Id = 3, Name = "sam", Salary = 25000 },
            new Employee { Id = 5, Name = "john", Salary = 40000 }
        };
        #endregion

        #region Member Functions
        public List<Employee> GetAllEmployees()
        {
            try
            {
                return Employees;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

    }
}
