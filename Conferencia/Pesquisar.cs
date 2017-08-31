using Conferencia.Controle;
using Conferencia.Util;
using pesquisarJogo.Controle;
using System;
using System.Windows.Forms;

namespace Conferencia
{
    public partial class Pesquisar : Form
    {
        Parametros parametro = new Parametros();
        public Pesquisar()
        {
            InitializeComponent();
        }

        public Pesquisar(Parametros param)
        {
            //Inicializa objetos
            InitializeComponent();
            //Caso seja parado parametro atribui aos objetos
            txt_arquivo.Text    = param.Arquivo;
            txtSerieInicio.Text = param.JogoInicio;
            txtSerieFinal.Text  = param.JogoFim;
            txtDelimitador.Text = param.Delimitador;
            txtSerie.Text       = param.NoJogo;


        }

        private void btn_seleciona_arquivo_Click(object sender, EventArgs e)
        {   
            //Seleciona o Arquivo
            if (ofd_arquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {   
                txt_arquivo.Text = ofd_arquivo.FileName;
            }
            
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            //Inicializa valor default
            txt_seq_1.Text = "@@-@@-@@-@@-@@";
            txt_seq_2.Text = "@@-@@-@@-@@-@@";
            txt_seq_3.Text = "@@-@@-@@-@@-@@";
            txt_seq_4.Text = "@@-@@-@@-@@-@@";

            //Carrega dados aos parametros de busca
            if (txt_arquivo.Text.Length > 0)
                parametro.Arquivo = txt_arquivo.Text;
            if (txtSerieInicio.Text.Length > 0)
                parametro.JogoInicio = txtSerieInicio.Text;
            if (txtSerieFinal.Text.Length > 0)
                parametro.JogoFim = txtSerieFinal.Text;
            if (txtDelimitador.Text.Length > 0)
                parametro.Delimitador = txtDelimitador.Text;

            parametro.NoJogo = txtSerie.Text;

            //Verifica se os dados foram preenchidos
            if ((parametro.Arquivo == null) || 
                (parametro.Delimitador.Length == 0) ||
                (parametro.NoJogo.Length == 0) 
                )
            {
                MessageBox.Show("Verifique as informações.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Passa o objeto de parametro para pesquisa
            PesquisaJogo PesqJogo = new PesquisaJogo(parametro);

            //Busca o resultado dad busca
            Result resultado = PesqJogo.RealizarBusca();
            
            if (resultado.Numeros != null)
            {
                //Formata a seguencia de números com traço "-"
                FormartarString formata = new FormartarString();
                txt_seq_1.Text = formata.SeparandoComTraco(resultado.Numeros[0]);
                txt_seq_2.Text = formata.SeparandoComTraco(resultado.Numeros[1]);
                txt_seq_3.Text = formata.SeparandoComTraco(resultado.Numeros[2]);
                txt_seq_4.Text = formata.SeparandoComTraco(resultado.Numeros[3]);
            }
            else
            {
                MessageBox.Show(resultado.Msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {

            
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {


            ////Se a tecla digitada não for número e nem backspace
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            //{
            //    //Atribui True no Handled para cancelar o evento
            //    e.Handled = true;
            //}
        }

        private void txtSerie_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Valor inválido!");
        }
    }
}
