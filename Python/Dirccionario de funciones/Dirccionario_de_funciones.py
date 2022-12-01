#AYUDA A OPTIMIZAR CUANDO TENEMOS QUE EJECUTAR UN CODIGO SENCILLO
#EN BASE A UNA CONDICION

def Calculadora(operacion,a,b):
    r=0
    if(operacion=="suma"):
        r=a+b
    elif(operacion=="resta"):
        r=a-b
    elif(operacion=="producto"):
        r=a*b
    elif(operacion=="division"):
        r=a/b
    return r
#REGRESA LA FUNCION LAMBDA QUE SE EJECUTA SEGUN LA LLAVE ENVIADA

def CalculadoraDict(operacion,a,b):
    return{
        "suma": lambda: a+b,
        "resta": lambda: a-b,
        "producto": lambda: a*b,
        "division": lambda: a/b
        }.get(operacion,lambda:None)()

print(CalculadoraDict("suma", 3,6))
