#SE USAN PARA FILTRAR CADENAS O TEXTOS. SEARCH SIRVE PARA SABER SI UNA CADENA
#OCURRE DENTRO DE OTRA
import re

r=re.search("si", "Me gusta la pizza si tiene mucho queso")
print(r)
m=re.search("si", "El auto no tiene nafta")
print(m)
#COMO LOS RESULTADOS NO SON UTILES LOS CONVERTIMOS A BOOLEANOS
rr=re.search("si", "Me gusta la pizza si tiene mucho queso")!=None
print(rr)
mm=re.search("si", "El auto no tiene nafta")!=None
print(mm)
#EXISTE UN PROBLEMA CONOCIDO COMO over matching QUE SUCEDE CUANDO TENEMOS
#PALABRAS QUE CUMPLEN CON LA CADENA A BUSCAR AUNQUE NO SEAN ESA PALABRA
a=re.search("si", "siempre me ha gustado la pizza")!=None
print(a)
#EXISTE TAMIBNE onder matching CUANDO QUEREMOS HACER UNS BUSQUEDA MUY PRECISA
b=re.search(" si ", "Me gusta la pizza,si tiene mucho quedo")!=None
print(b)
