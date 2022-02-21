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
        private const string _className = nameof(EmployeeRepository);

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
            const string methodName = nameof(GetEmployeeList);
            try
            {
                _logger.Debug($"{_className}: {methodName}-Entry");
                var result = (from emp in _dbContext.Employees
                              select new Employee
                              {
                                  EmployeeID = emp.EmployeeID,
                                  EmployeeCode = emp.EmployeeCode,
                                  Designation = emp.Designation,
                                  FirstName = emp.FirstName,
                                  MiddleName = emp.MiddleName,
                                  LastName = emp.LastName,
                                  EmailId = emp.EmailId,
                                  Phone1 = emp.Phone1,
                                  Phone2 = emp.Phone2,
                                  DateOfJoin = emp.DateOfJoin,
                                  Image = emp.Image,
                                  Status = emp.Status
                              }).ToListAsync();
                return await result;
            }
            catch (Exception ex)
            {
                _logger.Error("Error occured while getting Employee List", _className, methodName, ex);
                throw;
            }
            finally
            {
                _logger.Debug($"{_className}: {methodName}-Exit");
            }
        }

        /// <summary>
        /// GetEmployeeDetails
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            const string methodName = nameof(GetEmployeeDetails);
            try
            {
                _logger.Debug($"{_className}: {methodName}-Entry");
                var employeeList = _dbContext.Employees;
                return await employeeList.FirstOrDefaultAsync(x => x.EmployeeID == employeeId);
            }
            catch (Exception ex)
            {
                _logger.Error($"Error occured while getting Employee Details",_className, methodName, ex);
                throw;
            }
            finally
            {
                _logger.Debug($"{_className}: {methodName}-Exit");
            }
        }
    }
}
