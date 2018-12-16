var CifradorCesar = (function(){
    
    var Cifrar = function(objAlfabeto, objTextoPlano, objTextoCifrado, desplazamiento){
        for (let index = 0; index < objTextoPlano.longitud(); index++) {
            if (objAlfabeto.existe(objTextoPlano.caracterEnIndice(index))) {
                objTextoCifrado.agregarTexto(ObtenerCaracterDesplazado(objAlfabeto, objTextoPlano.caracterEnIndice(index), desplazamiento));
            }else{
                objTextoCifrado.agregarTexto(objTextoPlano.caracterEnIndice(index));
            }
        }
    };

    var ObtenerCaracterDesplazado = function(objAlfabeto, caracterOriginal, desplazamiento){
        if (objAlfabeto.indiceDe(caracterOriginal) + desplazamiento >= 0)
            return objAlfabeto.caracterEn((objAlfabeto.indiceDe(caracterOriginal) + desplazamiento) % objAlfabeto.longitud());
        else if ((objAlfabeto.indiceDe(caracterOriginal) + desplazamiento) < 0 && (objAlfabeto.indiceDe(caracterOriginal) + desplazamiento) % objAlfabeto.longitud() === 0)
            return objAlfabeto.caracterEn(0);
        else
            return objAlfabeto.caracterEn(objAlfabeto.longitud() - Math.abs((objAlfabeto.indiceDe(caracterOriginal) + desplazamiento) % objAlfabeto.longitud()));
    };

    return{
        "cifrar" : Cifrar
    }
    
}());