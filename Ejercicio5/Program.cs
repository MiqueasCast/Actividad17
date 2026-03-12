Console.Write("Ingrese temperatura en grados Celsius: ");
int celsius = int.Parse(Console.ReadLine());

double ConvertirFahrenheit(int c)
{
    return (c * 9.0 / 5.0) + 32;
}

double resultado = ConvertirFahrenheit(celsius);

Console.WriteLine($"Resultado: {resultado}");