using api.services.Repositories;
using api.services.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{
    [Route("api/users")]
    [ApiController]
    public class DataBaseController : ControllerBase
    {
        private readonly IDataBaseRepository _dataBaseService;

        public DataBaseController(IDataBaseRepository dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        [HttpGet("creardb")]
        public async Task<bool> CreateDataBase()
        {
            return await Task.Run(() => _dataBaseService.CreateDataBase());
        }

        [HttpGet("creartablauser")]
        public async Task<bool> CreateTableUsers()
        {
            return await Task.Run(() => _dataBaseService.CreateTableUsers());
        }

        [HttpGet("creartablaconfig")]
        public async Task<bool> CreateTableConfig()
        {
            return await Task.Run(() => _dataBaseService.CreateTableConfig());
        }

        [HttpGet("creartablaarticulos")]
        public async Task<bool> CreateTableArticulos()
        {
            return await Task.Run(() => _dataBaseService.CreateTableArticulos());
        }


    }
}
