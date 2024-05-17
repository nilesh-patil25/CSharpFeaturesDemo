//Date: 17 May 2024
using WebFeatures.Models;

namespace WebFeatures.Services.Interfaces
{
    public interface IEmployeeService
    {
        #region Interface Methods
        List<Employee> GetAllEmployees();
        #endregion
    }
}