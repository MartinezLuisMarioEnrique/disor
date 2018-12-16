var TextoCifrado = (function(){

    var longitud    = 0;
    var textoCifrado  = "";

    var Longitud = function(){
        return longitud;
    }
    
    var CaracterEnIndice = function(indice){
        return textoCifrado[indice];
    }
    
    var AgregarTexto = function(otroTexto){
        textoCifrado += otroTexto;
        longitud = textoCifrado.length;
    }
    
    var ObtenerTexto = function(){
        return textoCifrado;
    }
    
    var Limpiar = function(){
        textoCifrado  = "";
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