try:
    edad=int(input("Dame la edad: "))
    print("La edad es ", edad)
except ValueError as inst:
    #OBTENIENDO INFORMACION DE LA EXCEPCION
    print("Ingrese un valor numerico")
    print("Instancia de la excepcion ", type(inst))
    print("Argumentos de le excepcion ", inst.args)
else:
    print("Datos correctos")
 #LEVANTAR EXCEPCION
def factorial(n):
     factorial=1
     if(n<0):
         raise ValueError("No hay factoriales de numeros negativos")
     else:
         for i in range(1,int(n)+1):
            factorial=factorial*i
     return factorial
 #CREACION DE LA EXCEPCION
class FactorialError(ValueError):
    pass

def factorial2(n):
     factorial=1
     if(n<0):
         raise FactorialError
     else:
         for i in range(1,int(n)+1):
            factorial=factorial*i
     return factorial

print(factorial(-9))
print(factorial2(-9))