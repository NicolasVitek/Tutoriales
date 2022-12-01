#COMPREHENSION PROVEE UN MECANISMO PARA CREAR LISTAS DE FORMA RAPIDA.
#SE USA CUANDO CADA ELEMENTO DE UNA LISTA ES EL RESULTADO DE UNA OPE
#RACION. SE PUEDEN USAR CON EXPRESIONES LAMBDA

#FORMA ITERATIVA
s=[]
for x in range(10):
    s.append(x**2)
print(s)
print()
#FORMA CON COMPREHENSION
s2=[x**2 for x in range(10)]
print(s2)
print()
#SOLO PARA NUMEROS PARES
s3=[x**2 for x in range(10) if x%2==0]
print(s3)
print()
#LISTAS CON TUPLAS
s4=[(x,x*2)for x in range(10)]
print(s4)
print()
#CON UNA CONDICION
s5=[(x,y)for x in range(3) for y in range(4) if x!=y]
print(s5)