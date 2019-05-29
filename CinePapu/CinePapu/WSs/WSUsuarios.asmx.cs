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

        [WebMethod]
        public void WSinsertU(Modelo.Usuarios nuevo)
        {
            Daos.UsuariosDao.insertU(nuevo);
        }

        [WebMethod]
        public void WSinsertA(Modelo.Usuarios nuevo)
        {
            Daos.UsuariosDao.insertA(nuevo);
        }

        [WebMethod]
        public bool WSinsert(Modelo.Usuarios buscar)
        {
            return Daos.UsuariosDao.buscar(buscar);
        }

        [WebMethod]
        public String WStipo(Modelo.Usuarios buscar)
        {
            return Daos.UsuariosDao.tipo(buscar);
        }

        [WebMethod]
        public String WSNombre(Modelo.Usuarios buscar)
        {
            return Daos.UsuariosDao.Nombre(buscar);
        }





    }
}
