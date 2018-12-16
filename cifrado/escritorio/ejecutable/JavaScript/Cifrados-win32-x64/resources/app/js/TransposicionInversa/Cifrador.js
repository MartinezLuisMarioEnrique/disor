var CifradorTranspInversa = (function(){

    var Cifrar = function(objTextoPlano, objTextoCifrado){
        for (var indice = objTextoPlano.longitud()-1; indice >= 0; indice--)
            objTextoCifrado.agregarTexto(objTextoPlano.caracterEnIndice(indice));
    };

    return{
        "cifrar" : Cifrar
    };

}());