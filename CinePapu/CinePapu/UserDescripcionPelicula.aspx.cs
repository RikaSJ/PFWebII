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
                Nombre= Convert.ToString(Request.QueryString["peli"]),
        };
            txtTitulo.Text ="Titulo: "+select.Nombre;

            txtDescripcion.Text = "Descripcion: /n" +select.Descriccion;
            txtAno.Text = "Año: "+select.Ano;
            WSPelicula WSPeli = new WSPelicula();
            String selected = WSPeli.WSGetLiked();
            ImagenPeli.ImageUrl = "img/"+select.UrlImagen;
            UrlPeli.Attributes.Add("src", select.UrlVideo);
            List<Peliculas> lista = null;


        }
    }
}