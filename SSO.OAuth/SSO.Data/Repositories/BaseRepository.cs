using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SSO.Data.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        private static SqlConnection _connection;

        public BaseRepository(IConfiguration configuration)
        {
            _connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        protected async Task<T> Get(SqlCommand command)
        {
            T record = null;
            command.Connection = _connection;
            await _connection.OpenAsync();
            try
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                        record = Populate(reader);
                }
            }
            finally
            {
                _connection.Close();
            }
            return record;
        }

        public abstract T Populate(SqlDataReader reader);
    }
}
