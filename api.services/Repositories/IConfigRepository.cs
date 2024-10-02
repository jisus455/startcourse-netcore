using api.modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Repositories
{
    public interface IConfigRepository
    {
        public Task<string> GetConfig();
        public Task<string> GetConfigById(int id);
        public Task<bool> PostConfig(Config config);
        public Task<bool> PutConfig(Config config);
        public Task<bool> DeleteConfig(int id);
    }
}
