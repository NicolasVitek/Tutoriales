cadena="Adios a todos"
n=0
archivo=open("miArchivo.txt", 'w')
while n<5:
    texto=input("Dame un texto: ")
    archivo.write(texto+'\n')
    n=n+1
archivo.close()