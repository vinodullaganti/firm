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
            _logger.Debug("EmployeeProcessor: GetEmployees-Entry");
            var employees = await _employeeRepository.GetEmployeeList();
            _logger.Debug("EmployeeProcessor: GetEmployees-Exit");
            return _mapper.Map<IList<EmployeeListDTO>>(employees);
        }

        /// <summary>
        /// GetEmployee
        /// </summary>
        /// <returns></returns>
        public async Task<EmployeeDTO> GetEmployee(int id)
        {
            _logger.Debug("EmployeeProcessor: GetEmployee-Entry");
            var employee = await _employeeRepository.GetEmployeeDetails(id);
            _logger.Debug("EmployeeProcessor: GetEmployee-Exit");
            return _mapper.Map<EmployeeDTO>(employee);
        }
    }
}
