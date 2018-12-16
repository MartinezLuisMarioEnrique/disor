using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_Cesar.texto
{
    class TextoPlano
    {
        private String texto;

        public TextoPlano(String texto)
        {
            try
            {
                this.texto = texto;
            }
            catch (ArgumentNullException)
            {

            }
        }

        public int size()
        {
            return texto.Length;
        }

        public String toString()
        {
            return texto;
        }
    }
}
