using api.modals;
using api.services.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{
    [Route("api/config")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IConfigRepository _configService;

        public ConfigController(IConfigRepository configService)
        {
            _configService = configService;
        }

        [HttpGet]
        public async Task<string> GetConfig()
        {
            return await Task.Run(() => _configService.GetConfig());
        }

        [HttpGet("byid")]
        public async Task<string> GetConfigBiId(int id)
        {
            return await Task.Run(() => _configService.GetConfigById(id));
        }

        [HttpPost]
        public async Task<bool> PostConfig(Config config)
        {
            return await Task.Run(() => _configService.PostConfig(config));
        }

        [HttpPut]
        public async Task<bool> PutConfig(Config config)
        {
            return await Task.Run(() => _configService.PutConfig(config));
        }

        [HttpDelete]
        public async Task<bool> DeleteConfig(int id)
        {
            return await Task.Run(() => _configService.DeleteConfig(id));
        }


    }
}
