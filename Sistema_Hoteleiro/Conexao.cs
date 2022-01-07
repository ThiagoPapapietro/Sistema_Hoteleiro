using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Hoteleiro
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
         // Construtor
         public Conexao()
         {
             con.ConnectionString = @"Data Source=DESKTOP-EPJFRJN\SQLEXPRESS;Initial Catalog=Athenas;Integrated Security=True";
         }
         // Metodo conector
         public SqlConnection conectar()
         {
             if (con.State == System.Data.ConnectionState.Closed)
             {
                 con.Open();
             }
             return con;
         }
         // Metodo desconectar
         public void desconectar()
         {
             if (con.State == System.Data.ConnectionState.Open)
             {
                 con.Close();
             }
         } 

    }
}

