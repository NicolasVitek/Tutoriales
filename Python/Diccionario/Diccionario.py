#LOS DICCIONARIOS SON ESTRUCTURAS ASOCIATIVAS. SE INDEXAN POR LLAVE QUE TIENE QUE SER INMUTABLE

diccionario={"Ana":6500,"Luis":5832,"Aldo":9963}
print("Los alumnos y su Id son: ")
print(diccionario)
#Obtenemos el id de luis
print(diccionario["Luis"])
#Borrando un elemento
del diccionario["Luis"]
print(diccionario)
print("Elementos", diccionario.items())
print("LLaves", diccionario.keys())
#Agregacion
diccionario["Luis"]=6333
print(diccionario)
#Convirtiendo a list
llaves=list(diccionario)
print(llaves)
#Verficamos si NO existe alguna llave
existe="Pepe" not in diccionario
print(existe)
