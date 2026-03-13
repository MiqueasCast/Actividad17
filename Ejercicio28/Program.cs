// Crear un procedimiento que solicite tres calificaciones y muestre el promedio del estudiante.

void PromedioEstudiante()
{
    Console.Write("Ingrese la calificación 1: ");
    double cal1 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese la calificación 2: ");
    double cal2 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese la calificación 3: ");
    double cal3 = double.Parse(Console.ReadLine());

    double promedio = (cal1 + cal2 + cal3) / 3;

    Console.WriteLine($"Promedio del estudiante: {promedio}");
}

PromedioEstudiante();