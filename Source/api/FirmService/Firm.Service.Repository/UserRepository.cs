using Firm.Service.Repository.Contracts;
using Firm.Service.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.Repository
{
    /// <summary>
    /// UserRepository
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly FirmDbContext _dbContext;
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="logger"></param>
        public UserRepository(FirmDbContext dbContext, ILogger logger = null)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        /// <summary>
        /// GetUserDetails
        /// </summary>
        /// <param name="emailId"></param>
        /// <returns></returns>
        public async Task<User> GetUserDetails(string emailId)
        {
            try
            {
                return await _dbContext.Users.FirstOrDefaultAsync(x => x.EmailId == emailId);
            }
            catch (Exception ex)
            {
                _logger.Error("Error occured while getting Employee Details", ex);
            }
            return null;
        }
    }
}
