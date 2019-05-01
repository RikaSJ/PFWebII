using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CinePapu.Daos;
using CinePapu.Modelo;

namespace CinePapu
{
    public partial class UserIndex : System.Web.UI.Page
    {
       static Peliculas peli = new Peliculas();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public class pelis{
            
            public String Titulo = peli.Nombre;
            public String ImgUrl = peli.UrlImagen;
            public String VidUrl = peli.UrlVideo;
            public String Descripcion = peli.Descriccion;
        }
    }
}