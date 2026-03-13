// Crear una función que reciba la cantidad de estudiantes y la nota de cada uno y devuelva el promedio del grupo.



double PromedioGrupo(int cantidadEstudiantes, double sumaNotas)
{
    return sumaNotas / cantidadEstudiantes;
}

Console.Write("Ingrese la cantidad de estudiantes: ");
int cantidadEstudiantes = int.Parse(Console.ReadLine());

double sumaNotas = 0;
for (int i = 1; i <= cantidadEstudiantes; i++)
{
    Console.Write($"Ingrese la nota del estudiante {i}: ");
    sumaNotas += double.Parse(Console.ReadLine());
}

Console.WriteLine($"Promedio del grupo: {PromedioGrupo(cantidadEstudiantes, sumaNotas)}");