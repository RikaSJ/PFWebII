using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using CinePapu.Modelo;
using CinePapu.util;
using MySql.Data.MySqlClient;

namespace CinePapu.Daos
{
    public class UsuariosDao
    {
        //metodo para obtener todos los usuarios
        public static DataSet Todos()
        {
            Conexion con = new Conexion();
            //string de la consulta para obetner a los usuarios
            DataSet datos = con.LLenaComboGrid("SELECT Nombre,Email,Tipo FROM usuarios");
            return datos;
        }
        //metodo para insertar un usuario
        public static void insertU(Usuarios u)
        {
            Conexion con = new Conexion();
            //string de la consulta para insertar el usuario
            String SQL = "INSERT INTO Usuarios(Nombre, Email, Tipo, Contrasena)" +
                "VALUES (@nombre, @email, 'user', @contrasena);";
            
            //definir los parametros que serán enviados a la consulta
            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@nombre", u.Nombre);
            sqlCom.Parameters.AddWithValue("@email", u.Email);
            sqlCom.Parameters.AddWithValue("@contrasena", u.Contrasena);
            //ejecuta la consulta
            con.EjecutaSQLComando(sqlCom);
            
        }
        //metodo para insertar un admin
        public static void insertA(Usuarios u)
        {
            Conexion con = new Conexion();
            //string de la consulta para insertar un admin
            String SQL = "INSERT INTO Usuarios(Nombre, Email, Tipo, Contrasena)" +
                "VALUES (@nombre, @email, 'admin', @contrasena);";
            //definir los parametros que serán enviados a la consulta
            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@nombre", u.Nombre);
            sqlCom.Parameters.AddWithValue("@email", u.Email);
            sqlCom.Parameters.AddWithValue("@contrasena", u.Contrasena);
            //ejecuta la consulta
            con.EjecutaSQLComando(sqlCom);
        }
        //metodo para buscar un usuario
        public static bool buscar(Usuarios u)
        {
            Conexion con = new Conexion();
            //string de la consulta para buscar el usuario
            String SQL = "SELECT count(*) FROM Usuarios " +
                "WHERE Email = @email AND Contrasena = @contrasena;";
            //definir los parametros que serán enviados a la consulta
            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@email", u.Email);
            sqlCom.Parameters.AddWithValue("@contrasena", u.Contrasena);
            //ejecuta la consulta
            con.EjecutaSQLComando(sqlCom);
            //obtener un contador de los usuarios devueltos
            int count = con.revision(sqlCom);
            //si hay usuario devuekve true, de lo contrario devuelve false
            if (count == 0)
            {
                return false;
            }else
            {
                return true;
            }
        }
        //metodo que obtiene el tipo de usuario
        public static String tipo(Usuarios u)
        {
            Conexion con = new Conexion();
            //string de la consulta para obtener el usuario
            String SQL = "SELECT Tipo FROM Usuarios " +
                "WHERE Email = @email AND Contrasena = @contrasena;";
            //definir los parametros que serán enviados a la consulta
            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@email", u.Email);
            sqlCom.Parameters.AddWithValue("@contrasena", u.Contrasena);
            //ejecuta la consulta
            con.EjecutaSQLComando(sqlCom);
            String Tip = con.EjecutaSQLScalar(sqlCom);
            return Tip;
        }
        //metodo que obtiene el nombre del usuario
        public static String Nombre(Usuarios u)
        {
            Conexion con = new Conexion();
            //string de la consulta para obtener el nombre de usuario
            String SQL = "SELECT Nombre FROM Usuarios " +
                "WHERE Email = @email AND Contrasena = @contrasena;";
            //definir los parametros que serán enviados a la consulta
            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@email", u.Email);
            sqlCom.Parameters.AddWithValue("@contrasena", u.Contrasena);
            //ejecutar la consulta
            con.EjecutaSQLComando(sqlCom);
            String Tip = con.EjecutaSQLScalar(sqlCom);
            return Tip;
        }
    }
}