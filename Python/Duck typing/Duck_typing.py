#ESTO LE DA AL PROGRAMADOR LA POSIBILIDAD DE NO PREOCUPARSE DEL TIPO DE CLASE
#SIEMPRE Y CUANDO IMPLEMENTE LA OPERACION NECESARIA

class Perro:
    def moverse(self):
        print("Caminando")

class Tiburon:
    def moverse(self):
        print("Nadando")

class Serpiente:
    def moverse(self):
        print("Reptando")

class Automovil:
    def avanzar(self):
        print("Andando")
#CREAMOS UNA CLASE QUE TRABAJARA CON CUALQUIERA QUE IMPLEMENTE A MOVERSE
class Animal:
    def __init__(self, animal):
        self.animal=animal
        self.animal.moverse()
    def accion(self):
        self.animal.moverse()

Animal(Perro())
Animal(Tiburon())
Animal(Serpiente())

mascota=Animal(Perro())
mascota.accion()