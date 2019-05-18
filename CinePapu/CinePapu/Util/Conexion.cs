using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinePapu.util
{
    //Tomado de: https://code.msdn.microsoft.com/windowsapps/Clase-para-gestionar-la-779f77c6
    public class Conexion
    {


        /// <summary> 
        /// Conexión a la Base de Datos con SQLOLEDB 
        /// </summary> 
        /// <returns>string de Conexión a la Base de Datos</returns> 
        public string GetConnectionString()
        {
            //Revisar: https://www.connectionstrings.com/mysql/
            //String servidor = "localhost";
            //String puerto = "3306";
            //String usuario = "root";
            //String password = "root";
            //String database = "cinepapu";

            String servidor = "mysql5011.site4now.net";
            String puerto = "3306";
            String usuario = "a48cc2_cinepap";
            String password = "cinepapu19";
            String database = "db_a48cc2_cinepap";

            //Cadena de conexion

            return String.Format("server={0};port={1};user id={2}; password={3}; database={4}", servidor, puerto, usuario, password, database);
        }

        /// <summary> 
        /// Ejecuta un comando SQL 
        /// </summary> 
        /// <param name="sComandoSql">Comando SQL para ejecutar Insert, Delete y Update</param> 
        public void EjecutaSQLComando(MySqlCommand sqlCom)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            //MySqlCommand sqlCom = new MySqlCommand();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                //sqlCom.CommandText = sComandoSql;
                sqlCom.ExecuteNonQuery();
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public int revision(MySqlCommand sqlCom)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                int count = Convert.ToInt32(sqlCom.ExecuteScalar());
                return count;
            }
        
            finally
            {
                sqlConn.Close(); 
            }
            
        }
        /// <summary> 
        /// Ejecuta un comando SQL y retorna un parámetro 
        /// </summary> 
        /// <param name="sComandoSql">Comando SQL</param> 
        public string EjecutaSQLScalar(string sComandoSql)
        {
            string regreso = "";
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCom = new MySqlCommand();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                sqlCom.CommandText = sComandoSql;
                regreso = sqlCom.ExecuteScalar().ToString();
            }

            finally
            {
                sqlConn.Close();
            }
            return regreso;
        }
        public string EjecutaSQLScalar(MySqlCommand sqlCom)
        {
            string regreso = "";
            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                regreso = sqlCom.ExecuteScalar().ToString();
            }

            finally
            {
                sqlConn.Close();
            }
            return regreso;
        }
        /// <summary> 
        /// Esta Función Sirve para llenar GridsView y Combos 
        /// Regresa un DataSet por lo que puede servir para mas 
        /// Controles de Datos 
        /// </summary> 
        /// <param name="mysql">mySql es la Sentencia en a Ejecutar para el llenado del Control</param> 
        /// <returns>Dataset para su llenado,DataGrids, Combos, etc</returns> 
        public DataSet LLenaComboGrid(string mysql)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cnn.ConnectionString = GetConnectionString();
                cnn.Open();
                cmd.CommandText = mysql;
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cnn;
                da.Fill(ds);
            }
            finally
            {
                cnn.Close();
            }
            return ds;
        }

    }

}
