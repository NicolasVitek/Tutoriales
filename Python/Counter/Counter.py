import collections
from collections import Counter

c1=Counter("transcendental")
print(c1)
#CON LISTA
c2=Counter(["a","b","c","d","a","d"])
print(c2)
#CON DICCIONARIO
c3=Counter({"a":1,"b":2})
print(c3)
#DE FORMA EXPLICITA
c4=Counter(manzana=2,pera=4)
print(c4)
#ACCEDIENDO A UN ELEMENTO
print(c4["manzana"])
#EL MAS COMUN DE LOS COMUNES
print(c2.most_common(2))
#OPERACIONES ARITMETICAS
a=["a","e","i","o","u"]
c2.subtract(a)
print(c2)
c2.update(a)
print(c2)
print(c2+c1)
print(c2-c1)
#INTERSECCION
print(c2&c1)
#UNION
print(c2|c1)