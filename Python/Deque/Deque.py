from collections import deque

cola=deque("Hola a todos")
print(cola)
cola.append("z")
cola.append(20)
cola.append("nicolas")
print(cola)
#TAMBIEN SE PUEDE AGREGAR CON EXTEND
cola.extend([1,2,3])
print(cola)
#EXTRAEMOS EL ELEMENTO MAS A LA IZQUIERDA
cola.popleft()
print(cola)
#ROTACION A LA IZQUIERDA -n O A LA DERECHA n
cola.rotate(-3)
print(cola)
#LADO CONTRARIO
cola.reverse()
print(cola)
