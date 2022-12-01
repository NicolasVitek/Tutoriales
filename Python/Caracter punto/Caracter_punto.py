#EL METACARACTER ES UN CARACTER QUE DA UNA INDICACION ESPECIAL
#SOBRE UN FUNCIONAMIENTO EN PARTICULAR. EL PUNTO SIGNIFICA
#CUALQUIER CARACTER
import re
#PALABRAS QUE TERMINEN CON er
r=re.search(r'.er ', "Me gusta comer la pizza")!=None
print(r)
#PALABRAS DE TRES LECHAS QUE TERMINAN CON er
s=re.search(r' .er ', "me gusta comer la pizza")!=None
print (s)
ss=re.search(r' .er ', "me gusta ser programador")!=None
print(ss)
