"use strict";
/*Declarar las variables correctamente*/
let nombre="nicolas"
const obj={};
Object.defineProperty(obj,"nombre",{value:"nicolas",writeable:false})
/*Sin modo estricto esta operacion esta permitida*/
obj.nombre="Nico"
console.log(obj.nombre);
/*Sin modo estricto, se permiten parametros identicos y se toma el ultimo */
function hablar(texto,texto){
	console.log(texto);
}
/*En modo estricto no se puede usar delete para eliminar objetos o metodos
solo propiedades*/
/*En modo estricto no se puede usar .this en funciones*/