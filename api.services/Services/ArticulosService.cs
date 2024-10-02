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
    public class ArticulosService : IArticulosRepository
    {
        public async Task<string> GetArticulos()
        {
            string query = "select * from articulos";
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }

        // nuevos metodos
        public async Task<string> GetArticulosByPrecioDesc()
        {
            string query = "select * from articulos order by Precio DESC";
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }
        public async Task<string> GetArticulosByPrecioAsc()
        {
            string query = "select * from articulos order by Precio ASC";
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }
        public async Task<string> GetArticulosByVendidosDesc()
        {
            string query = "select * from articulos order by Vendidos DESC";
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }
        public async Task<string> GetArticulosByValoracionDesc()
        {
            string query = "select * from articulos order by Valoracion DESC";
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }
        public async Task<string> GetArticulosByCategoria(String categoria)
        {
            string query = $"select * from articulos where Categoria = '{categoria}'";
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }

        public async Task<string> GetArticulosByTitulo(String titulo)
        {
            string query = $"select * from articulos where Titulo like '%{titulo}%'";
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }




        public async Task<string> GetArticulosById(int id)
        {
            string query = "select * from articulos where Id = " + id;
            string resultado = SqliteHandlers.GetJson(query);
            return await Task.Run(() => resultado);
        }

        public async Task<bool> PostArticulos(Articulos articulos)
        {
            string query = $"insert into articulos values(null,'{articulos.Titulo}','{articulos.Categoria}','{articulos.Descripcion}','{articulos.Valoracion}','{articulos.Precio}','{articulos.Vendidos}','{articulos.Imagen}')";
            bool resultado = SqliteHandlers.Exec(query);
            return await Task.Run(() => resultado);
        }

        public async Task<bool> PutArticulos(Articulos articulos)
        {
            string query = $"update articulos set Titulo = '{articulos.Titulo}', Categoria = '{articulos.Categoria}', Descripcion = '{articulos.Descripcion}', Valoracion = {articulos.Valoracion}, Precio = {articulos.Precio}, Vendidos = {articulos.Vendidos}, Imagen = '{articulos.Imagen}' where Id = " + articulos.Id;
            bool resultado = SqliteHandlers.Exec(query);
            return await Task.Run(() => resultado);
        }

        public async Task<bool> DeleteArticulos(int id)
        {
            string query = "delete from articulos where Id = " + id;
            bool resultado = SqliteHandlers.Exec(query);
            return await Task.Run(() => resultado);
        }
    }
}
