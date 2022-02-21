using AutoMapper;
using Firm.Models.DTO;
using Firm.Service.BLL.Contracts;
using Firm.Service.Repository.Contracts;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.BLL
{
    public class EmployeeProcessor : IEmployeeProcessor
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private const string _className = nameof(EmployeeProcessor);

        public EmployeeProcessor(IEmployeeRepository employeeRepository, IMapper mapper = null, ILogger logger = null)
        {
            _employeeRepository = employeeRepository;
            _logger = logger;
            _mapper = mapper;

        }

        /// <summary>
        /// GetEmployees
        /// </summary>
        /// <returns></returns>
        public async Task<IList<EmployeeListDTO>> GetEmployees()
        {
            const string methodName = nameof(GetEmployees);
            try
            {
                _logger.Debug($"{_className}: {methodName}-Entry");
                var employees = await _employeeRepository.GetEmployeeList();
                _logger.Debug($"{_className}: {methodName}-Exit");
                return _mapper.Map<IList<EmployeeListDTO>>(employees);
            }
            catch (Exception ex)
            {
                _logger.Error($"Error occured while getting Employee Details,", _className, methodName, ex);
                throw;
            }
            finally
            {
                _logger.Debug($"{_className}: {methodName}-Exit");
            }
        }

        /// <summary>
        /// GetEmployee
        /// </summary>
        /// <returns></returns>
        public async Task<EmployeeDTO> GetEmployee(int id)
        {
            const string methodName = nameof(GetEmployee);
            try
            {
                _logger.Debug($"{_className}: {methodName}-Entry");
                var employee = await _employeeRepository.GetEmployeeDetails(id);
                return _mapper.Map<EmployeeDTO>(employee);
            }
            catch (Exception ex)
            {
                _logger.Error($"Error occured while getting Employee Details,", _className, methodName, ex);
                throw;
            }
            finally
            {
                _logger.Debug($"{_className}: {methodName}-Exit");
            }
        }
    }
}
