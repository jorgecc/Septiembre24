using Septiembre24.dal;
using Septiembre24.Models;
using Septiembre24.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Septiembre24
{
    public partial class WebInsertarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // crear el objeto cliente
            Cliente nuevoCliente=ClienteSrv
                .Factory(TextBox1,TextBox2);
            // insertarlo en la base de datos
            ClienteDAL.Insertar(nuevoCliente);
            // redireccionar
            Response.Redirect("WebListarCliente.aspx");
        }
    }
}