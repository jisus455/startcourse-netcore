using api.modals;
using api.services.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{
    [Route("api/articulos")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly IArticulosRepository _articulosService;

        public ArticulosController(IArticulosRepository articulosService)
        {
            _articulosService = articulosService;
        }

        [HttpGet]
        public async Task<string> GetArticulos()
        {
            return await Task.Run(() => _articulosService.GetArticulos());
        }



        // nuevos metodos

        [HttpGet("byprecioasc")]
        public async Task<string> GetArticulosByPrecioAsc()
        {
            return await Task.Run(() => _articulosService.GetArticulosByPrecioAsc());
        }

        [HttpGet("bypreciodesc")]
        public async Task<string> GetArticulosByPrecioDesc()
        {
            return await Task.Run(() => _articulosService.GetArticulosByPrecioDesc());
        }

        [HttpGet("byvendidosdesc")]
        public async Task<string> GetArticulosByVendidosDesc()
        {
            return await Task.Run(() => _articulosService.GetArticulosByVendidosDesc());
        }

        [HttpGet("byvaloraciondesc")]
        public async Task<string> GetArticulosByValoracionDesc()
        {
            return await Task.Run(() => _articulosService.GetArticulosByVendidosDesc());
        }

        [HttpGet("bycategoria")]
        public async Task<string> GetArticulosByCategoria(String categoria)
        {
            return await Task.Run(() => _articulosService.GetArticulosByCategoria(categoria));
        }

        [HttpGet("bytitulo")]
        public async Task<string> GetArticulosByTitulo(String titulo)
        {
            return await Task.Run(() => _articulosService.GetArticulosByTitulo(titulo));
        }





        [HttpGet("byid")]
        public async Task<string> GetArticulosBiId(int id)
        {
            return await Task.Run(() => _articulosService.GetArticulosById(id));
        }

        [HttpPost]
        public async Task<bool> PostUser(Articulos articulos)
        {
            return await Task.Run(() => _articulosService.PostArticulos(articulos));
        }

        [HttpPut]
        public async Task<bool> PutUser(Articulos articulos)
        {
            return await Task.Run(() => _articulosService.PutArticulos(articulos));
        }

        [HttpDelete]
        public async Task<bool> DeleteUser(int id)
        {
            return await Task.Run(() => _articulosService.DeleteArticulos(id));
        }


    }
}
