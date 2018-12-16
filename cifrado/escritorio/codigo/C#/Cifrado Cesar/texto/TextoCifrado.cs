using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_Cesar.texto
{
    class TextoCifrado
    {
        private String textoCifrado;

        public TextoCifrado(String textoCifrado)
        {
            try
            {
                this.textoCifrado = textoCifrado;
            }
            catch (ArgumentNullException)
            {

            }
        }

        private int size()
        {
            return textoCifrado.Length;
        }

        public String toString()
        {
            return textoCifrado;
        }
    }
}
