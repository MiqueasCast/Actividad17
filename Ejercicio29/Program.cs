// Crear un procedimiento que solicite el número de estudiantes de un curso y muestre un mensaje indicando cuántos estudiantes hay en la clase.
void EstudiantesCurso()
{
    Console.Write("Ingrese el número de estudiantes: ");
    int estudiantes = int.Parse(Console.ReadLine());

    Console.WriteLine($"En la clase hay {estudiantes} estudiantes.");
}

EstudiantesCurso();