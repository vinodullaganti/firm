using Firm.Service.Repository.Contracts;
using Firm.Service.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firm.Service.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FirmDbContext _dbContext;
        private readonly ILogger _logger;

        public EmployeeRepository(FirmDbContext dbContext, ILogger logger = null)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        /// <summary>
        /// GetEmployeeList
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Employee>> GetEmployeeList()
        {
            try
            {
                var result = (from emp in _dbContext.Employees
                             select new Employee
                             {
                                 ID = emp.ID,
                                 EmployeeID = emp.EmployeeID,
                                 Designation = emp.Designation,
                                 DateOfJoin = emp.DateOfJoin,
                                 Status = emp.Status
                             }).ToListAsync();
                return await result;
            }
            catch (Exception ex)
            {
                _logger.Error("Error occured while getting Employee List", ex);
            }
            return null;
        }

        /// <summary>
        /// GetEmployeeDetails
        /// </summary>
        /// <returns></returns>
        public async Task<Employee> GetEmployeeDetails(int id)
        {
            try
            {
                var employeeList = _dbContext.Employees;
                return await employeeList.FirstOrDefaultAsync(x => x.ID == id);
            }
            catch (Exception ex)
            {
                _logger.Error("Error occured while getting Employee Details", ex);
            }
            return null;
        }
    }
}
