/*Arrays*/
frutas=["manzana", "mandarina", "pera"];
document.write(frutas + "<br>");
document.write(frutas.reverse() + "<br>");
document.write(frutas.join(" - ") + "<br>");
/*Foreach recibe una funcion por parametro para trabajar con cada elemento*/
frutas.forEach(function(fruta){document.write(fruta+"<br>")})
document.write("<h3>Array asociativo</h3>")
/*Array asociativo:*/
let pc={
	nombre:"nicolas",
	procesador:"iteli3",
	ram:"8gb",
	espacio:"1tb"
};
document.write(pc["nombre"]);
document.write("<br><h3>Ciclo for of</h3>");
/*For of, equivalente a foreach*/
for(fruta of frutas){
	document.write(fruta + "<br>");
}
document.write("<h2>Ciclo for in</h2>");
/*For in trabaja con los indices*/
for(fruta in frutas){
	document.write(fruta + "<br>");
}

