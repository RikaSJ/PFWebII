using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CinePapu.Daos;
using CinePapu.Modelo;
using System.Data;

namespace CinePapu
{
    public partial class UserIndex : System.Web.UI.Page
    {
        static Peliculas peli = new Peliculas();
        protected  IList<Peliculas> pelis;
        protected void Page_Load(object sender, EventArgs e)
        {
            pelis = PeliculaDao.getAll();
            String contenido = "";
            foreach (var dr in pelis)
            {
                contenido = "<div class=\"w3 - row - padding w3 - padding - 16 w3 - center\" id=\"food\">";
                contenido += "<div class=\"w3 - quarter\">";
                contenido += "<img src=\" img\\"+dr.UrlImagen+" \"  style=\"width: 100 % \" />";
                contenido += "<h3>"+dr.Nombre+"</h3>";
                contenido += "<p>"+dr.Descriccion+"</p>";
              //contenido += "<iframe width=\"640\" height=\"360\" frameborder=\"0\" src=\"https://mega.nz/embed#!3d5nCA5R!osi7iZD2abALC7agwVRh0BgddpReMJkDl92rOq69KZM\" allowfullscreen></iframe>";
                contenido += "<a href=\""+dr.UrlVideo+"\">Ver pelicula</a>";
                contenido += "</div>";
                contenido += "</div>";
            }
            
            myLiteral.Text = contenido;
        }

        protected static List<Peliculas> lista()
        {            

            return PeliculaDao.getAll();
        
        }
}
}