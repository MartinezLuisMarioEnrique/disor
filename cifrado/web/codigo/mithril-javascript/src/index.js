import m from "mithril";
var root = document.body

 var cesar= {
    view: function() {
        return m("main", [
			m("h1","METÓDOS DE CIFRADO"),					
			m("div", {class: "formulario"},m("label", "Mensaje:"),
			m("textarea",{id:"texto",placeholder:"ingrese mensaje"})
			),
			
			m("h2", "Cifrado Cesar"),
			m("div", {class: "formulario"},m("label", "Desplazamiento:"),
            m("input[type=number]", {id:"desplazamiento",oninput: m.withAttr("value", 0), value: 0}),
			m("label", "Mensaje cifrado:"),
            m("textarea", {name:"cifrado",id:"txtCifradoCesar"})
			),
			
			m("h2", "TI"),
			m("div", {class: "formulario"},
			m("label", "Mensaje cifrado:"),
            m("textarea",{id:"txtCifradoTI"})
			),
			
			m("h2", "TIA"),
			m("div", {class: "formulario"},m("label", "Cantidad de grupos:"),
            m("input[type=number]", {id:"grupos",oninput: m.withAttr("value", 0), value: 0}),
			m("label", "Mensaje cifrado:"),
            m("textarea", {name:"cifrado",id:"txtCifradoTIA"})
			)			
        ])
    }
}

m.mount(root, cesar)
