using Septiembre24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

namespace Septiembre24.dal
{
    public class ClienteDAL
    {
        public static List<Cliente> Listar()
        {
            var resultado=new List<Cliente>();
            // ado.net

            // 1) Conectarme a la base de datos
            string cadena= "Data Source=PCJC;Initial Catalog=base2019;Persist Security Info=True;User ID=sa;Password=abc.123";

            SqlConnection con=new SqlConnection(cadena);

            con.Open();

            // 2) Crear un comando
            string sql= "select * from clientes";

            SqlCommand com=new SqlCommand(sql,con);
            
            // 3) Ejecutar el comando

            // Ejecuta el comando y crear un lector
            SqlDataReader lector=com.ExecuteReader();

            // com.ExecuteReader(); devuelve datos para leer.
            // com.ExecuteNonQuery(); ejecuta y no devuelve valor.
            // com.ExecuteScalar(); devuelve solo el primer valor

            // 4) Leer los registros

            // foreach = list

            while(lector.Read())
            {
                Cliente cliente=new Cliente();
                cliente.Rut=lector.GetString(0);
                cliente.Nombre=lector.GetString(1);

                resultado.Add(cliente);
            }

            // 5) cierro las conexiones !
            lector.Close();
            con.Close();
            
            // 6) Devuelvo los datos

            return resultado;
        }

        public static void Insertar(Cliente cliente)
        {
            // 1) Conectarme a la base de datos
            string cadena = "Data Source=PCJC;Initial Catalog=base2019;Persist Security Info=True;User ID=sa;Password=abc.123";

            SqlConnection con = new SqlConnection(cadena);

            con.Open();


            // 2) Crear un comando
            string sql = "insert into clientes(rut, nombre) values ('"+cliente.Rut+"','"+cliente.Nombre+"')";

            SqlCommand com=new SqlCommand(sql,con);

            com.ExecuteNonQuery();

            // 3) cerrar la conexion

            con.Close();

        }
    }
}