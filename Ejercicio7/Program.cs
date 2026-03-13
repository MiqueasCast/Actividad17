// Crear una función que reciba el precio de un producto y el porcentaje de descuento y devuelva el precio final.

Console.Write("Ingrese precio del producto: ");
int precio = int.Parse(Console.ReadLine());

Console.Write("Ingrese porcentaje del descuento: ");
double descuento = int.Parse(Console.ReadLine());

int PrecioFinal(int a, double b)
{
    double calculo = descuento / 100;
    double resultado = a - (a * calculo);
    return (int)resultado;
}

double resultado = PrecioFinal(precio, descuento);

Console.WriteLine("Precio final: " + resultado);