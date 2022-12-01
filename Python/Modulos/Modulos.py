#SON ARCHIVOS CON CODIGO DE PYTHON. CUALQUIER ARCHIVO SE PUEDE USAR COMO MODULO.
#USAMOS import PARA TRABAJAR CON ELLOS QUE BUSCA LOS QUE ESTAN EN PYTHON. LUEGO
#SE BUSCAN LO QUE ESTAN EN LA VARIABLE sys.path

import math
import random

print(math.factorial(7))
print(math.pi)
print(math.cos(math.radians(45)))
print()

from math import cos

a=cos(60)
print(a)
print()

#PODEMOS USAR UN ALIAS PARA EL MODULO
import random as rnd

print(rnd.randint(5,25))

import Funciones
 