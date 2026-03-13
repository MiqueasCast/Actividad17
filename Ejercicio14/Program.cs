// Crear una función que reciba la distancia recorrida y el tiempo empleado y devuelva la velocidad promedio.

double VelocidadPromedio(double distancia, double tiempo)
{
    return distancia / tiempo;
}


Console.Write("Ingrese distancia recorrida: ");
int distanciaRecorrida = int.Parse(Console.ReadLine());
Console.Write("Ingrese el teimpo empleado: ");
int tiempoEmpleado = int.Parse(Console.ReadLine());

double velocidadPromedio = VelocidadPromedio(distanciaRecorrida, tiempoEmpleado);
Console.WriteLine("Velocidad promedio: "+ velocidadPromedio+"km/h");


