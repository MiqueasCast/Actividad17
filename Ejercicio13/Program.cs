// Crear una función que reciba el precio de varios productos y devuelva el total de la compra.

double total = 0;

double PrecioTotal(double precioProducto)
{
    total += precioProducto;
    return total;
}

double precioProducto;

Console.Write("Ingrese el precio del producto (0 para salir): ");
precioProducto = double.Parse(Console.ReadLine());

while (precioProducto != 0)
{
    PrecioTotal(precioProducto);
    Console.Clear();
    Console.Write("Ingrese el precio del producto (0 para salir): ");
    precioProducto = double.Parse(Console.ReadLine());
}

Console.WriteLine($"Monto total: Q.{total}");