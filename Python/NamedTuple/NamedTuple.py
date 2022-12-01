#NOS PERMITE TRABAJAR CON TUPLAS, CUYOS ELEMENTOS TENDRAN UN NOMBRE EN PARITUCLAR
import collections
from collections import namedtuple

producto=namedtuple("Producto", "Nombre precio cantidad")
produ1=producto("manzana", 17.50,20)
print(produ1)
#IMPRIMIMOS EL ELEMENTO 0
print(produ1[0])
#IMPRIMIMOS LOS NOMBRES DE LOS CAMPOS
print(produ1._fields)
#LA TUPLA COMO UN DICCIONARIO
print(produ1._asdict())
#REEMPLAZAR CONTENIDO
produ1=produ1._replace(precio=50)
print(produ1)
#OTRA FORMA DE CREACION
produ2=producto._make(["Pera",11.50,50])
print(produ2)