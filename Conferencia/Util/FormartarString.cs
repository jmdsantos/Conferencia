using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conferencia.Util
{
    public class FormartarString
    {
        public String SeparandoComTraco(string valor)
        {
            string valorFormatado="";
            int pos = 0;
            string num = "", separador="";
            for (int i = 0; i < 5; i++)
            {
                num = valor.Substring(pos, 2);
                pos = pos + 2;
                if (i > 0)
                    separador = "-";
                valorFormatado = valorFormatado + separador + num;
            }
            return valorFormatado;
        }
       
                
    }
}
