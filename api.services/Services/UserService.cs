using api.modals;
using api.services.Handlers;
using api.services.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace api.services.Services
{
    public class UserService : IUserRepository
    {
        public async Task<string> GetUsers()
        {
            string query = "select * from users";
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }

        public async Task<string> GetUsersById(int id)
        {
            string query = "select * from users where Id = " + id;
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }

        public async Task<string> GetLogin(Login login)
        {
            string query = $"select Estado, Rol from users where Usuario = '{login.Usuario}' and Clave = '{login.Password}'";
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }

        public async Task<bool> PostUser(User user)
        {
            string query = $"insert into users values(null,'{user.Nombre}','{user.Apellido}','{user.Email}','{user.Usuario}','{user.Clave}','{user.Estado}','{user.Rol}')";
            bool resultado = SqliteHandlers.Exec(query);
            return await Task.Run(() => resultado);
        }

        public async Task<bool> PutUser(User user)
        {
            string query = $"update users set Nombre = '{user.Nombre}', Apellido = '{user.Apellido}', Email = '{user.Email}', Usuario = '{user.Usuario}', Clave = '{user.Clave}', Estado = '{user.Estado}', Rol = '{user.Rol}' where Id = " + user.Id;
            bool resultado = SqliteHandlers.Exec(query);
            return await Task.Run(() => resultado);
        }

        public async Task<bool> DeleteUser(int id)
        {
            string query = "delete from users where Id = " + id;
            bool resultado = SqliteHandlers.Exec(query);
            return await Task.Run(() => resultado);
        }
    }
}
