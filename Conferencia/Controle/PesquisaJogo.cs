using Conferencia.Controle;
using System;
using System.Collections.Generic;

namespace pesquisarJogo.Controle
{
    /// <summary>
    /// Classe que realiza a busca da serie solicitada no arquivo 
    /// texto.
    /// </summary>
    
    class PesquisaJogo
    {
        private Parametros _parametros;
        /// <summary>
        /// COntrutor da classe que recebe os parâmetros de busca.
        /// </summary>
        /// <param name="parametro"></param>
        public PesquisaJogo(Parametros parametro)
        {
            _parametros = parametro;
        }

        //Realiza a busca 
        public Result RealizarBusca()
        {
            int pos = 0;
            string serie = "";

            Result res = new Result();
            try
            {   
                //Carrega o array lines com as linhas do arquivo
                string[] lines = System.IO.File.ReadAllLines(_parametros.Arquivo);
                

                //Se o numero da série for menor que três não busca.
                if (_parametros.NoJogo.Length > 3)
                {
                    //Percorre o array
                    foreach (string line in lines)
                    {
                        //Encontra a posição do Delimitador de série
                        pos = line.IndexOf(_parametros.Delimitador);

                        //Pega o numero da Série
                        serie = line.Substring(0, pos);

                        //Verifica se existe um intervalo de séries a ser pesquisado
                        //ou busca no arquivo inteiro
                        if (
                            (int.Parse(_parametros.JogoInicio) == 0 && int.Parse(_parametros.JogoFim) == 0) ||
                            (int.Parse(serie) >= int.Parse(_parametros.JogoInicio) ) && (int.Parse(serie) <= int.Parse(_parametros.JogoFim) )
                            )
                        {
                            //Se encontrou a serie pega os numeros
                            if (serie == _parametros.NoJogo)
                            {
                                res.Serie = serie;
                                pos++;
                                //Carrega os numeros em um List para ser usado na janela.
                                List<String> valor = new List<string>();
                                for (int i = 0; i < 4; i++)
                                {
                                    //Pega as 10 posições que corresponde aos números
                                    valor.Add(line.Substring(pos, 10));
                                    pos = pos + 10;
                                }
                                res.Numeros = valor;
                                break;
                            }

                        }

                    }
                    //Notifica caso não encontre a série
                    if (res.Numeros == null)
                        res.Msg = "Série não encontrada!";

                }
                
                return res;
            }
            catch (Exception ex)
            {
                //Mostra erro de excessão. 
                string msg = ex.Message.ToString();
                res.Msg = msg;
                return res;
                
            }
        }
    }
}
