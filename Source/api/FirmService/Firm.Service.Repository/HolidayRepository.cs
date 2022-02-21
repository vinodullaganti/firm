using Firm.Service.Repository.Contracts;
using Firm.Service.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.Repository
{
    public class HolidayRepository : IHolidayRepository
    {
        private readonly FirmDbContext _dbContext;
        private readonly ILogger _logger;

        public HolidayRepository(FirmDbContext dbContext, ILogger logger = null)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        /// <summary>
        /// GetHolidayList
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Holiday>> GetHolidayList()
        {
            try
            {
                var holidayList = _dbContext.Holiday;
                return await holidayList.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error("Error occured while getting Holiday details", ex);
            }

            return null;
        }
    }
}
