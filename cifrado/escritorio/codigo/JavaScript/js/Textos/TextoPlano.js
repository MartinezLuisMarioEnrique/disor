var TextoPlano = (function(){

    var longitud    = 0;
    var textoPlano  = "";

    var Longitud = function(){
        return longitud;
    }
    
    var CaracterEnIndice = function(indice){
        return textoPlano[indice];
    }
    
    var AgregarTexto = function(otroTexto){
        textoPlano += otroTexto;
        longitud = textoPlano.length;
    }
    
    var ObtenerTexto = function(){
        return textoPlano;
    }
    
    var Limpiar = function(){
        textoPlano  = "";
        longitud    = 0;
    }

    return{
        "longitud" : Longitud,
        "caracterEnIndice" : CaracterEnIndice,
        "agregarTexto" : AgregarTexto,
        "obtenerTexto" : ObtenerTexto,
        "limpiar" : Limpiar
    }
    
}());