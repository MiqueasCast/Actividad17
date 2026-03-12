Console.Write("Ingrese número: ");
int numero = int.Parse(Console.ReadLine());

int Doble(int a)
{
    return a * 2;
}

int resultado = Doble(numero);
Console.WriteLine($"Resultado: {resultado}");