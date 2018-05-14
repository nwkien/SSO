using SSO.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SSO.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByCredential(string userName, string password);
    }
}
