#SELF ES UNA REFERENCIA A LOS OBJETOS BASADOS EN ESTA CLASE. SIEMPRE TIENE QUE SER EL PRIMER
#ARGUMENTO PERO NO NECESITA SER EL UNICO. PARA INSTANCIA objeto=Clase(). PARA INVOCAR objeto.metodo()
#EL CONSTRUCTOR SE EJECUTA EN CUANTO EL OBJETO ES INSTANCIADO

class Calculadora:
    #CONSTRUCTOR
    def __init__(self,x,y):
        print("Bienvenido a la calculadora")
        self.x=x
        self.y=y
        print("El constructor tiene datos:", self.x, self.y)
    def suma(self, a,b):
        print("-Estamos en suma-")
        return a+b
    def resta(self, a,b):
        print("-Estamos en resta-")
        return a-b
    def producto(self):
        print("-Estamos en multiplicacion-")
        return self.x*self.y

def main():
     calcu=Calculadora(5,9)
     print(calcu.suma(5,6))
     print(calcu.resta(10,6))
     print(calcu.producto())

main()