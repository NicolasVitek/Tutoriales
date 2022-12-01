#PARA INDICAR UNA CLASE PRIVADA SE PONE _ ANTES DEL NOMBRE, PERO ESTO NO IMPIDE QUE NO SE USE
class _Mensaje:
    def Saludo(self):
        print("Saludos desde mensaje")
#PARA COLOCAR UN ATRIBUTO O METODO PRIVADO SE PONE __ A DIFERENCIA DE LA CLASE, AMBOS NO SON 
#ACCESIBLES FUERA DEL PROYECTO
class Cuadrado:
    def __init__(self, lado):
        self.lado=lado
        self.__area=self.__calcularArea()
    def __calcularArea(self):
        print("Calculamos el area de", self.lado)
        return self.lado*self.lado
    def mostrar(self):
        print("El lado es", self.lado, ", el area es", self.__area)



