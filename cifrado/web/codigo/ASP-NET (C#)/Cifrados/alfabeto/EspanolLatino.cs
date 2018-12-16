using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_Cesar.alfabeto
{
    class EspanolLatino
    {
        private String alfabeto;
    public EspanolLatino(){
        alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZÁÉÍÓÚabcdefghijklmnñopqrstuvwxyzáéíóú1234567890";
    }
    public int tamanioAlfabeto(){
        return alfabeto.Length;        
    }
    
    public String toString(){
        return alfabeto;
    }

    }
}
