//Crear un procedimiento que solicite el nombre de una persona y muestre un saludo personalizado.

void Saludo()
{
    Console.Write("Ingrese su nombre: ");
    string nombre = Console.ReadLine();
    Console.WriteLine($"¡Hola, {nombre}! Bienvenido al programa.");
}
Saludo();