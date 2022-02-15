using FirmApi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace FirmApi.Repository
{
    public class AccountsRepository
    {
        private readonly FirmApiDbContext _dbContext;
        private readonly ILogger _logger;

        public AccountsRepository(FirmApiDbContext dbContext, ILogger logger = null)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        /// <summary>
        /// Get list of accounts
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Accounts>> GetAccounts()
        {
            try
            {
                var accounts = _dbContext.Accounts;
                return await accounts.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error("Error occured while getting accounts details", ex);
            }

            return null;
        }
        /// <summary>
        /// Sample code for how to execute procedure using dbcontext
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>

        public Accounts GetAccountsInfo(int accountId)
        {
            Accounts accounts = null;
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
                        SqlParameter param1 = new SqlParameter("@AccountId", accountId);
                        command.Parameters.Add(param1);
                        var reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            accounts = new Accounts()
                            {
                                Id = GetColumnValue<int>(reader, "AccountId"),
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

            return accounts;
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
