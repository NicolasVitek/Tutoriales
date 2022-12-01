class Alumno:
    def __init__(self, nombre, apellido):
        self.nombre=nombre
        self.apellido=apellido
    @property
    def nombreLista(self):
        return self.apellido+" "+self.nombre
    @nombreLista.setter
    def nombreLista(self, nombreCompleto):
        self.nombre, self.apellido=nombreCompleto.split(' ')
#EL DELETER SIRVE PARA ELIMINAR EL CONTENIDO DE UN ATRIBUTO. NO LLEVA PARAMETROS
    @nombreLista.deleter
    def nombreLista(self):
        print("Borrando")
        self.nombre=None
        self.apellido=None

alumno=Alumno("Nicolas", "Vitek")
print (alumno.nombreLista)
del (alumno.nombreLista)



