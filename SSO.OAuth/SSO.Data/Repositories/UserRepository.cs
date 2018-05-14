using Microsoft.Extensions.Configuration;
using SSO.Data.Interfaces;
using SSO.Data.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SSO.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IConfiguration configuration)
           : base(configuration)
        {
        }

        public override User Populate(SqlDataReader reader)
        {
            if (!reader.IsDBNull(0))
            {
                return new User
                {
                    Username = reader.GetString(0),
                    Password = reader.GetString(1),
                    SubjectId = reader.GetString(2)
                };
            }
            else
                return new User();
        }

        public async Task<User> GetUserByCredential(string userName, string password)
        {
            using (var command = new SqlCommand("SELECT UserName, password, SubjectId " +
                                                "FROM Users WHERE UserName = @UserName AND Password = @Password"))
            {
                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = userName;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = password;
                return await Get(command);
            }
        }
    }
}
