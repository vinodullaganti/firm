using Firm.Service.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.Repository.Contracts
{
    public interface IEmployeeRepository
    {
        Task<IList<Employee>> GetEmployeeList();
        Task<Employee> GetEmployeeDetails(int id);
    }
}
