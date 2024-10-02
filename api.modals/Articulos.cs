using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.modals
{
    public class Articulos
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public int Valoracion { get; set; }
        public int Precio { get; set; }
        public int Vendidos { get; set; }
        public string Imagen { get; set; }
    }
}
