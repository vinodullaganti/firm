using Firm.Service.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.Repository.Contracts
{
    public interface IHolidayRepository
    {
        Task<IList<Holiday>> GetHolidayList();

    }
}
