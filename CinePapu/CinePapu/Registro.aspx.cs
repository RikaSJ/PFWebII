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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

            alerta.Visible = false;
        }

        protected void Registrar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text.Length != 0 && txtEmail.Text.Length != 0 && txtContrasenia.Text.Length != 0)
            {
                Usuarios user = new Usuarios();
                user.Email = txtEmail.Text;
                user.Nombre = txtusuario.Text;
                user.Contrasena = txtContrasenia.Text;

                UsuariosDao.insertU(user);
                Response.Redirect("Login.aspx");
            }else
            {
                alerta.Visible = true;
            }
        }
    }
}