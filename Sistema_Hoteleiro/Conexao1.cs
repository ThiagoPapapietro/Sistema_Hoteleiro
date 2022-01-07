using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Hoteleiro
{
    class Conexao1
    {
        //CONEXAO COM O BANCO DE DADOS LOCAL
        string conec = @"Data Source=DESKTOP-EPJFRJN\SQLEXPRESS;Initial Catalog=Athenas;Integrated Security=True;";
        public SqlConnection con1 = null;

        public void AbrirCon()
        {
            try
            {
                con1 = new SqlConnection(conec);
                con1.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void FecharCon()
        {
            try
            {
                con1 = new SqlConnection(conec);
                con1.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
