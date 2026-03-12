int Sumar(int a, int b)
{
    return a + b;
}

Console.Write("Ingrese primer número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese segundo número: ");
int numer2 = int.Parse(Console.ReadLine());



int resultado = Sumar(numero1,numer2);

Console.WriteLine("Resultado:" + resultado);