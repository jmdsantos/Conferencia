namespace Conferencia
{
    partial class Pesquisar 
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_seleciona_arquivo = new System.Windows.Forms.Button();
            this.txt_arquivo = new System.Windows.Forms.TextBox();
            this.ofd_arquivo = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerieInicio = new System.Windows.Forms.TextBox();
            this.txtSerieFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDelimitador = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.txt_seq_1 = new System.Windows.Forms.TextBox();
            this.txt_seq_2 = new System.Windows.Forms.TextBox();
            this.txt_seq_3 = new System.Windows.Forms.TextBox();
            this.txt_seq_4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_seleciona_arquivo
            // 
            this.btn_seleciona_arquivo.Location = new System.Drawing.Point(332, 12);
            this.btn_seleciona_arquivo.Name = "btn_seleciona_arquivo";
            this.btn_seleciona_arquivo.Size = new System.Drawing.Size(109, 23);
            this.btn_seleciona_arquivo.TabIndex = 1;
            this.btn_seleciona_arquivo.Text = "Seleciona Arquivo";
            this.btn_seleciona_arquivo.UseVisualStyleBackColor = true;
            this.btn_seleciona_arquivo.Click += new System.EventHandler(this.btn_seleciona_arquivo_Click);
            // 
            // txt_arquivo
            // 
            this.txt_arquivo.Enabled = false;
            this.txt_arquivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arquivo.Location = new System.Drawing.Point(12, 12);
            this.txt_arquivo.Name = "txt_arquivo";
            this.txt_arquivo.Size = new System.Drawing.Size(314, 27);
            this.txt_arquivo.TabIndex = 0;
            // 
            // ofd_arquivo
            // 
            this.ofd_arquivo.FileName = "selecionaArquivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Intervalo da Série Apurada";
            // 
            // txtSerieInicio
            // 
            this.txtSerieInicio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerieInicio.Location = new System.Drawing.Point(263, 70);
            this.txtSerieInicio.MaxLength = 4;
            this.txtSerieInicio.Name = "txtSerieInicio";
            this.txtSerieInicio.Size = new System.Drawing.Size(54, 32);
            this.txtSerieInicio.TabIndex = 3;
            this.txtSerieInicio.Text = "0000";
            // 
            // txtSerieFinal
            // 
            this.txtSerieFinal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerieFinal.Location = new System.Drawing.Point(345, 70);
            this.txtSerieFinal.MaxLength = 4;
            this.txtSerieFinal.Name = "txtSerieFinal";
            this.txtSerieFinal.Size = new System.Drawing.Size(49, 32);
            this.txtSerieFinal.TabIndex = 4;
            this.txtSerieFinal.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delimitador de Série";
            // 
            // txtDelimitador
            // 
            this.txtDelimitador.Location = new System.Drawing.Point(12, 49);
            this.txtDelimitador.Name = "txtDelimitador";
            this.txtDelimitador.Size = new System.Drawing.Size(22, 22);
            this.txtDelimitador.TabIndex = 7;
            this.txtDelimitador.Text = "#";
            this.txtDelimitador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(82, 113);
            this.txtSerie.MaxLength = 4;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(109, 30);
            this.txtSerie.TabIndex = 8;
            this.txtSerie.Text = "0000";
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
            this.txtSerie.Leave += new System.EventHandler(this.txtSerie_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Série";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.Location = new System.Drawing.Point(197, 112);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(172, 34);
            this.btn_Pesquisar.TabIndex = 10;
            this.btn_Pesquisar.Text = "Pesquisar Série";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // txt_seq_1
            // 
            this.txt_seq_1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seq_1.Location = new System.Drawing.Point(67, 168);
            this.txt_seq_1.Name = "txt_seq_1";
            this.txt_seq_1.Size = new System.Drawing.Size(332, 39);
            this.txt_seq_1.TabIndex = 11;
            this.txt_seq_1.Text = "@@-@@-@@-@@-@@";
            this.txt_seq_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_seq_2
            // 
            this.txt_seq_2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seq_2.Location = new System.Drawing.Point(67, 213);
            this.txt_seq_2.Name = "txt_seq_2";
            this.txt_seq_2.Size = new System.Drawing.Size(332, 39);
            this.txt_seq_2.TabIndex = 12;
            this.txt_seq_2.Text = "@@-@@-@@-@@-@@";
            this.txt_seq_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_seq_3
            // 
            this.txt_seq_3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seq_3.Location = new System.Drawing.Point(67, 258);
            this.txt_seq_3.Name = "txt_seq_3";
            this.txt_seq_3.Size = new System.Drawing.Size(332, 39);
            this.txt_seq_3.TabIndex = 13;
            this.txt_seq_3.Text = "@@-@@-@@-@@-@@";
            this.txt_seq_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_seq_4
            // 
            this.txt_seq_4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seq_4.Location = new System.Drawing.Point(67, 303);
            this.txt_seq_4.Name = "txt_seq_4";
            this.txt_seq_4.Size = new System.Drawing.Size(332, 39);
            this.txt_seq_4.TabIndex = 14;
            this.txt_seq_4.Text = "@@-@@-@@-@@-@@";
            this.txt_seq_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pesquisar
            // 
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.txt_seq_4);
            this.Controls.Add(this.txt_seq_3);
            this.Controls.Add(this.txt_seq_2);
            this.Controls.Add(this.txt_seq_1);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtDelimitador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerieFinal);
            this.Controls.Add(this.txtSerieInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_seleciona_arquivo);
            this.Controls.Add(this.txt_arquivo);
            this.Name = "Pesquisar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pesquisar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_seleciona_arquivo;
        private System.Windows.Forms.TextBox txt_arquivo;
        private System.Windows.Forms.OpenFileDialog ofd_arquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerieInicio;
        private System.Windows.Forms.TextBox txtSerieFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDelimitador;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_seq_1;
        private System.Windows.Forms.TextBox txt_seq_2;
        private System.Windows.Forms.TextBox txt_seq_3;
        private System.Windows.Forms.TextBox txt_seq_4;
    }
}

