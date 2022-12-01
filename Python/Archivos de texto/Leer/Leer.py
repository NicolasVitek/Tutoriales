archivo=open("miArchivo.txt", 'rb+')
for linea in archivo:
    print(linea.rstrip())

cerrado=archivo.closed
print("El archivo esta cerrado?", cerrado)


lista=open("miArchivo.txt", 'r').readlines()
for linea in lista:
    print(linea)

print(archivo.tell())
print(archivo.read().decode('utf-8'))