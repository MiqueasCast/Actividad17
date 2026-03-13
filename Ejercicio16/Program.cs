// Crear una función que reciba una cantidad de minutos y devuelva el equivalente en horas

int MinutosAHoras(int minutos)
{
    return minutos / 60;
}

Console.Write("Ingrese cantidad en minutos: ");
Console.WriteLine($"{MinutosAHoras(int.Parse(Console.ReadLine()))} horas");