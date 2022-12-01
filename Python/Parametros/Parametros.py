def calcularPrecio(costo=1,impuesto=0.16,descuento=0.2):
    precio=(costo*(1-descuento))*(1+impuesto)
    return precio

print(calcularPrecio(500,0.1,0.5))
#SOLO EL COSTO, SE USAN LOS VALORES DE DEFAULT PARA IMPUESTO, DESCUENTO
print(calcularPrecio(100))
#SOLO PASAMOS IMPUESTO Y DESCUENTO
print(calcularPrecio(250,0.25))
#TODOS LOS VALORES EN DEFAULT
print(calcularPrecio())
#INDICAMOS EL PARAMETRO POR MEDIO DEL NOMBRE
print(calcularPrecio(impuesto=0.3))
#SE PUEDEN INDICAR EN CUALQUIER ORDEN
print(calcularPrecio(impuesto=0.3,costo=10))