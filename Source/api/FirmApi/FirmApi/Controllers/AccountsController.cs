using FirmApi.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirmApi.Controllers.Accounts
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1")]
    public class AccountsController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly AccountsService _accountsService;

        public AccountsController(AccountsService accountsService = null ,ILogger logger =null)
        {
            _accountsService = accountsService;
            _logger = logger;
        }
        [HttpGet]
        [MapToApiVersion("1")]
        [Route("/Accounts")]
        public async Task<IActionResult> GetAccounts()
        {
            _logger.Debug("Accounts.GetAccounts - Entry");
            var accounts = await _accountsService.GetAccounts();
            _logger.Debug("Accounts.GetAccounts - Exit");
            return new ObjectResult(accounts) { StatusCode = (int)HttpStatusCode.OK };

        }


        [HttpPost]
        [MapToApiVersion("1")]
        [Route("/Account")]
        public void InsertAccount([FromBody] string value)
        {
        }


        [HttpPut]
        [MapToApiVersion("1")]
        [Route("/Account")]
        public void UpdateAccount([FromBody] string value)
        {
        }

        [HttpDelete]
        [MapToApiVersion("1")]
        [Route("/Account")]
        public void DeleteAccount()
        {
        }
    }
}
