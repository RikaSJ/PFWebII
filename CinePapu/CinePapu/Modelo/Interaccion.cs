using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinePapu.Modelo
{
    //clase donde almacenaremos las iteracciones de los usuarios
    public class Interaccion
    {
        public String Email { get; set; }
        public String NombrePeli { get; set; }
        public String Comentario { get; set; }
        public bool Liked { get; set; }

    }
}