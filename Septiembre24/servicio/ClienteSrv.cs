using Septiembre24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Septiembre24.servicio
{
    public class ClienteSrv
    {
        public static Cliente Factory(TextBox txtRut,TextBox txtNombre)
        {
            Cliente resultado=new Cliente();
            resultado.Rut=txtRut.Text;
            resultado.Nombre=txtNombre.Text;
            return resultado;
        }
    }
}