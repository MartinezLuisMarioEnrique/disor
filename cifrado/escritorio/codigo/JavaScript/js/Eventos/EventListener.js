function txtEntrada_KeyUp(){
  cifrarCesar();
  cifrarTransposicionInversa();
  cifrarTransposicionInversaAgrupacion();
}

function desplazamientoCesar_Input(){
  cifrarCesar();
}

function grupos_Input(){
  cifrarTransposicionInversaAgrupacion();
}

function cifrarCesar(){
  TextoPlano.agregarTexto(document.getElementById("txtEntrada").value);
  CifradorCesar.cifrar(Alfabeto, TextoPlano, TextoCifrado, parseInt(document.getElementById("desplazamientoCesar").value, 10));

  document.getElementById("txtCifradoCesar").value = TextoCifrado.obtenerTexto();

  TextoPlano.limpiar();
  TextoCifrado.limpiar();
}

function cifrarTransposicionInversa(){
  TextoPlano.agregarTexto(document.getElementById("txtEntrada").value);
  CifradorTranspInversa.cifrar(TextoPlano, TextoCifrado);

  document.getElementById("txtCifradoTI").value = TextoCifrado.obtenerTexto();

  TextoPlano.limpiar();
  TextoCifrado.limpiar();
}

function cifrarTransposicionInversaAgrupacion(){
  TextoPlano.agregarTexto(document.getElementById("txtEntrada").value);
  CifradorTranspInversaGrupos.cifrar(TextoPlano, TextoCifrado, parseInt(document.getElementById("grupos").value, 10))

  document.getElementById("txtCifradoTIA").value = TextoCifrado.obtenerTexto();

  TextoPlano.limpiar();
  TextoCifrado.limpiar();
}
