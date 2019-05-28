using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CinePapu.Modelo;
using CinePapu.WSs;
using Newtonsoft.Json;

namespace CinePapu
{
    public partial class UserDescripcionPelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Peliculas select = new Peliculas()
            {
                Nombre= Convert.ToString(Request.QueryString["nombre"]),
        };
            txtTitulo.Text = select.Nombre;
            
            WSPelicula WSPeli = new WSPelicula();
            String selected = WSPeli.WSGetLiked();
            ImagenPortada.ImageUrl = "";
            List<Peliculas> lista = null;


        }
    }
}