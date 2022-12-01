/*Declaracion de variables*/
/*La variable constante no puede cambiar de valor. Ver error en consola web */
// const nombre="nicolas"
// nombre="vitek"

/*Undefined es un tipo de valor. La variable no esta definida
Null define a la variable como vacia. Nan es cuando se realizan
operaciones incorrectas, multiplicar texto con numeros*/
let variable;
alert(variable) 

/*Entrada por teclado*/
let nombre=prompt("Ingrese tu nombre");
/*Escribir en la pagina*/
document.write(nombre);
/*Concatenacion*/
numero1="56"
numero2=9
document.write(numero1.concat(numero2));
/*=== extrictamente igual, mismo valor, mismo dato*/
/*Estructura de condicionantes
if{}
else if{}
else{} */
/*Operador ternario*/
let edad=25;
(edad>18<)  ? (console.log("Es mayor de edad"))/*Si es true*/ 
			: (console.log("Es menor de edad"))/*Si es false*/
