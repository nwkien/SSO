using SSO.Data.Model;
using SSO.Data.Repositories;
using SSO.OAuth.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.OAuth.Helper
{
    public class Account : IAccount
    {
        public async Task<User> ValidateUser(string userName, string password)
        {
            var users = new UserRepository(ConfiguratorHelper.GetConfigurator());
            return await users.GetUserByCredential(userName, password);
        }
    }
}
