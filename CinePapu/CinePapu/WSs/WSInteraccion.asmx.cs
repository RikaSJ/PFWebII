using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using CinePapu.Daos;
using CinePapu.Modelo;


namespace CinePapu.WSs
{
    /// <summary>
    /// Descripción breve de WSInteraccion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSInteraccion : System.Web.Services.WebService
    {

        [WebMethod]
        public string WSGetInteraccion(String Nombre)
        {

            List<Modelo.Interaccion> lista = InteraccionDao.getComentarios(Nombre);
            
            String strJSON;

            strJSON = JsonConvert.SerializeObject(lista,
                          new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            List<Modelo.Peliculas> d = JsonConvert.DeserializeObject<List<Modelo.Peliculas>>(strJSON);


            return strJSON;

        }

        [WebMethod]
        public void WSNuevaInteraccion(Interaccion nueva)
        {
            Daos.InteraccionDao.insertInteraccion(nueva);
        }

    }
}
