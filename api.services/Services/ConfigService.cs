using api.modals;
using api.services.Handlers;
using api.services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Services
{
    public class ConfigService : IConfigRepository
    {
        public async Task<string> GetConfig()
        {
            string query = "select * from config";
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }

        public async Task<string> GetConfigById(int id)
        {
            string query = "select * from config where Id = " + id;
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }

        public async Task<bool> PostConfig(Config config)
        {
            string query = $"insert into config values(null,'{config.Titulo}','{config.Subtitulo}','{config.Menu}','{config.Footer}','{config.ColorP}','{config.ColorS}','{config.Logo}')";
            bool resultado = SqliteHandlers.Exec(query);
            return await Task.Run(() => resultado);
        }

        public async Task<bool> PutConfig(Config config)
        {
            string query = $"update config set Titulo = '{config.Titulo}', Subtitulo = '{config.Subtitulo}', Menu = '{config.Menu}', Footer = '{config.Footer}', ColorP = '{config.ColorP}', ColorS = '{config.ColorS}', Logo = '{config.Logo}' where Id = " + config.Id;
            bool resultado = SqliteHandlers.Exec(query);
            return await Task.Run(() => resultado);
        }

        public async Task<bool> DeleteConfig(int id)
        {
            string query = "delete from config where Id = " + id;
            bool resultado = SqliteHandlers.Exec(query);
            return await Task.Run(() => resultado);
        }
    }
}
