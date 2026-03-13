void ReporteEstudiante()
{
    Console.Write("Ingrese el nombre del estudiante: ");
    string nombre = Console.ReadLine();

    Console.Write("Ingrese el curso: ");
    string curso = Console.ReadLine();

    Console.Write("Ingrese la calificación 1: ");
    double cal1 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese la calificación 2: ");
    double cal2 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese la calificación 3: ");
    double cal3 = double.Parse(Console.ReadLine());

    double promedio = (cal1 + cal2 + cal3) / 3;

    Console.WriteLine("===== REPORTE DEL ESTUDIANTE =====");
    Console.WriteLine($"Nombre: {nombre}");
    Console.WriteLine($"Curso: {curso}");
    Console.WriteLine($"Calificación 1: {cal1}");
    Console.WriteLine($"Calificación 2: {cal2}");
    Console.WriteLine($"Calificación 3: {cal3}");
    Console.WriteLine($"Promedio: {promedio}");
    Console.WriteLine("==================================");
}

ReporteEstudiante();