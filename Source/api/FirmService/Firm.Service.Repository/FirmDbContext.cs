using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Reflection;
using Firm.Service.Repository.Models;

namespace Firm.Service.Repository
{
    public class FirmDbContext : DbContext
    {
        // Employees entity mapping
        //  public virtual DbSet<Employees> Employees { get; set; }
        public FirmDbContext(DbContextOptions<FirmDbContext> options) : base(options)
        {

        }
        // Projects entity
        // public DbSet<Projects> Projects { get; set; }
        // Accounts entity
        public virtual DbSet<Account> Account { get; set; }

        public DbSet<Holiday> Holiday { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbCommand GetStoredProc(string name)
        {
            return this.LoadStoredProc(name);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("account", "dbo");
            modelBuilder.Entity<Holiday>().ToTable("Holiday", "dbo");
            modelBuilder.Entity<Employee>().ToTable("Employee", "dbo");
            modelBuilder.Entity<User>().ToTable("users", "dbo");
        }
    }
    public static class FirmRepositoryExtenstions
    {
        public static DbCommand LoadStoredProc(this FirmDbContext firmContext, string name)
        {
            DbCommand cmd = firmContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = name;
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
        public class StoredProcResults
        {
            private readonly DbDataReader _reader;

            public StoredProcResults(DbDataReader reader)
            {
                _reader = reader;
            }

            public IList<T> ReadToList<T>() where T : new()
            {
                return MapToList<T>(_reader);
            }

            public bool NextResult()
            {
                return _reader.NextResult();
            }

            public T ReadColumnFromSingleRecord<T>(string columnName) where T : new()
            {
                var obj = new T();
                if (_reader.Read())
                {
                    obj = _reader.GetFieldValue<T>(columnName);
                }
                return obj;
            }

            private static IList<T> MapToList<T>(DbDataReader dr) where T : new()
            {
                var objList = new List<T>();
                var props = typeof(T).GetRuntimeProperties().ToList();

                var colMapping = dr.GetColumnSchema()
                    .Where(x => props.Any(y =>
                        string.Equals(y.Name, x.ColumnName, StringComparison.CurrentCultureIgnoreCase)))
                    .ToDictionary(key => key.ColumnName.ToUpper());

                if (!dr.HasRows)
                    return objList;

                while (dr.Read())
                {
                    var obj = new T();
                    foreach (var prop in props)
                    {
                        var upperName = prop.Name.ToUpper();

                        if (!colMapping.ContainsKey(upperName))
                            continue;

                        var column = colMapping[upperName];

                        if (column?.ColumnOrdinal == null)
                            continue;

                        var val = dr.GetValue(column.ColumnOrdinal.Value);
                        prop.SetValue(obj, val == DBNull.Value ? null : val);
                    }

                    objList.Add(obj);
                }

                return objList;
            }
        }
        /// <summary>
        /// This function will helps to construct sql parameters
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="valuePairs"></param>
        /// <returns></returns>
        public static DbCommand WithSqlParams(this DbCommand cmd, params (string, object)[] valuePairs)
        {
            foreach (var pair in valuePairs)
            {
                var para = cmd.CreateParameter();
                para.ParameterName = pair.Item1;
                para.Value = pair.Item2 ?? DBNull.Value;
                cmd.Parameters.Add(para);
            }
            return cmd;
        }
        /// <summary>
        /// This function helps to execute the stored procedure
        /// </summary>
        /// <param name="command"></param>
        /// <param name="handleResults"></param>
        /// <param name="commandBehaviour"></param>

        public static void ExecStoredProc(this DbCommand command, Action<StoredProcResults> handleResults, CommandBehavior commandBehaviour = CommandBehavior.Default)
        {
            if (handleResults == null)
            {
                throw new ArgumentNullException(nameof(handleResults));
            }

            using (command)
            {
                if (command.Connection.State == ConnectionState.Closed)
                    command.Connection.Open();
                try
                {
                    using (var reader = command.ExecuteReader(commandBehaviour))
                    {
                        var sprocResults = new StoredProcResults(reader);
                        handleResults(sprocResults);
                    }
                }
                finally
                {
                    command.Connection.Close();
                }
            }
        }

    }
}
