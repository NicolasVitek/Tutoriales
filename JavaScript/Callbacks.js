/*Es una funcion que invoca a otra funcion*/
function prueba(callback){
	callback("Algo");
}
function decirAlgo(algo){
	document.write("Algo")
}
prueba(decirAlgo);
/*Promesas*/
let nombre="Nicoas"
const promesa=new Promise((resolve,reject)=>{
	if (nombre!=="Nicolas") {reject("El nombre no es nicolas")}
	else{resolve(nombre )}	
})
/*Es un metodo que tienen las promesas apra acceder al valor de resolve o resolve*/
promesa.then((resultado)=>{
	document.write(resultado)
}).catch((error)=>{
	document.write(error)
})
/*Las promesas son asincronas, trabajan en tiempo real, esperan a recibir la informacion*/
const objeto={
	propiedad1:"valor1",
	propiedad2:"valor2",
	propiedad3:"valor3"
}
const obtenerInformacion=()=>{
	return new Promise((resolve, reject)=>{
		setTimeout(()=>{resolve(objeto	)},3000)
	})
}
obtenerInformacion().then(resultado=>console.log(resultado));