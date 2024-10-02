using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Repositories
{
    public interface IDataBaseRepository
    {
        public Task<bool> CreateDataBase();
        public Task<bool> CreateTableUsers();
        public Task<bool> CreateTableConfig();
        public Task<bool> CreateTableArticulos();
        
    }
}
