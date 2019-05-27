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
        public static List<Interaccion> getComentarios(String Email, String Nombre)
        {
            List<Interaccion> lista = new List<Interaccion>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM Interacciones where Email = '"+ Email +"' and Nombre = '"+ Nombre +"'");
            DataTable dt = datos.Tables[0];
            Interaccion interaccion;
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