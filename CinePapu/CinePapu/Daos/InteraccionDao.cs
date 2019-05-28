using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CinePapu.Daos;
using CinePapu.Modelo;
using CinePapu.util;
using MySql.Data.MySqlClient;
using System.Data;

namespace CinePapu.Daos
{
    public class InteraccionDao
    {
        //obtener los comentarios de los usuarios mediante el email
        public static List<Interaccion> getComentarios(String Email, String Nombre)
        {
            List<Interaccion> lista = new List<Interaccion>();
            Conexion con = new Conexion();

            //consulta a la base de datos para obtener los comentarios
            DataSet datos = con.LLenaComboGrid("SELECT * FROM Interacciones where Email = '"+ Email +"' and Nombre = '"+ Nombre +"'");
            //tabla donde serán almacenados los datos
            DataTable dt = datos.Tables[0];
            Interaccion interaccion;
            //llenar la tabla siempre y cuando haya comentarios
            foreach (DataRow r in dt.Rows)
            {
                if (((string)r.ItemArray[3])!="")
                {
                    interaccion = new Interaccion();
                    interaccion.Email = (String)r.ItemArray[1];
                    interaccion.NombrePeli = (String)r.ItemArray[2];
                    interaccion.Comentario = (string)r.ItemArray[3];
                    interaccion.Liked = (bool)r.ItemArray[4];
                    lista.Add(interaccion);
                }
                
                                
            }

            return lista;
        }


    }
}