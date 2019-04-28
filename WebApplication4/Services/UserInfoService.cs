using System;
using System.Threading.Tasks;
using Dapper;
using WebApplication4.Models;
using WebApplication4.Services.Interfaces;
using Npgsql;

namespace WebApplication4.Services
{
    public class UserInfoService : IUserlnfoService
    {
        private const string ConnectionString =
            "host=localhost;port=5432;database=postgres;username=postgres;password=12345";
        public async Task<User> GetById(Guid id)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                return await connection.QuerySingleAsync<User>(
                    "SELECT * FROM Users WHERE Id = @id", new { id });
            }
        }
    }

}