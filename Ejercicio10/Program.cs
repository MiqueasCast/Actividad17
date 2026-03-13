//Crear una función que reciba un número y devuelva el cubo del número.

int Cubo(int a)
{
    return a * a * a;
}

Console.Write("Ingrese número: ");
int numero = int.Parse(Console.ReadLine());

int resultado = Cubo(numero);

Console.WriteLine($"{numero} al cubo es: {resultado} ");