#include "cmath"
#include "TextoPlano.h"
#include "TextoCifrado.h"
#include "Alfabeto.h"
#include "CifradoCesar.h"


CifradoCesar::CifradoCesar(void)
{
}


CifradoCesar::~CifradoCesar(void)
{
}

void CifradoCesar::cifrar(Alfabeto &objAlfabeto, TextoPlano &objTextoPlano, TextoCifrado &objTextoCifrado, int desplazamiento){
for (int index = 0; index < objTextoPlano.size(); index++){
	if (objAlfabeto.existe(objTextoPlano.caracterEnIndice(index)))
		objTextoCifrado.agregarCaracter(obtenerCaracterDesplazado(objAlfabeto, objTextoPlano.caracterEnIndice(index), desplazamiento));
	else
		objTextoCifrado.agregarCaracter(objTextoPlano.caracterEnIndice(index));
	}
}

char CifradoCesar::obtenerCaracterDesplazado(Alfabeto &alfabeto, char caracterOriginal, int desplazamiento){
	//Si la posicion es positiva
	//vector[indice % longitudDelVector]
	if (alfabeto.indiceDe(caracterOriginal) + desplazamiento >= 0)
		return alfabeto.elementoEn((alfabeto.indiceDe(caracterOriginal) + desplazamiento) % alfabeto.size());
		//Si la posicion negativa MOD longitudDelVector es igual a 0
		//vector[0]
	else if ((alfabeto.indiceDe(caracterOriginal) + desplazamiento) < 0 && (alfabeto.indiceDe(caracterOriginal) + desplazamiento) % alfabeto.size() == 0)
		return alfabeto.elementoEn(0);
        //Si la posicion negativa MOD longitudDelVector es diferente de 0
        //vector[longitudDelVector - ((indice % longitudDelVector) * -1)]
    else
		return alfabeto.elementoEn(alfabeto.size() - abs((alfabeto.indiceDe(caracterOriginal) + desplazamiento) % alfabeto.size()));
}
