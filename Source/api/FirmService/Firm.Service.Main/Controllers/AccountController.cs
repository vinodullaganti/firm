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
    public class AccountController : ControllerBase
    {
        private readonly IAccountProcessor _accountProcessor;
        private readonly ILogger _logger;
        public AccountController(IAccountProcessor accountProcessor, ILogger logger)
        {
            _accountProcessor = accountProcessor;
            _logger = logger;
        }

        [HttpGet]
        [MapToApiVersion("1")]
        [Route("/Accounts")]
        public async Task<IActionResult> GetAccounts()
        {
            _logger.Debug("Accounts.GetAccounts - Entry");
            var accounts = await _accountProcessor.GetAccounts();
            _logger.Debug("Accounts.GetAccounts - Exit");
            return new ObjectResult(accounts) { StatusCode = (int)HttpStatusCode.OK };

        }

        [HttpGet]
        [MapToApiVersion("1")]
        [Route("/Account")]
        public async Task<IActionResult> GetAccountDetails(int id)
        {
            _logger.Debug("Accounts.GetAccounts - Entry");
            var account = await _accountProcessor.GetAccountDetails(id);
            _logger.Debug("Employee.GetAccounts - Exit");
            return Ok(account);
        }

        [HttpPost]
        [MapToApiVersion("1")]
        [Route("/Account")]
        public async Task<IActionResult> CreateAccount()
        {
            _logger.Debug("Accounts.GetAccounts - Entry");
            var account = await _accountProcessor.GetAccounts();
            _logger.Debug("Employee.GetAccounts - Exit");
            return Ok(account);
        }

        [HttpPut]
        [MapToApiVersion("1")]
        [Route("/Account")]
        public async Task<IActionResult> UpdateAccountDetails(int id)
        {
            _logger.Debug("Accounts.GetAccounts - Entry");
            var account = await _accountProcessor.GetAccountDetails(id);
            _logger.Debug("Employee.GetAccounts - Exit");
            return Ok(account);
        }

        [HttpDelete]
        [MapToApiVersion("1")]
        [Route("/Account")]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            _logger.Debug("Accounts.GetAccounts - Entry");
            var account = await _accountProcessor.GetAccountDetails(id);
            _logger.Debug("Employee.GetAccounts - Exit");
            return Ok(account);
        }
    }
}
