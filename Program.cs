using ConsoleApp2;
using System.Globalization;

Funcionarios n1 = new Funcionarios();
Funcionarios n2 = new Funcionarios();

Console.WriteLine("Dados do primeiro funcionário:");
n1.Nome = Console.ReadLine();
n1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Dados do segundo funcionário:");
n2.Nome = Console.ReadLine();
n2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double m = (n1.Salario + n2.Salario) / 2;
Console.WriteLine("Salário Médio = " + m.ToString("F2", CultureInfo.InvariantCulture));