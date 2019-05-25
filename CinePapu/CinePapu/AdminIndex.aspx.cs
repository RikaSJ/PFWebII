using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CinePapu
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["id"].ToString().Equals(""))
                {
                    Response.Redirect("Index.aspx");
                }
                if (Request.PathInfo.Length != 0)
                {
                    Request.PathInfo.Substring(1);
                }
            }
            catch
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}