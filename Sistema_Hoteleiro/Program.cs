using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Hoteleiro
{
    static class Program
    {

        // Declaração de variaveis globais do sistema
        public static string nomeUsuario;
        public static string cargoUsuario;

        public static string chamadaProdutos;
        public static string chamadaHospedes;

        public static string nomeHospede;

        public static string idProduto;
        public static string nomeProduto;
        public static string estoqueProduto;
        public static string valorProduto;

        public static string idVenda;

        public static string idNovoServico;
        public static string idReserva;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());
        }
    }
}
