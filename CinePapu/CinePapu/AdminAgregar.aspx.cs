using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using CinePapu.Modelo;
using CinePapu.Daos;

namespace CinePapu
{
    public partial class AdminAgregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          /*  try
            {
                if (Request.QueryString["id"].ToString().Equals(""))
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {

                }
            }
            catch
            {
                Response.Redirect("Index.aspx");
            }*/
        }

        protected void guardar_Click(object sender, EventArgs e)
        {
            Byte[] Archivo = null;
            string nombreArchivo = string.Empty;
            string extensionArchivo = string.Empty;
            Peliculas peli = new Peliculas();
            if (fuSubirImagen.HasFile == true)
            {
                using (BinaryReader reader = new BinaryReader(fuSubirImagen.PostedFile.InputStream))
                {
                    Archivo = reader.ReadBytes(fuSubirImagen.PostedFile.ContentLength);
                }
                nombreArchivo = Path.GetFileNameWithoutExtension(fuSubirImagen.FileName);
                extensionArchivo = Path.GetExtension(fuSubirImagen.FileName);
                fuSubirImagen.SaveAs(Server.MapPath("img\\"+fuSubirImagen.FileName));
                peli.Nombre = txtnombre.Text;
                peli.Descriccion = txtdescripccion.Text;
                peli.Autor = txtAutor.Text;
                peli.Ano = txtAno.Text;
                peli.Genero = Genero();
                peli.UrlVideo = txtUrlVideo.Text;
                peli.UrlImagen = nombreArchivo+extensionArchivo;
                PeliculaDao.insert(peli);
                Response.Redirect("AdminIndex.aspx?id=Rok");
            }
            else
            {

            }
            

            
        }
        protected int Genero()
        {
            if (Tipos.Value.Equals("Ciencia ficcion"))
            {
                return 1;
            }else if (Tipos.Value.Equals("Terror"))
            {
                return 2;
            }
            else if (Tipos.Value.Equals("Comedia"))
            {
                return 3;
            }
            else if (Tipos.Value.Equals("Thiller"))
            {
                return 4;
            }
            else if (Tipos.Value.Equals("Accion"))
            {
                return 5;

            }
            else if (Tipos.Value.Equals("Aventura"))
            {
                return 6;
            }
            else if (Tipos.Value.Equals("Animada"))
            {
                return 7;

            }
            else if (Tipos.Value.Equals("Fantasia"))
            {
                return 8;

            }
            else if (Tipos.Value.Equals("Drama"))
            {
                return 9;

            }
            else if (Tipos.Value.Equals("Romanticas"))
            {
                return 10;

            }
            else { return 0; }
            
        }
    }
}