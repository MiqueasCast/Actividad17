// Crear un procedimiento que solicite el radio de un círculo y muestre el área del círculo.

void AreaCirculo()
{
    Console.Write("Ingrese el radio del círculo: ");
    double radio = double.Parse(Console.ReadLine());
    double area = Math.PI * Math.Pow(radio, 2);
    Console.WriteLine($"El área del círculo es: {area}");
}

AreaCirculo();