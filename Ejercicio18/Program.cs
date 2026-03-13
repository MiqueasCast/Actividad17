// Crear una función que reciba la cantidad de productos comprados y el precio de cada uno y devuelva el total de la factura.

double TotalFactura(double totalActual, double precioProducto)
{
    return totalActual + precioProducto;
}

Console.Write("Ingrese la cantidad de productos: ");
int cantidadProductos = int.Parse(Console.ReadLine());

double total = 0;
for (int i = 1; i <= cantidadProductos; i++)
{
    Console.Write($"Ingrese el precio del producto {i}: ");
    total = TotalFactura(total, double.Parse(Console.ReadLine()));
}

Console.WriteLine($"Total de la factura: Q.{total}");