"strict mode"
function saludar(){
	let saludo="hola"
	document.write(saludo);
}
saludar();
/*Forma alternativa*/
const saludar2=function(){
	document.write("Hola");
}
/*El prefijo let indica que la variable no es global, solo existe en la funcion*/
/*Funciones flecha*/
const saludar3=()=>document.write("Hola");
/*Con parametro*/
const saludo=res=> nombre=res;
/*Clausulas, funciones dentro de otras*/
const cambiarTexto= tamaño =>{
	return()=>{
		document.querySelector(".texto").style.fontSize=`${tamaño}px`;
	}
}
px12=cambiarTexto(12);px14=cambiarTexto(14);px16=cambiarTexto(16);
document.querySelector(".t12").addEventListener("click", px12);
document.querySelector(".t14").addEventListener("click", px14);
document.querySelector(".t16").addEventListener("click", px16);
/*Parametro rest*/
const suma=(...rest)=>{
	let resultado=0;	
	for (let i = 0; i <rest.length; i++) {
		resultado+=rest[i];
	}
	console.log(resultado);
}
/*Suma puede tomar infinita cantidad de parametros*/
suma(1,3,4,9);