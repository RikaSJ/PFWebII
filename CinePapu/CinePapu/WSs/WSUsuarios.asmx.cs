using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CinePapu.WSs
{
    /// <summary>
    /// Descripción breve de WSUsuarios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSUsuarios : System.Web.Services.WebService
    {
        //método para insertar un usuario
        [WebMethod]
        public void WSinsertU(Modelo.Usuarios nuevo)
        {
            //inserta un usuario
            Daos.UsuariosDao.insertU(nuevo);
        }

        //metodo para insertar un administrador
        [WebMethod]
        public void WSinsertA(Modelo.Usuarios nuevo)
        {
            //inserta un administrador
            Daos.UsuariosDao.insertA(nuevo);
        }

        //método para buscar un usuario
        [WebMethod]
        public bool WSinsert(Modelo.Usuarios buscar)
        {
            //busca un usuario
            return Daos.UsuariosDao.buscar(buscar);
        }
        //método para buscar el tipo de usuario
        [WebMethod]
        public String WStipo(Modelo.Usuarios buscar)
        {
            //busca el tipo de usuario
            return Daos.UsuariosDao.tipo(buscar);
        }

        //método que busca el nombre del usuario
        [WebMethod]
        public String WSNombre(Modelo.Usuarios buscar)
        {
            //busca el nombre del usuario
            return Daos.UsuariosDao.Nombre(buscar);
        }





    }
}
