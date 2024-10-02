using api.services.Handlers;
using api.services.Repositories;
using Microsoft.Data.Sqlite;

namespace api.services.Services
{
    public class DataBaseService : IDataBaseRepository
    {
        public async Task<bool> CreateDataBase()
        {
            bool response = false;
            string database = SqliteHandlers.ConnectionString.Replace("Data source=", "");

            if (!File.Exists(database))
            {
                try
                {
                    StreamWriter writer = File.CreateText(database);
                    response = true;
                }
                catch (Exception ex)
                {
                    response = false;
                    string excepcion = ex.Message;
                }
            }

            return await Task.Run(() => response);
        }

        public async Task<bool> CreateTableUsers()
        {
            string query = "create table users (Id integer primary key autoincrement, Nombre text, Apellido text, Email text, Usuario text, Clave text, Estado text, Rol text);";
            return await Task.Run(() =>  SqliteHandlers.Exec(query));
        }

        public async Task<bool> CreateTableConfig()
        {
            string query = "create table config (Id integer primary key autoincrement, Titulo text, Subtitulo text, Menu text, Footer text, ColorP text, ColorS text, Logo text);";
            return await Task.Run(() => SqliteHandlers.Exec(query));
        }

        public async Task<bool> CreateTableArticulos()
        {
            string query = "create table articulos (Id integer primary key autoincrement, Titulo text, Categoria text, Descripcion text, Valoracion integer, Precio integer, Vendidos integer, Imagen text);";
            return await Task.Run(() => SqliteHandlers.Exec(query));
        }

    }
}
