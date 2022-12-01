#SE USA PARA CREAR ITERACIONES, ES UNA FUNCION QUE REGRESA UNA SERIE DE 
#ELEMENTOS ITERABLES, PERO UNO A LA VEZ. SON MAS LENTOS QUE LA COMPREN
#SION PERO SON MUY EFICIENTES EN TERMINOS DE MEMORIA
#EL FOR VA A ITERAR Y AHI ES DONDE SE EJECUTA EL GENERATOR. CUANDO EL 
#CODIGO LLEGA AL yield, LA EJECUCION REGRESA AL FOR CON UN NUEVO VALOR
#PARA SER USADO POR EL FOR.
def secuencia(maximo):
    conteo=0
    while conteo<maximo:
        conteo=conteo+1
        yield conteo

for n in secuencia(10):
    print(n)
print()

def multiplos(maximo, multiplos):
    conteo=0
    while conteo<maximo:
        conteo=conteo+1
        if (conteo%multiplos==0):
            yield conteo

for n in multiplos(100,7):
    print (n)