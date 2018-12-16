var Alfabeto = (function(){
    
    var alfabeto = ['A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z','Á','É','Í','Ó','Ú',
    'a','b','c','d','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z','á','é','í','ó','ú'];

    var Longitud = function(){
        return alfabeto.length;
    };

    var Existe = function(caracter){
        return alfabeto.indexOf(caracter) > -1;
    };

    var CaracterEn = function(indice){
        return alfabeto[indice];
    };

    var IndiceDe = function(caracter){
        return alfabeto.indexOf(caracter);
    };

    return{
        "longitud" : Longitud,
        "existe" : Existe,
        "caracterEn" : CaracterEn,
        "indiceDe" : IndiceDe
    }
    
}());