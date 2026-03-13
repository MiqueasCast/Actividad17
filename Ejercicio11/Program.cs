// Crear una función que reciba el peso en kilogramos y devuelva el peso en libras.

double ConversorKl(double a)
{
    return a * 2.20462;
}

Console.Write("Ingrese peso en kilogramos: ");
double pesoKl = double.Parse(Console.ReadLine());

double pesoLb = ConversorKl(pesoKl);
Console.WriteLine($"{pesoKl} Kilogramos = {pesoLb} libras");