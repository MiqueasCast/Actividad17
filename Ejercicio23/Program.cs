//Crear un procedimiento que solicite dos números al usuario y muestre la suma de ambos.

void suma()
{
    Console.WriteLine("Ingrese primer número:");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Suma total {num1 + num2}");
}

suma();
