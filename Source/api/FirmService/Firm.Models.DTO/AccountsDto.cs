using System;
using System.Collections.Generic;
using System.Text;

namespace Firm.Models.DTO
{
    /// <summary>
    /// Accounts Dto
    /// </summary>
    public class AccountsDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Account Id
        /// </summary>
        public string AccountId { get; set; }
        /// <summary>
        /// Account name
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }
    }
}
