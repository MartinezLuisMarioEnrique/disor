var CifradorTranspInversaGrupos = (function(){

    var Cifrar = function(objTextoPlano, objTextoCifrado, groupSize){
        var indice = 0;
        while (groupSize > 0 && indice + groupSize-1 < objTextoPlano.longitud())
        {
            for (var posicion = indice + groupSize-1; posicion >= indice; posicion--)
                objTextoCifrado.agregarTexto(objTextoPlano.caracterEnIndice(posicion));
            indice += groupSize;
        }

        while (indice < objTextoPlano.longitud()) {
            objTextoCifrado.agregarTexto(objTextoPlano.caracterEnIndice(indice));
            indice++;
        }
    }

    return{
        "cifrar" : Cifrar
    };

}());