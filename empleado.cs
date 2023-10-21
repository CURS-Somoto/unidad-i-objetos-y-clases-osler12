using System;

public class Empleado
{
    public string Nombre { get; set; }
    public decimal Salario { get; set; }

    public decimal CalculaSalarioAnual()
    {
        return Salario * 12;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Empleado empleado = new Empleado();

        Console.Write("Introduce el nombre del empleado: ");
        empleado.Nombre = Console.ReadLine();

        Console.Write("Introduce el salario mensual del empleado: ");
        empleado.Salario = decimal.Parse(Console.ReadLine());

        decimal salarioAnual = empleado.CalculaSalarioAnual();

        Console.WriteLine("El salario anual de {0} es: {1}", empleado.Nombre, salarioAnual);
        Console.ReadLine();
    }
}
