using Septiembre24.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Septiembre24
{
    public partial class WebListarCliente : System.Web.UI.Page
    {
        // todo lo que hay que cargar al comienzo
        // puede ejecutarse antes o despues del postback
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource=ClienteDAL.Listar();
            GridView1.DataBind(); // refresca y recrear la grilla
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebInsertarCliente.aspx");

        }
    }
}