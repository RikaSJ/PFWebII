using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CinePapu.Modelo;
using CinePapu.util;
using MySql.Data.MySqlClient;

namespace CinePapu.Daos
{
    public class PeliculaDao
    {
        public static void insert(Peliculas p)
        {
            Conexion con = new Conexion();
            String ss= "INSERT INTO Peliculas(Nombre,Descripccion,Autor,Ano,Genero,UrlVideo,UrlImagen)" +
                " VALUES ('"+p.Nombre+"', '"+p.Descriccion+"', '"+p.Autor+"', '"+p.Ano+"', "+p.Genero+", '"+p.UrlVideo+"', 'img\\"+p.UrlImagen+"');";
            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = ss;
            con.EjecutaSQLComando(sqlCom);
        }
    }
}