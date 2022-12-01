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
    def __init__(self, nombre, apellido, sueldo):
        self.nombre=nombre
        self.apellido=apellido
        self.sueldo=sueldo
    def ColocaSueldo(self, sueldo):
        self.sueldo=sueldo
    def CalculaImpuesto(self):
        print("Tu imuesto es:", self.sueldo*0.15)
    def Muestra(self):
        #PARA AHORRA EL CODIGO DEL METODO DE LA SUPER CLASE SE PONE:
        #super().Muestra()
        ##ASI NO HACE FALTA LA SIGUIENTE LINEA
        print("Nombre:", self.nombre, "Apellido:", self.apellido)
        print("Con sueldo: $",self.sueldo)

empleado=Empleado("Jose", "Lopez", 15000)
empleado.Muestra();
