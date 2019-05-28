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
        //obtener todas las peliculas
        public static DataSet Todas()
        {
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM peliculas");
            return datos;
        }
        //método para insertar pelicula
        public static void insert(Peliculas p)
        {
            Conexion con = new Conexion();
            String img = p.UrlImagen;
            //string que contiene la consulta para insertar la pelicula
            String ss= "INSERT INTO Peliculas(Nombre,Descripccion,Autor,Ano,Genero,UrlVideo,UrlImagen)" +
                " VALUES ('"+p.Nombre+"', '"+p.Descriccion+"', '"+p.Autor+"', '"+p.Ano+"', "+p.Genero+", '"+p.UrlVideo+"', '"+img+"');";
            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = ss;
            //ejecutar la consulta
            con.EjecutaSQLComando(sqlCom);
        }

        //obtiene todas las peliculas
        public static List<Peliculas> getAll()
        {
            List<Peliculas> lista = new List<Peliculas>();
            Conexion con = new Conexion();
            //obtener los datos de las peliculas
            DataSet datos = con.LLenaComboGrid("SELECT * FROM peliculas");
            DataTable dt = datos.Tables[0];
            Peliculas pelis;
            //comienza a llenar la Datatable con los datos de las peliculas
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

        //obtiene el genero de la pelicula
        public static List<Peliculas> getGenero(int Genero)
        {
            List<Peliculas> lista = new List<Peliculas>();
            Conexion con = new Conexion();

            //string de la consulta para obtener el genero
            DataSet datos = con.LLenaComboGrid("SELECT * FROM peliculas WHERE Genero = "+Genero+"");
            DataTable dt = datos.Tables[0];
            Peliculas pelis;
            //Llena la DataTable con los datos de los generos
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

        //obtiene una pelicula por su Id
        public static Peliculas getById(String Id)
        {
            
            Conexion con = new Conexion();
            //consulta que obtiene el id de la pelicula
            DataSet datos = con.LLenaComboGrid("SELECT * FROM peliculas WHERE Nombre = " + Id + "");
            DataTable dt = datos.Tables[0];
            Peliculas pelis=new Peliculas();
            //Llena el DataTable con el id de la pelicula
            foreach (DataRow r in dt.Rows)
            {                
                pelis.Nombre = (string)r.ItemArray[0];
                pelis.Descriccion = (string)r.ItemArray[1];
                pelis.UrlVideo = (string)r.ItemArray[5];
                pelis.UrlImagen = (string)r.ItemArray[6];   
            }


            return pelis;
        }

        //obtiene una lista con las peliculas gustadas por el usuario
        public static List<Peliculas> getLiked(String idUsuario)
        {
            List<Peliculas> lista = new List<Peliculas>();
            Conexion con = new Conexion();
            //string de la consulta para obtener las peliculas gustadas
            DataSet datos = con.LLenaComboGrid("SELECT * FROM peliculas WHERE Nombre in (SELECt Nombre from Interacciones where Email ='" + idUsuario + "' and liked = true group by Nombre)");
            DataTable dt = datos.Tables[0];
            Peliculas pelis;
            //Llena la DataTable con los datos obtenidos de la consulta
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