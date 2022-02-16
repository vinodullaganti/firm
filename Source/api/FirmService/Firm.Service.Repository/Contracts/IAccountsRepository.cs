using Firm.Service.Repository.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Firm.Service.Repository.Contracts
{
    public interface IAccountsRepository
    {
        /// <summary>
        /// Get accounts by account id
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Accounts GetAccountsInfo(int AccountId);
        Task<IList<Accounts>> GetAccounts();
    }
}
