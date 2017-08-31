using pesquisarJogo.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Conferencia
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Carrega parametros de inicialização para  a tela de pesquisa
            Parametros param = new Parametros();
            param.Arquivo = @"C:\Projetos\teste.txt";
            param.Delimitador = "#";
            param.JogoInicio = "0010";
            param.JogoFim = "0020";
            param.NoJogo = "0011";

            //Para os parametros
            Application.Run(new Pesquisar(param));
        }
    }
}
