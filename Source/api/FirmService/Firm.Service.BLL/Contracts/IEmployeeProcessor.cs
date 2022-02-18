using Firm.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.BLL.Contracts
{
    public interface IEmployeeProcessor
    {
        /// <summary>
        /// GetEmployees
        /// </summary>
        /// <returns></returns>
        Task<IList<EmployeeListDTO>> GetEmployees();

        /// <summary>
        /// GetEmployee
        /// </summary>
        /// <returns></returns>
        Task<EmployeeDTO> GetEmployee(int id);

    }
}
