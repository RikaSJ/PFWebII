using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CinePapu.Modelo;
using CinePapu.util;
using MySql.Data.MySqlClient;

namespace CinePapu.Daos
{
    public class UsuariosDao
    {
        public static void insertU(Usuarios u)
        {
            Conexion con = new Conexion();
            String SQL = "INSERT INTO Usuarios(Nombre, Email, Tipo, Contrasena)" +
                "VALUES (@nombre, @email, 'user', @contrasena);";
            
            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@nombre", u.Nombre);
            sqlCom.Parameters.AddWithValue("@email", u.Email);
            sqlCom.Parameters.AddWithValue("@contrasena", u.Contrasena);
            con.EjecutaSQLComando(sqlCom);
        }
        public static void insertA(Usuarios u)
        {
            Conexion con = new Conexion();
            String SQL = "INSERT INTO Usuarios(Nombre, Email, Tipo, Contrasena)" +
                "VALUES (@nombre, @email, 'admin', @contrasena);";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@nombre", u.Nombre);
            sqlCom.Parameters.AddWithValue("@email", u.Email);
            sqlCom.Parameters.AddWithValue("@contrasena", u.Contrasena);
            con.EjecutaSQLComando(sqlCom);
        }
        public static bool buscar(Usuarios u)
        {
            Conexion con = new Conexion();
            String SQL = "SELECT count(*) FROM Usuarios " +
                "WHERE Email = @email AND Contrasena = @contrasena;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@email", u.Email);
            sqlCom.Parameters.AddWithValue("@contrasena", u.Contrasena);
            con.EjecutaSQLComando(sqlCom);
            int count = con.revision(sqlCom);
            if (count == 0)
            {
                return false;
            }else
            {
                return true;
            }
        }
        public static String tipo(Usuarios u)
        {
            Conexion con = new Conexion();
            String SQL = "SELECT Tipo FROM Usuarios " +
                "WHERE Email = @email AND Contrasena = @contrasena;";
            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@email", u.Email);
            sqlCom.Parameters.AddWithValue("@contrasena", u.Contrasena);
            con.EjecutaSQLComando(sqlCom);
            String Tip = con.EjecutaSQLScalar(sqlCom);
            return Tip;
        }
    }
}