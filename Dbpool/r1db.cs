using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Dapper;
using System.Data.Common;
using MySqlConnector;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Data;
namespace adapter.Dbpool
{
    public class  dbcontext:IDisposable
    {
        private readonly DbConnection _dbcon;

        public dbcontext(IConfiguration conf)
        {
            _dbcon = new MySqlConnection(conf.GetConnectionString("Defaultconnection"));
        }
        public IDbConnection Connection => _dbcon;
        private async Task EnsureOpenAsync()
        {
            if (_dbcon.State != System.Data.ConnectionState.Open)
                await _dbcon.OpenAsync();
        }

        public void Dispose()
        {
            _dbcon?.Dispose();    // ? checks the conditional null,elvis operator
        }

        public async Task<IEnumerable<T>>Getall<T>(String ql,Object param)
        {

            await EnsureOpenAsync();
            return (await _dbcon.QueryAsync<T>(ql,param)).ToList();
        }
        public async Task<int> Executeall<T>(String ql, Object param)
        {

            await EnsureOpenAsync();
            return await _dbcon.ExecuteScalarAsync<int>(ql, param);
            //return (await _dbcon.QueryAsync<T>(ql, param)).ToList();
        }

        public async Task<int> Execute(string query, object param)
        {
            await EnsureOpenAsync();
            return await _dbcon.ExecuteAsync(query, param);
        }
        public async Task<T?> Executes<T>(string query, object param)
        {
            await EnsureOpenAsync();
            return await _dbcon.QueryFirstOrDefaultAsync<T>(query, param);
        }
        public async Task ExecuteAsync(string query, object param)
        {
            await EnsureOpenAsync(); // Ensure connection is open
            await _dbcon.ExecuteAsync(query, param); // Just execute, no return value
        }

        public async Task<T> ExecuteAdmScalarAsync<T>(string query, object param, IDbTransaction transaction = null)
        {
            await EnsureOpenAsync(); // Ensure the connection is open
            return await _dbcon.ExecuteScalarAsync<T>(query, param,transaction);
        }
        public async Task ExecuteAdmAsync(string query, object param, IDbTransaction transaction = null)
        {
            await EnsureOpenAsync();
            await _dbcon.ExecuteAsync(query, param, transaction);
        }

    }
}
