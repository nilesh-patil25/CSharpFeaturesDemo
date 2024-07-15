//Date: 17 May 2024
using Microsoft.AspNetCore.Mvc;
using WebFeatures.Models;
using WebFeatures.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebFeatures.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /// <summary>
    /// use of primary constructor in web api reducing code of lines
    /// </summary>
    /// <param name="employeeService"></param>
    public class EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> _logger) : ControllerBase
    {
        #region API
        /// <summary>
        /// fetching all employee details from static service
        /// </summary>
        [HttpGet("GetAllEmployees")]
        public IActionResult GetAllEmployee()
        {
            _logger.LogInformation("Getting all employees");
            var employees = employeeService.GetAllEmployees();
            _logger.LogInformation("Retrieved {EmployeeCount} employees", employees.Count);
            return Ok(employees);
        }
        #endregion
    }
}
 