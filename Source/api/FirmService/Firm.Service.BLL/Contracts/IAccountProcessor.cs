using Firm.Models.DTO;
using Firm.Service.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.BLL.Contracts
{
    public interface IAccountProcessor
    {
        /// <summary>
        /// Get list of account details
        /// </summary>
        /// <returns></returns>
        Task<IList<AccountDTO>> GetAccounts();

        /// <summary>
        /// Get account details based on account id
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<AccountDTO> GetAccountDetails(int AccountId);
    }
}
