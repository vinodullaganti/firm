using FirmApi.Models;
using FirmApi.Repository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirmApi.Services
{
    public class AccountsService
    {
        private readonly AccountsRepository _accountsRepository;
        private readonly ILogger _logger;
        public AccountsService(AccountsRepository accountsRepository, ILogger logger = null)
        {
            _accountsRepository = accountsRepository;
            _logger = logger;


        }
        /// <summary>
        /// Get list of accounts
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Accounts>> GetAccounts()
        {
            _logger.Debug("AccountProcessor: GetAccounts-Entry");
            return await _accountsRepository.GetAccounts();

        }
    }
}
