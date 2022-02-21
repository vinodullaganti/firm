using AutoMapper;
using Firm.Models.DTO;
using Firm.Service.BLL.Contracts;
using Firm.Service.Repository.Contracts;
using Serilog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Firm.Service.BLL
{
    public class AccountProcessor : IAccountProcessor
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        public AccountProcessor(IAccountRepository accountRepository, IMapper mapper = null, ILogger logger = null)
        {
            _accountRepository = accountRepository;
            _logger = logger;
            _mapper = mapper;

        }
        /// <summary>
        /// Get list of accounts
        /// </summary>
        /// <returns></returns>
        public async Task<IList<AccountDTO>> GetAccounts()
        {
            _logger.Debug("AccountProcessor: GetAccounts Entry");
            var accounts = await _accountRepository.GetAccounts();
            IList<AccountDTO> accountList = _mapper.Map<IList<AccountDTO>>(accounts);
            _logger.Debug("AccountProcessor: GetAccounts Exit");
            return accountList;
        }

        /// <summary>
        /// Get account details based on account id
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        public async Task<AccountDTO> GetAccountDetails(int AccountId)
        {
            _logger.Debug("AccountProcessor: GetAccounts Entry");
            var accountData = await _accountRepository.GetAccountDetails(AccountId);
            AccountDTO account = _mapper.Map<AccountDTO>(accountData);
            _logger.Debug("AccountProcessor: GetAccounts Exit");
            return account;
        }
    }
}
