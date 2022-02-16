using Firm.Models.DTO;
using Firm.Service.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.BLL.Contracts
{
    public interface IAccountsProcessor
    {
        /// <summary>
        /// Get list of accounts
        /// </summary>
        /// <returns></returns>
        public Task<IList<AccountsDto>> GetAccounts();
    }
}
