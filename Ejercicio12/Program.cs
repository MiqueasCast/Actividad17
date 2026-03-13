// Crear una función que reciba la edad de una persona y devuelva un mensaje mostrando la edad ingresada.

void Edad(int edadUsuario)
{
    Console.WriteLine("Edad Ingresada: " + edadUsuario);
}

Console.Write("Ingrese su edad: ");
int edadUsuario = int.Parse(Console.ReadLine());

Edad(edadUsuario);