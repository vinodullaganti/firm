using Firm.Models.DTO;
using Firm.Service.BLL.Contracts;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firm.Service.Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1")]
    public class UserController : ControllerBase
    {
        private readonly IUserProcessor _userProcessor;
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userProcessor"></param>
        /// <param name="logger"></param>
        public UserController(IUserProcessor userProcessor, ILogger logger)
        {
            _userProcessor = userProcessor;
            _logger = logger;
        }

        [HttpPost]
        [MapToApiVersion("1")]
        [Route("/User")]
        public async Task<IActionResult> GetUser(UserDTO user)
        {
            _logger.Debug("User.GetUser - Entry");
            var userDetails = await _userProcessor.GetUserDetails(user);
            _logger.Debug("User.GetUser - Exit");
            return Ok(userDetails);
        }
    }
}
