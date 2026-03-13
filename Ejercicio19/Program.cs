// Crear una función que reciba el nombre de un estudiante y tres calificaciones y devuelva el promedio final


double Promedio(int nota1, int nota2, int nota3)
{
    return (nota1 + nota2 + nota3) / 3.0;
}


Console.WriteLine("Ingrese el nombre del estudiante:");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese primera nota: ");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segunda nota: ");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese tercera nota: ");
int nota3 = int.Parse(Console.ReadLine());

double restultado = Promedio(nota1, nota2, nota3);

Console.WriteLine($"El promedio final de {nombre} es: {restultado}");



