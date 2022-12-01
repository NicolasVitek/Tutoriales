const button=document.querySelector(".Button");
const contenedor=document.querySelector(".contenedor");
const input=document.querySelector(".input-prueba");
/*Mouse*/
button.addEventListener("click", (eventoBoton)=>{
	alert("Clickeo el boton");
	/*Para evitar la propacion de enventos*/
	eventoBoton.stopPropagation();
});

contenedor.addEventListener("click",(e)=>{
	alert("Clickeo el contenedor");
});

/*Por defecto en el flujo de eventos se ejecutan los elementos mas especificos
como los hijos y los menos especificos*/
/*Teclado*/
input.addEventListener("keydown", (e)=>{
	console.log("Una tecla fue presionada");
})

input.addEventListener("keypress", (e)=>{
	console.log("Una tecla fue presionada y soltada");
})
input.addEventListener("keyup", (e)=>{
	console.log("Una tecla fue soltada");
})
/*Interfaz*/
window.addEventListener("load", (e)=>{
	console.log("La pagina se cargo")
})
input.addEventListener("select", (e)=>{
	console.log("Se ha seleccionado");
})
/*Temporizador*/
setTimeout((tiempo)=>{
	document.write("A los dos segundos aparece esto")
}, 2000);
const intervalo=setInterval((tiempo)=>{
	document.write("Cada tres segundos aparece esto")
}, 3000);
/*Detiene el temporizador a los diez segundos*/
setTimeout((stop)=>{
	clearInterval(intervalo);
}, 10000);