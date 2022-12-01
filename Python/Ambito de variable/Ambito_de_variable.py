valor=2
def funcion(n):
    dato=3
    ##PARA TRABAJAR CON LA VARIABLE GLOBAL VALOR
    global valor
    valor=valor*2
    print(valor)
    print("Adentro de la funcion", dato)

funcion(valor)
print(valor)
