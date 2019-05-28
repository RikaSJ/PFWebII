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

        //método para obtener la interacción
        [WebMethod]
        public string WSGetInteraccion()
        {
            //obtiene una lista con los comentarios hecos por el usuario en cierta pelicula
            List<Modelo.Interaccion> lista = InteraccionDao.getComentarios("Efrain_jared@hotmail.com", "Ready Player One");
            
            String strJSON;
            //convierte en objeto JSON la lista 
            strJSON = JsonConvert.SerializeObject(lista,
                          new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            List<Modelo.Peliculas> d = JsonConvert.DeserializeObject<List<Modelo.Peliculas>>(strJSON);


            return strJSON;

        }

    }
}
