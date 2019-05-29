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
    //contenido += "<iframe width=\"640\" height=\"360\" frameborder=\"0\" src=\"https://mega.nz/embed#!3d5nCA5R!osi7iZD2abALC7agwVRh0BgddpReMJkDl92rOq69KZM\" allowfullscreen></iframe>";
    public partial class UserIndex : System.Web.UI.Page
    {
        static Peliculas peli = new Peliculas();
        
        protected  IList<Peliculas> pelis;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["id"].ToString().Equals(""))
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    if (Request.QueryString["id"].ToString().Equals("CP"))
                    {
                        if ((Request.QueryString["genero"].ToString().Equals("general")))
                        {
                            LlenarVista();
                        }
                        else
                        {
                            ComprobarGenero();
                        }
                    }
                    else
                    {
                        if ((Request.QueryString["gen"].ToString().Equals("general")))
                        {
                            LlenarVista();
                        }
                        else
                        {
                            ComprobarGenero();
                        }
                    }                    
                }
            }
            catch
            {
                Response.Redirect("Index.aspx");
            }
           
        }
        protected void ComprobarGenero()
        {
            try
            {
                if ((Request.QueryString["genero"].ToString().Equals("CienciaFiccion")))
                {
                    LlenarGenero(1);
                }
                else if ((Request.QueryString["genero"].ToString().Equals("Terror")))
                {
                    LlenarGenero(2);
                }
                else if ((Request.QueryString["genero"].ToString().Equals("Comedia")))
                {
                    LlenarGenero(3);
                }
                else if ((Request.QueryString["genero"].ToString().Equals("Thriller")))
                {
                    LlenarGenero(4);
                }
                else if ((Request.QueryString["genero"].ToString().Equals("Accion")))
                {
                    LlenarGenero(5);
                }
                else if ((Request.QueryString["genero"].ToString().Equals("Aventura")))
                {
                    LlenarGenero(6);
                }
                else if ((Request.QueryString["genero"].ToString().Equals("Animada")))
                {
                    LlenarGenero(7);
                }
                else if ((Request.QueryString["genero"].ToString().Equals("Fantasia")))
                {
                    LlenarGenero(8);
                }
                else if ((Request.QueryString["genero"].ToString().Equals("Drama")))
                {
                    LlenarGenero(9);
                }
                else if ((Request.QueryString["genero"].ToString().Equals("Romanticas")))
                {
                    LlenarGenero(10);
                }
            }
            catch
            {
                    LlenarVista();
            }
             
        }

        protected void LlenarVista()
        {
            String contenido="";
                pelis = PeliculaDao.getAll();
             contenido += "<div class=\"w3-row-padding w3-padding-16 w3-center\" id=\"food\">";
            foreach (var dr in pelis)
            {
               
                contenido += "<div class=\"w3-quarter w3-hover-opacity w3-hover-shadow \">";
                contenido += "<a href=\"UserDescripcionPelicula.aspx?peli=" + dr.Nombre + "\"><img src=\" img\\" + dr.UrlImagen + " \"  width=\"220\" height=\"326\" \" /></a>";
                contenido += "<h3>" + dr.Nombre + "</h3>";
                contenido += "<p>" + dr.Descriccion + "</p>";
                contenido += "<a href=\"" + dr.UrlVideo + "\">Ver pelicula directamente</a>";
                contenido += "</div>";
                
            }
            contenido += "</div>";
            myLiteral.Text = contenido;

        }
        protected void LlenarGenero(int Genero)
        {

            pelis = PeliculaDao.getGenero(Genero);
            
            String contenido = "<div class=\"w3-row-padding w3-padding-16 w3-center\" id=\"food\">";
            foreach (var dr in pelis)
            {

                contenido += "<div class=\"w3-quarter w3-hover-opacity w3-hover-shadow \">";
                contenido += "<a href=\"UserDescripcionPelicula.aspx?peli=" + dr.Nombre + "\"><img src=\" img\\" + dr.UrlImagen + " \"  width=\"220\" height=\"326\" \" /></a>";
                contenido += "<h3>" + dr.Nombre + "</h3>";
                contenido += "<p>" + dr.Descriccion + "</p>";
                contenido += "<a href=\"" + dr.UrlVideo + "\">Ver pelicula</a>";
                contenido += "</div>";

            }
            contenido += "</div>";

            myLiteral.Text = contenido;

        }
    }
}