// Crear un procedimiento que solicite el precio de un producto y muestre el precio con un descuento del 10%.

void Descuento()
{
    Console.Write("Ingrese el precio del producto: Q");
    double precio = double.Parse(Console.ReadLine());

    double descuento = precio * 0.10;

    Console.WriteLine($"Precio final: Q.{precio - descuento}");
}

Descuento();