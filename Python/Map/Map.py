#NOS PERMITE TENER UNA LISTA DE VALORES, PASARLA POR UNA FUNCION Y
#OBTENER UNA NUEVA LISTA DE VALORES.

#FORMA TRADICIONAL
lista=[1,2,3,4,5,6,7,8,9,10]
def cuadrado(x):
    return x**2
lista2=[]
for n in lista:
    lista2.append(cuadrado(n))
print (lista2)
#FORMA MAS EFICIENTE CON MAP
lista3=list(map(cuadrado,lista))
print(lista3)
print()
def pares(x):
    if(x%2==0):
        return True
    else:
        return False
pares=list(map(pares,lista))
print(pares)
#FILTER TOMA DOS PARAMETROS, LA FUNCION Y LA LISTA. SI LA FUNCION
#REGRESA TRUE, EL ELEMENTO ES PASADO A LA NUEVA LISTA
pares2=list(filter(pares,lista))


