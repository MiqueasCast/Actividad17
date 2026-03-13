// Crear una función que reciba la base y la altura de un triángulo y devuelva su área.

double Area(double baseTriangulo, double alturaTriangulo)
{
    return (baseTriangulo * alturaTriangulo) / 2;
}


Console.Write("Calcular área de un triangulo\nIngrese base: ");
int baseTriangulo = int.Parse(Console.ReadLine());
Console.Write("Ingrese altura: ");
int alturaTriangulo = int.Parse(Console.ReadLine());

double areaTriangulo = Area(baseTriangulo, alturaTriangulo);

Console.WriteLine($"Área del triangulo: {areaTriangulo}");