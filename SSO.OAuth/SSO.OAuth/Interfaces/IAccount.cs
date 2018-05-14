using SSO.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.OAuth.Interfaces
{
    interface IAccount
    {
        Task<User> ValidateUser(string userName, string password);
    }
}
