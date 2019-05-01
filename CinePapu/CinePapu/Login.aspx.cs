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
                    Response.Redirect("AdminIndex.aspx");
                }
                else
                {
                    Response.Redirect("index.aspx");
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