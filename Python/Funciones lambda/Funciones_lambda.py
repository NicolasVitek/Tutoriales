#SON FUNCIONES ANONIMAS, SIN NOMBRE. SOLO PUEDEN TENER UNA EXPRESION EN SU INTERIOR
#PUEDE RECIBIR CUALQUIER CANTIDAD DE ARGUMENTOS. SE USAN CUANDO EXISTE UNA FUNCION
#DE OTRA FUNCION

suma=lambda n:n+n
print(suma(5))
print(suma(10))
print()
producto=lambda a,b:a*b
print(producto(2,2))
print()
def expresion(a):
    return lambda x:x*x+a
#EL 2 ES EL VALOR DE a
funcion=expresion(2)
#EL 7 ES EL VALOR DE x
print(funcion(7))
print()
def multiplicador(n):
    return lambda x:x*n
duplicar=multiplicador(2)
triplicar=multiplicador(3)
print(duplicar(9))
print(triplicar(9))