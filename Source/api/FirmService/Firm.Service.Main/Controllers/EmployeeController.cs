using Firm.Service.BLL.Contracts;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Firm.Service.Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeProcessor _employeeProcessor;
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holidayMasterProcessor"></param>
        /// <param name="logger"></param>
        public EmployeeController(IEmployeeProcessor employeeProcessor, ILogger logger)
        {
            _employeeProcessor = employeeProcessor;
            _logger = logger;
        }

        /// <summary>
        /// getEmployees
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1")]
        [Route("/Employees")]
        public async Task<IActionResult> getEmployees()
        {
            _logger.Debug("Employee.getEmployees - Entry");
            var employees = await _employeeProcessor.GetEmployees();
            _logger.Debug("Employee.getEmployees - Exit");
            return Ok(employees);
        }

        // GET api/<EmployeesController>/5
        [HttpGet]
        [MapToApiVersion("1")]
        [Route("/Employee")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            _logger.Debug("Employee.GetEmployee - Entry");
            var employee = await _employeeProcessor.GetEmployee(id);
            _logger.Debug("Employee.GetEmployee - Exit");
            return Ok(employee);
        }
    }
}
