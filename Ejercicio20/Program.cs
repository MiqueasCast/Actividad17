// Crear una función que reciba la cantidad de días trabajados y el pago diario y devuelva el salario total del empleado.
int Salario(int diasTrabajados, int pagoDiario)
{
    return diasTrabajados * pagoDiario;
}

Console.Write("Ingrese cantidad de dias trabajados: ");
int dias = int.Parse(Console.ReadLine());

Console.Write("Ingrese pago por dia: Q");
int pago = int.Parse(Console.ReadLine());


double salarioTotal = Salario(dias, pago);
Console.WriteLine($"Salario total: Q{salarioTotal}");
