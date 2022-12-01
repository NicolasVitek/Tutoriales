document.getElementById('parrafo');/*Selecciona el elemento con ese id*/
document.getElementsByTagName('p');/*Muestra la coleccion de elementos parrafos del documento*/
document.querySelector(".parrafo");/*Por selector*/

const despedida=document.querySelector(".despedida");
const rangoEtario=document.querySelector(".rangoEtario");
rangoEtario.setAttribute("type","text");/*Cambia el tipo de entrada de dato*/
document.write("<br>" + rangoEtario.getAttribute("type") + "<br>");
rangoEtario.required=" "
rangoEtario.minLength=4;
rangoEtario.minValue=0;
document.write(rangoEtario.value);
despedida.style.color="red";
/*Clases*/
despedida.classList.add("grande"); /*Agrega una modificacion del .css*/
let cadena= despedida.textContent+ "   "+ despedida.innerHTML+ "   "+ despedida.outerHTML;
alert(cadena)
/*Creacion de elementos*/
const contenedor=document.querySelector(".contenedor");
const item=document.createElement("LI");
  const textoItem=document.createTextNode("Texto de LI");
 item.appendChild(textoItem);
 contenedor.appendChild(item);
console.log(item);