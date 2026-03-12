Console.Write("Ingrese radio del círculo:");
int radio = int.Parse(Console.ReadLine());

double AreaCirculo(int r)
{
    return Math.PI * r * r;
}

double resultado = AreaCirculo(radio);

Console.WriteLine($"Área: {resultado}");