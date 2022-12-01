class Estudiante:
    def __init__(self, nombre, carrera):
        self.nombre=nombre
        self.carrera=carrera
        self.libro=self.Libro("Programacion avanzanda.", "Nicolas")
    def Muestra(self):
        print("Me llamo", self.nombre, "y estudio", self.carrera)
        self.libro.Bibliografia()
        print()
    #CLASE INTERNA
    class Libro:
        def __init__(self, titulo,autor):
            self.titulo=titulo
            self.autor=autor
        def Bibliografia(self):
            print("Titulo:", self.titulo, "Autor:", self.autor)

estudiante=Estudiante("Aldo", "Ciencias")
estudiante.Muestra()
#ACCEDIENDO AL ATRIBUTO DE LA INSTANCIA DE LA CLASE INTERNA
print("Estoy leyendo", estudiante.libro.titulo)
estudiante.libro.Bibliografia()
otrolibro=estudiante.Libro("Unity", "Alberto")
otrolibro.Bibliografia()

