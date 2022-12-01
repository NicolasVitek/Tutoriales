#CUANDO QUEREMOS HACER UNA BUSQUEDA EN LA CUAL DETERMINADA POSICION
#DE CARACTER PUEDA TENER VARIAS OPCIONES, HACEMOS CLASES DE CARCATER
#ES Y LOS INDICAMOS CON []

import re

r=re.search(r" pas[aeo] ", "Algo pasa en el estadio")!=None
print(r)
s=re.search(r" pas[aeo] ", "El jugador hizo un pase genial")!=None
print(s)
#SE PUEDE PONER UN RANGO EN LUGAR DE TODAS LAS LETRAS
a=re.search(r" 1[0-9] ", "El costo es de 15 pesos")!=None
print(a)
#SE PUEDE INDICAR CUALQUIER CANTIDAD DE CARACTERES CON *
b=re.search(r" *[0-9] ", "El costo es de 5 pesos")!=None
print(b)
#SE USA match PARA SABER SI UNA CADENA INCIA CON UNA EXPRESION
C=re.match(r"N[ie]c ", "De youtube Nicosiored es mi canal favorito")!=None
print(C)