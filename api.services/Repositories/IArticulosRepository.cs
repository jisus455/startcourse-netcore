using api.modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Repositories
{
    public interface IArticulosRepository
    {
        public Task<string> GetArticulos();

        // nuevos metodos
        public Task<string> GetArticulosByPrecioAsc();
        public Task<string> GetArticulosByPrecioDesc();
        public Task<string> GetArticulosByVendidosDesc();
        public Task<string> GetArticulosByValoracionDesc();
        public Task<string> GetArticulosByCategoria(String categoria);
        public Task<string> GetArticulosByTitulo(String titulo);

        public Task<string> GetArticulosById(int id);
        public Task<bool> PostArticulos(Articulos articulos);
        public Task<bool> PutArticulos(Articulos articulos);
        public Task<bool> DeleteArticulos(int id);
    }
}
