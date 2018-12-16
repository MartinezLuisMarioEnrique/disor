using Cifrado_Cesar.alfabeto;
using Cifrado_Cesar.texto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_Cesar.cifrado
{
    class CifradoCesar
    {
        String alfabeto = "";
        public CifradoCesar(EspanolLatino alfabeto)
        {
            this.alfabeto = alfabeto.toString();

        }

        public String cifrarCadena(int desplazamiento, String texto)
        {
            String cifrado = "";
            for (int i = 0; i < texto.Length; i++)
            {
                cifrado += cifrarLetra(desplazamiento, texto.ElementAt(i));
            }
            return cifrado;
        }

        public char cifrarLetra(int desplazamiento, char letra)
        {
            char cifrado = ' ';
                try
                {
                    if (desplazamiento > -1)
                    {
                        cifrado = intercambiarPosiciones(desplazamiento, letra);
                    }

                }
                catch (ArgumentNullException)
                {

                }
                catch (ArithmeticException)
                {
                }
                return cifrado;
            
        }

        private char intercambiarPosiciones(int desplazamiento, char letra)
        {
            char letraCifrada = letra;
            if (alfabeto.IndexOf(letra) != -1)
            {
                letraCifrada = alfabeto.ElementAt(((alfabeto.IndexOf(letra)) + desplazamiento) % alfabeto.Length);
            }
            return letraCifrada;
        }

        public char intercambiarPosicionesReversa(int desplazamiento, char letra)
        {
            char letraCifrada = letra;
            if (alfabeto.IndexOf(letra) != -1)
            {
                letraCifrada = alfabeto.ElementAt(((alfabeto.IndexOf(letra)) - desplazamiento) % alfabeto.Length);
            }
            return letraCifrada;
        } 
    }
}
