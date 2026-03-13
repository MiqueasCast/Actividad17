// Crear un procedimiento que solicite la edad de una persona y muestre el año aproximado de nacimiento

void AnioNacimiento()
{
    Console.Write("Ingrese su edad: ");
    int edad = int.Parse(Console.ReadLine());
    int anioNacimiento = 2026 - edad;
    Console.WriteLine($"Usted nació aproximadamente en {anioNacimiento}");
}

AnioNacimiento();