using Firm.Service.BLL.Contracts;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Firm.Service.Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountsProcessor _accountsProcessor;
        private readonly ILogger _logger;
        public AccountsController(IAccountsProcessor accountsProcessor, ILogger logger)
        {
            _accountsProcessor = accountsProcessor;
            _logger = logger;
        }

        [HttpGet]
        [MapToApiVersion("1")]
        [Route("/getAccounts")]
        public async Task<IActionResult> GetAccounts()
        {
            _logger.Debug("Accounts.GetAccounts - Entry");
            var accounts = await _accountsProcessor.GetAccounts();
            _logger.Debug("Accounts.GetAccounts - Exit");
            return new ObjectResult(accounts) { StatusCode = (int)HttpStatusCode.OK };

        }


        [HttpPost]
        [MapToApiVersion("1")]
        [Route("/InsertAccount")]
        public void InsertAccount([FromBody] string value)
        {
        }


        [HttpPut]
        [MapToApiVersion("1")]
        [Route("/UpdateAccount")]
        public void UpdateAccount([FromBody] string value)
        {
        }

        [HttpDelete]
        [MapToApiVersion("1")]
        [Route("/DeleteAccount")]
        public void DeleteAccount()
        {
        }
    }
}
