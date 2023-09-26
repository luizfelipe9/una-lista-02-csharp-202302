using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o valor do capital:");
		string capital = Console.ReadLine();
		Console.WriteLine("Digite a taxa mensal (em decimais):");
		string taxa = Console.ReadLine();
        Console.WriteLine("Digite o número de meses:");
		string meses = Console.ReadLine();
		
		double capitalDouble = double.Parse(capital);
        double taxaDouble = double.Parse(taxa);
        double mesesDouble = double.Parse(meses);
        double taxaMeses = 1 + taxaDouble;
		
		double montante = capitalDouble * Math.Pow(taxaMeses, mesesDouble);
		
		
		Console.WriteLine("Montante: R$" + montante);
	}
}
