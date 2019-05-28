using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using CinePapu.Modelo;
using CinePapu.Daos;

namespace CinePapu.WSs
{
    /// <summary>
    /// Descripción breve de WSPelicula
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSPelicula : System.Web.Services.WebService
    {
        //método para obtener todas las peliculas
        [WebMethod]
        public string WSGetAll()
        {
            //obtiene una lista de peliculas
            List<Modelo.Peliculas> lista = Daos.PeliculaDao.getAll();
            String strJSON;
            //convierte en objeto JSON la lista
            strJSON = JsonConvert.SerializeObject(lista,
                          new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            List<Modelo.Peliculas> d = JsonConvert.DeserializeObject < List<Modelo.Peliculas>>(strJSON);
           

            return strJSON;
            
        }

        //método para insertar una pelicula
        [WebMethod]
        public void WSinsert(Modelo.Peliculas nueva)
        {
            //inserta ua pelicula nueva
            Daos.PeliculaDao.insert(nueva);
        }

        //obtiene el genero de la pelicula
        [WebMethod]
        public String WSgetGenero(int Genero)
        {
            //obtiene una lista de generos
            List<Modelo.Peliculas> lista = Daos.PeliculaDao.getGenero(Genero);
            String strJSON;
            //convierte en objeto JSON la lista
            strJSON = JsonConvert.SerializeObject(lista,
                          new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            return strJSON;

        }

        //obtiene los likes en los que el usuario interactuó
        [WebMethod]
        public string WSGetLiked()
        {
            //obtiene una lista de likes por el usuario
            List<Modelo.Peliculas> lista = Daos.PeliculaDao.getLiked("Efrain_jared@hotmail.com");
            String strJSON;
            //convierte en objeto JSON la lista
            strJSON = JsonConvert.SerializeObject(lista,
                          new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            List<Modelo.Peliculas> d = JsonConvert.DeserializeObject<List<Modelo.Peliculas>>(strJSON);


            return strJSON;

        }

        [WebMethod]
        public string WSGetByID(String ID)
        {

          Peliculas Peli = Daos.PeliculaDao.getById(ID);
            String strJSON;

            strJSON = JsonConvert.SerializeObject(Peli,
                          new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            

            return strJSON;

        }

    }
}
