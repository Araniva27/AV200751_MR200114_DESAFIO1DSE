using Dapper;
using Desafio.Common;
using Desafio.DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.DAL.Repositories
{
    public class DatabaseRepository : IDatabaseRepository
    {
        private readonly string connectionString;

        public DatabaseRepository(IOptions<AppSettings> appSettings)
        {
            connectionString = appSettings.Value.ConnectionString;
        }

        public async Task<T> Update<T>(string query, DynamicParameters? parameters = null)
        {
            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<T>(query, parameters);
                    connection.Close();
                    if(result != null && result.Any())
                    {
                        return result.FirstOrDefault();
                    }
                }
            }catch (Exception ex) { 
                throw new Exception("Error en la consulta de actualizar : " +ex.Message);
            }
            return default;
        }
    }
}
