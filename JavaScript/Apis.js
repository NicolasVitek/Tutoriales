"use strict";
//Local y session storage
//Ver desde pestaña aplication, local storage
//Al volver a abrir el navegador esta informacion
//sigue existiendo	
localStorage.setItem("nombre","nico");
//Corresponde a la sesion actual, desaparece
//Si se cierra
sessionStorage.setItem("nombre","nico");

const definirIdioma= ()=>{
	document.querySelector(".en").addEventListener("click",()=>{
		localStorage.setItem("idioma","en");
	})
	document.querySelector(".es").addEventListener("click",()=>{
		localStorage.setItem("idioma","es");
	})
}
const idioma=localStorage.getItem("idioma");
if (idioma===null) definirIdioma()
else console.log("El idioma es " + idioma);	

//Drag and drop

const circulo=document.querySelector(".circulo");
const cuadrado=document.querySelector(".cuadrado");
// circulo.addEventListener("dragstart",()=>console.log(1));
// circulo.addEventListener("drag",()=>console.log(2));
// circulo.addEventListener("dragend",()=>console.log(3));

cuadrado.addEventListener("dragenter",()=>console.log(1))
cuadrado.addEventListener("dragover",(e)=>{
	e.preventDefault();//Permie que el objeto se pueda hacer drop
	console.log(2)
})
cuadrado.addEventListener("drop",()=>console.log(3))
cuadrado.addEventListener("dragleave",()=>console.log(4))

//File reader

 const archivo=document.getElementById("archivo");
 archivo.addEventListener("change",(e)=>{
 	leerImagen(archivo.files)
 })
 const leerArchivos=ar=>{
 	const reader=new FileReader();
 	reader.readAsText(ar);
 	reader.addEventListener("load",(e)=>console.log(e.currentTarget.result));
 }
 const leerImagen=ar=>{
 	for (var i =0; i < ar.length; i++) {
 		const reader=new FileReader();
 		reader.readAsDataURL(ar[i]);
 		reader.addEventListener("load",(e)=>{
 		let imagen=`<img src='${e.currentTarget.result}'>`;
 		document.querySelector(".resultado").innerHTML+=imagen;		
 	})
 	}
 }
 const zona=document.querySelector(".zona-arrastre");

zona.addEventListener("dragover",e=>{
	e.preventDefault();
	changeStyle(e.srcElement,"#444");
})
zona.addEventListener("dragleave",e=>{
	e.preventDefault();
	changeStyle(e.srcElement,"#888");
})
zona.addEventListener("drop",e=>{
	e.preventDefault();
	changeStyle(e.srcElement,"#888");
	cargarImagen(e.dataTransfer.files[0])
})
const changeStyle=(obj,color)=>{
	obj.style.color=color;
	obj.style.border=`4px dashed ${color}`;
}
const cargarArchivo=ar=>{
	const reader=new FileReader();
	reader.readAsText(ar);
	reader.addEventListener("load",(e)=>{
		document.querySelector(".resul").textContent=e.currentTarget.result;
	})
}
const cargarImagen=ar=>{
	const reader=new FileReader();
	reader.readAsDataURL(ar);
	reader.addEventListener("load",(e)=>{
		let url=URL.createObjectURL(ar);
		let img=document.createElement("IMG");
		img.setAttribute("src",url)
		document.querySelector(".resul").appendChild(img)	})
}