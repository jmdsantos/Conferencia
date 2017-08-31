using System;
using System.Collections.Generic;

namespace Conferencia.Controle
{
    /// <summary>
    /// Atributos que recebem o resultado da busca
    /// </summary>
    public class Result
    {
        public Result()
        {
            this.Msg = "";
        }

        private string _serie;
        private List<String> _numeros;
        private string msg;

        public string Serie { get => _serie; set => _serie = value; }
        public List<string> Numeros { get => _numeros;
            set => _numeros = value;
            
        }
        public string Msg { get => msg; set => msg = value; }
    }

    

}
