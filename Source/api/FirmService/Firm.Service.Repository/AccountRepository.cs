using Firm.Service.Repository.Contracts;
using Firm.Service.Repository.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Firm.Service.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly FirmDbContext _dbContext;
        private readonly ILogger _logger;

        public AccountRepository(FirmDbContext dbContext, ILogger logger = null)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        /// <summary>
        /// Get list of account details
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Account>> GetAccounts()
        {
            try
            {
                var account = _dbContext.Account;
                return await account.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error("Error occured while getting accounts details", ex);
            }

            return null;
        }

        /// <summary>
        /// Get account details based on account id
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        public async Task<Account> GetAccountDetails(int AccountId)
        {
            Account account = null;
            var connection = _dbContext.Database.GetDbConnection();
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            if (connection != null)
            {
                try
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        var command = connection.CreateCommand();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "GetAccountDetails";
                        SqlParameter param1 = new SqlParameter("@AccountId", AccountId);
                        command.Parameters.Add(param1);
                        var reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            account = new Account()
                            {
                                AccountId = GetColumnValue<int>(reader, "AccountId"),
                                AccountName = GetColumnValue<string>(reader, "AccountName")
                            };
                        }
                    }
                }
                finally
                {
                    connection.Close();
                }
            }

            return account;
        }

        /// <summary>
        /// Gets the column value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader">The reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        private T GetColumnValue<T>(DbDataReader reader, string columnName)
        {
            return reader.IsDBNull(columnName) ? default : reader.GetFieldValue<T>(columnName);
        }
    }
}
