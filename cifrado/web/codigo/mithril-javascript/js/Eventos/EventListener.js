var _textoPlano = document.getElementById("texto");
var _desplazamiento = document.getElementById("desplazamiento");
var _grupos = document.getElementById("grupos");
	
_textoPlano.onkeyup = function () {
  cifrarCesar();
  cifrarTransposicionInversa();
  cifrarTransposicionInversaAgrupacion();
}

_desplazamiento.onchange = function () {
  cifrarCesar();
}

_grupos.onchange = function () {
  cifrarTransposicionInversaAgrupacion();
}

function cifrarCesar(){
	TextoPlano.agregarTexto(_textoPlano.value);
	CifradorCesar.cifrar(Alfabeto, TextoPlano, TextoCifrado, parseInt(_desplazamiento.value, 10));
	document.getElementById("txtCifradoCesar").value = TextoCifrado.obtenerTexto();
	TextoPlano.limpiar();
	TextoCifrado.limpiar();
}

function cifrarTransposicionInversa(){
	  TextoPlano.agregarTexto(_textoPlano.value);
  CifradorTranspInversa.cifrar(TextoPlano, TextoCifrado);
  document.getElementById("txtCifradoTI").value = TextoCifrado.obtenerTexto();
  TextoPlano.limpiar();
  TextoCifrado.limpiar();
}

function cifrarTransposicionInversaAgrupacion(){
	  TextoPlano.agregarTexto(_textoPlano.value);
  CifradorTranspInversaGrupos.cifrar(TextoPlano, TextoCifrado, parseInt(_grupos.value, 10));
  document.getElementById("txtCifradoTIA").value = TextoCifrado.obtenerTexto();
  TextoPlano.limpiar();
  TextoCifrado.limpiar();
}
