using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CinePapu.Daos;


namespace CinePapu
{
    public partial class AdminPelis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GvPelis.DataSource = PeliculaDao.Todas();
        }
    }
}