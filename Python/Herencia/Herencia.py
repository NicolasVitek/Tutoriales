class Persona:
    def __init__(self, nombre, apellido):
        self.nombre=nombre
        self.apellido=apellido
    def Muestra(self):
        print("Nombre:", self.nombre, "Apellido:", self.apellido)
    def Saluda(self, nombre):
        print(nombre, "te saluda", self.nombre)

class Alumno(Persona):
    pass#BLOQUE VACIO

class Empleado(Persona):
    def ColocaSueldo(self, sueldo):
        self.sueldo=sueldo
    def CalculaImpuesto(self):
        print("Tu imuesto es:", self.sueldo*0.15)

persona1=Persona("Juan", "Perez")
Alumno1=Alumno("PEPE", "Argento")
persona1.Muestra()
Alumno1.Saluda(persona1.nombre)
empleado1=Empleado("Jose", "Martinez")
empleado1.Muestra()
empleado1.ColocaSueldo(15000)
empleado1.CalculaImpuesto()