using Firm.Service.BLL.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firm.Service.Main.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    public class HolidayController : ControllerBase
    {
        private readonly IHolidayProcessor _holidayProcessor;
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holidayMasterProcessor"></param>
        /// <param name="logger"></param>
        public HolidayController(IHolidayProcessor holidayProcessor, ILogger logger)
        {
            _holidayProcessor = holidayProcessor;
            _logger = logger;
        }

        /// <summary>
        /// getHolidays
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1")]
        [Route("/Holidays")]
        public async Task<IActionResult> getHolidays()
        {
            _logger.Debug("Accounts.getHolidays - Entry");
            var holidays = await _holidayProcessor.GetHolidays();
            _logger.Debug("Accounts.getHolidays - Exit");
            return Ok(holidays);

        }
    }
}
