using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinePapu.Modelo
{
    public class Peliculas
    {
        public String Nombre { get; set; }
        public String Descriccion { get; set; }
        public String Autor { get; set; }
        public String Ano { get; set; }
        public int Genero { get; set; }
        public String UrlVideo { get; set; }
        public String UrlImagen { get; set; }
    }
}