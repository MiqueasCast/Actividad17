// Crear una función que reciba el salario por hora y las horas trabajadas y devuelva el salario total.

double Salario(double a, int b)
{
    return a * b;
}

Console.Write("Ingrese salario por hora: Q.");
double salarioHora = double.Parse(Console.ReadLine());

Console.Write("Ingrese horas trabajadas: ");
int horasTrabajadas = int.Parse(Console.ReadLine());


double salarioTotal = Salario(salarioHora, horasTrabajadas);
Console.WriteLine($"Salario total: Q{salarioTotal}");
