// Crear una función que reciba tres números y devuelva el promedio de los tres

double Promedio(int a, int b)
{
    double promedio = a / b;
    return promedio;
}

int contador = 3;
int sumador = 0;
int indiceNumero = 1;

for (int i = 1; i <= contador; i++)
{
    Console.Write($"Ingrese número {indiceNumero}: ");
    int numero = int.Parse(Console.ReadLine());

    indiceNumero++;
    sumador += numero;
}

double resultado = Promedio(sumador, contador);

Console.WriteLine("Promedio: " + resultado);