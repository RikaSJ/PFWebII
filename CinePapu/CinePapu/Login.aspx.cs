using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CinePapu.Modelo;
using CinePapu.Daos;
namespace CinePapu
{
    public partial class Login : System.Web.UI.Page
    {
        public static Usuarios sesion = new Usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            alerta.Visible = false;
        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();

            user.Email = txtusuario.Text;
            user.Contrasena = txtcontrasenia.Text;

            if (UsuariosDao.buscar(user) == true)
            {
                if (UsuariosDao.tipo(user).Equals("admin"))
                {
                    String nom = UsuariosDao.Nombre(user);
                    user.Nombre = nom;
                    sesion = user;
                    Response.Redirect("AdminIndex.aspx?id=" + nom);
                }
                else
                {
                    String nom = UsuariosDao.Nombre(user);
                    user.Nombre = nom;
                    sesion = user;
                    Response.Redirect("UserIndex.aspx?id="+nom+"&gen=general");

                }
                
            }
            else
            {
                alerta.Visible = true;
            }
        }

        protected void Registrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
    }
}