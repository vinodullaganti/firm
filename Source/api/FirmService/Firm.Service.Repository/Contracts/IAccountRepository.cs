using Firm.Service.Repository.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Firm.Service.Repository.Contracts
{
    public interface IAccountRepository
    {
        /// <summary>
        /// Get list of account details
        /// </summary>
        /// <returns></returns>
        Task<IList<Account>> GetAccounts();

        /// <summary>
        /// Get account details based on account id
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<Account> GetAccountDetails(int AccountId);
    }
}
