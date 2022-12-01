class especie{
	/*Los atributos se creean en el constructor*/
	constructor(especie, edad, color){
		this.especie=especie;
		this.edad=edad;
		this.color=color;
	}

	verInfo(){
		document.write("Soy un "+ this.especie + " tengo " + this.edad + " de color " + this.color);
	}
}
class perro extends especie{
	constructor(edad, color, raza){
		this.raza=null;
	}
	static ladrar(){/*El modificar static se aplica cuando un metodo se puede ejecutar sin haber instanciado el objeto*/
		document.write("Waw"); 
	}
	/*Propiedades*/
	set setRaza(nuevaRaza){
		this.raza=nuevaRaza;
	}
	get getRaza(){
		return this.raza;	
	}
}
/*Instanciacion*/
const perro=new especie("perro",23,"rojo");
perro.verInfo();
