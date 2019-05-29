using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CinePapu.Modelo;
using CinePapu.util;
using MySql.Data.MySqlClient;
using System.Data;

namespace CinePapu.Daos
{
    public class PeliculaDao
    {
        public static DataSet Todas()
        {
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM peliculas");
            return datos;
        }
        public static void insert(Peliculas p)
        {
            Conexion con = new Conexion();
            String img = p.UrlImagen;
            String ss= "INSERT INTO Peliculas(Nombre,Descripccion,Autor,Ano,Genero,UrlVideo,UrlImagen)" +
                " VALUES ('"+p.Nombre+"', '"+p.Descriccion+"', '"+p.Autor+"', '"+p.Ano+"', "+p.Genero+", '"+p.UrlVideo+"', '"+img+"');";
            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = ss;
            con.EjecutaSQLComando(sqlCom);
        }
        public static List<Peliculas> getAll()
        {
            List<Peliculas> lista = new List<Peliculas>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM peliculas");
            DataTable dt = datos.Tables[0];
            Peliculas pelis;
            foreach (DataRow r in dt.Rows)
            {

                pelis = new Peliculas();
                pelis.Nombre = (string)r.ItemArray[0];
                pelis.Descriccion = (string)r.ItemArray[1];                
                pelis.UrlVideo = (string)r.ItemArray[5];
                pelis.UrlImagen = (string)r.ItemArray[6];
                lista.Add(pelis);
            }

            return lista;
        }
        public static List<Peliculas> getGenero(int Genero)
        {
            List<Peliculas> lista = new List<Peliculas>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM peliculas WHERE Genero = "+Genero+"");
            DataTable dt = datos.Tables[0];
            Peliculas pelis;
            foreach (DataRow r in dt.Rows)
            {

                pelis = new Peliculas();
                pelis.Nombre = (string)r.ItemArray[0];
                pelis.Descriccion = (string)r.ItemArray[1];
                pelis.UrlVideo = (string)r.ItemArray[5];
                pelis.UrlImagen = (string)r.ItemArray[6];
                lista.Add(pelis);
            }

            return lista;
        }
        public static Peliculas getById(String Id)
        {
            
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM peliculas WHERE Nombre = '" + Id + "'");
            DataTable dt = datos.Tables[0];
            Peliculas pelis=new Peliculas();
            foreach (DataRow r in dt.Rows)
            {                
                pelis.Nombre = (string)r.ItemArray[0];
                pelis.Descriccion = (string)r.ItemArray[1];
                pelis.UrlVideo = (string)r.ItemArray[5];
                pelis.UrlImagen = (string)r.ItemArray[6];   
            }


            return pelis;
        }
        public static List<Peliculas> getLiked(String idUsuario)
        {
            List<Peliculas> lista = new List<Peliculas>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM peliculas WHERE Nombre in (SELECt Nombre from Interacciones where Email ='" + idUsuario + "' and liked = true group by Nombre)");
            DataTable dt = datos.Tables[0];
            Peliculas pelis;
            foreach (DataRow r in dt.Rows)
            {

                pelis = new Peliculas();
                pelis.Nombre = (string)r.ItemArray[0];
                pelis.Descriccion = (string)r.ItemArray[1];
                pelis.UrlVideo = (string)r.ItemArray[5];
                pelis.UrlImagen = (string)r.ItemArray[6];
                lista.Add(pelis);
            }

            return lista;
        }
    }
}