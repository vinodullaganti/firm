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
    public class HolidayMasterProcessor : IHolidayMasterProcessor
    {
        private readonly IHolidayMasterRepository _holidayMasterRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public HolidayMasterProcessor(IHolidayMasterRepository holidayMasterRepository, IMapper mapper = null, ILogger logger = null)
        {
            _holidayMasterRepository = holidayMasterRepository;
            _logger = logger;
            _mapper = mapper;

        }

        /// <summary>
        /// GetHolidays
        /// </summary>
        /// <returns></returns>
        public async Task<IList<HolidayMasterDTO>> GetHolidays()
        {
            _logger.Debug("HolidayMasterProcessor: GetHolidays-Entry");
            var holidays = await _holidayMasterRepository.GetHolidayList();
            var holidaysList = _mapper.Map<IList<HolidayMasterDTO>>(holidays?.Where(x => x.HolidayDate.Year == DateTime.UtcNow.Year));
            return holidaysList;
        }
    }
}
