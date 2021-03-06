﻿using System;
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
            String JsonPelcula = new WSPelicula().WSGetByID(Convert.ToString(Request.QueryString["peli"]));

            Peliculas select = JsonConvert.DeserializeObject<Peliculas>(JsonPelcula);
            txtTitulo.Text = "Titulo: " + select.Nombre;

            txtDescripcion.Text = "Descripcion: " + select.Descriccion;
            txtAno.Text = "Año: " + select.Ano;
            WSPelicula WSPeli = new WSPelicula();
            String selected = WSPeli.WSGetLiked();
            ImagenPeli.ImageUrl = "img/" + select.UrlImagen;
            UrlPeli.Attributes.Add("src", select.UrlVideo);
            String JsonInteracciones = new WSInteraccion().WSGetInteraccion(select.Nombre);
            List<Interaccion> listaInteracciones = JsonConvert.DeserializeObject<List<Interaccion>>(JsonInteracciones);

            llenarComentarios(listaInteracciones);

            //evaluar si la pelicula tiene like
            //agregar un metodo a DaoInteraccion que reciba un String del nombre de la pelicula y haga la consulta de sus interacciones
            
            // si si cambias el color al boton like y lo desabilitas

        }

        public void llenarComentarios(IList<Interaccion> Comentarios)
        {
            String contenido = "";
            foreach (var dr in Comentarios)
            {
                contenido += "<div class=\"w3-col m1\">";
                contenido += "<img src=\"img/usuario-sin-foto.png\" style=\"width: 75%\" class=\"w3-centered\"/>";
                contenido += "</div>";
                contenido += "<div class=\"w3-col m11 w3-centered\">";
                contenido += "<div class=\"w3-container w3-green\">";
                contenido += "<h7>" + dr.Email + "</h7>";
                contenido += "</div>";
                contenido += "<p>" + dr.Comentario + "</p>";
                contenido += "</div>";
                contenido += "";
            }

            LiteralComentarios.Text = contenido;

        }

        protected void btnCComentar_Click(object sender, EventArgs e)
        {
            if (IsPostBack) { 
            if (txtComentario.InnerText != "")
            {
                Interaccion nueva = new Interaccion()
                {
                    Email = Login.sesion.Email,
                    NombrePeli = Convert.ToString(Request.QueryString["peli"]),
                    Comentario = txtComentario.InnerText,
                    Liked = false
                };
                    txtComentario.InnerText = "";
                new WSInteraccion().WSNuevaInteraccion(nueva);
                    Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);

            }
        }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // funcionalidad
            // generar una interaccion con el comentario vacio
            // guardar con el WSInteraccion agregar interaccion
            // recargas la pagina

        }
    }
}