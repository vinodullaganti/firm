using AutoMapper;
using Firm.Models.DTO;
using Firm.Service.BLL.Contracts;
using Firm.Service.Repository.Contracts;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.BLL
{
    /// <summary>
    /// HolidayMasterProcessor
    /// </summary>
    public class HolidayProcessor : IHolidayProcessor
    {
        private readonly IHolidayRepository _holidayRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public HolidayProcessor(IHolidayRepository holidayRepository, IMapper mapper = null, ILogger logger = null)
        {
            _holidayRepository = holidayRepository;
            _logger = logger;
            _mapper = mapper;

        }

        /// <summary>
        /// GetHolidays
        /// </summary>
        /// <returns></returns>
        public async Task<IList<HolidayDTO>> GetHolidays()
        {
            _logger.Debug("HolidayProcessor: GetHolidays-Entry");
            var holidays = await _holidayRepository.GetHolidayList();
            var holidaysList = _mapper.Map<IList<HolidayDTO>>(holidays?.Where(x => x.HolidayDate.Year == DateTime.UtcNow.Year));
            return holidaysList;
        }
    }
}
