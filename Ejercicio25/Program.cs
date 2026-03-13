// Crear un procedimiento que solicite la base y la altura de un rectángulo y muestre su área.

void AreaRecatangulo()
{
    Console.WriteLine("Ingrese base: ");
    int basetr = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese altura: ");
    int altura = int.Parse(Console.ReadLine());

    double AreaTriangulo(int b, int h)
    {
        return (b * h) / 2.0;
    }

    double resultado = AreaTriangulo(basetr, altura);

    Console.WriteLine("Resultado: " + resultado);
}

AreaRecatangulo();