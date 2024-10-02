using api.modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Repositories
{
    public interface IUserRepository
    {
        public Task<string> GetUsers();
        public Task<string> GetUsersById(int id);
        public Task<string> GetLogin(Login login);
        public Task<bool> PostUser(User user);
        public Task<bool> PutUser(User user);
        public Task<bool> DeleteUser(int id);
    }
}
