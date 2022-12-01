def sumatoria(repetir, *valores):
    n=len(valores)
    suma=0
    if (n==0):
        print("No se recibieron valores")
    else:
        for v in valores:
            suma=suma+v
        for r in range(repetir):
            print(suma,end=' ')
    

sumatoria(3,1,2,3,4)
print()
sumatoria(2)
print()
sumatoria(3,5,6)
print()

def funcion1():
    print("Estoy en la funcion1")
def funcion2():
    print("Estoy en la funcion2")
def main():
    print("Estoy en main")
    funcion1()
    print("Regrese a main")
    funcion2()
    print("------")
main()