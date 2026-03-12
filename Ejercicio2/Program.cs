
int Cuadrado(int a)
{
    return a * a;
}


Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

int resultado = Cuadrado(numero);

Console.WriteLine($"Resultado: {resultado}");