using AutoMapper;
using Firm.Models.DTO;
using Firm.Service.BLL.Contracts;
using Firm.Service.Repository.Contracts;
using Serilog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Firm.Service.BLL
{
    public class AccountsProcessor : IAccountsProcessor
    {
        private readonly IAccountsRepository _accountsRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        public AccountsProcessor(IAccountsRepository accountsRepository, IMapper mapper = null, ILogger logger = null)
        {
            _accountsRepository = accountsRepository;
            _logger = logger;
            _mapper = mapper;

        }
        /// <summary>
        /// Get list of accounts
        /// </summary>
        /// <returns></returns>
        public async Task<IList<AccountsDto>> GetAccounts()
        {
            _logger.Debug("AccountProcessor: GetAccounts-Entry");
            var accounts = await _accountsRepository.GetAccounts();
            IList<AccountsDto> accountsDTO = _mapper.Map<IList<AccountsDto>>(accounts);
            return accountsDTO;
        }
    }
}
