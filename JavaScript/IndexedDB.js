//Es una base de datos indexada que almacena datos en el storage
//Abre o crea la base de datos sino existe
const IDBRequest=indexedDB.open("base",1);

IDBRequest.addEventListener("upgradeneeded",()=>{
	const db=IDBRequest.result;
	db.createObjectStore("nombres",{
		autoIncrement: true//Para la PK 
	});
})
const addObjetos=objeto=>{
	const db=IDBRequest.result;
	const IDBtransaction=db.transaction("nombres","readwrite");
	const objectStore=IDBtransaction.objectStore("nombres");
	objectStore.add(objeto);
}
const leerObjetos=()=>{
	const db=IDBRequest.result;
	const IDBtransaction=db.transaction("nombres","readonly");
	const objectStore=IDBtransaction.objectStore("nombres");
	const cursor=objectStore.openCursor();
	cursor.addEventListener("success",()=>{
		if (cursor.result) {
			console.log(cursor.result.value);
			cursor.result.continue();
		//El cursor viaja por todos los datos mas una posicion nula
		}else console.log("Todos los datos fueron leidos")
	})	
}
const modObjetos=(key,objeto)=>{
	const db=IDBRequest.result;
	const IDBtransaction=db.transaction("nombres","readwrite");
	const objectStore=IDBtransaction.objectStore("nombres");
	objectStore.put(objeto,key);
}
const modObjetos=(key)=>{
	const db=IDBRequest.result;
	const IDBtransaction=db.transaction("nombres","readwrite");
	const objectStore=IDBtransaction.objectStore("nombres");
	objectStore.delete(key);
}
	