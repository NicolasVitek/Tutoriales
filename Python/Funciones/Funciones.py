#TODAS LAS FUNCIONES EN PYTHON TIENEN POR DEFAULT EL TIPO DE RETORNO none
#CUANDO NO SE LES ESPECIFICA UN TIPO DE RETORNO

def suma():
    print("Estamos sumando")
    a=float(input("Ingrese un valor: "))
    b=float(input("Ingrese otro valor: "))
    r=a+b
    print("El resultado es ", r)

def resta(a,b):
    print("Estamos en resta")
    r=a-b
    print("El resultado es ", r)

def f1():
    print("fi")
#NONE EXPLICITO
def f2(a):
    if(a>5):
        return a*5
    else:
        None
#FORMA EXPLICITA
def f3(a):
    if(a>5):
        return a*5
    else:
        return
def f4(a):
    if(a>5):
        return a*5
print(type(f1()))  
print(type(f2(1)))  
print(type(f3(1)))  
print(type(f4(1)))  