/*JSON son datos estructurados
El nombre de la variable va entre comillas para evitar un problema con el servidor*/
const objeto={
	"variable1":"dato1",
	"variable2":"dato2"
}
/*Forma serializada*/
const serial='{"variable1":"dato1", "variable2":"dato2"}'
const serializado=JSON.stringify(objeto);
document.write(typeof serializado);
const deserializado=JSON.parse(serial);
document.write(typeof deserializado);