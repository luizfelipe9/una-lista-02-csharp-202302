using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o valor do seu salário fixo:");
		string salarioFixo = Console.ReadLine();
		Console.WriteLine("Digite o total de vendas no mês:");
		string totalVendas = Console.ReadLine();
        Console.WriteLine("Digite o percentual ganho por cada venda (em decimais):");
		string percent = Console.ReadLine();
		
		double salarioFixoNum = double.Parse(salarioFixo);
        double totalVendasNum = double.Parse(totalVendas);
        double percentNum = double.Parse(percent);
			
		double salarioTotal = salarioFixoNum + totalVendasNum * percentNum;
		
		
		Console.WriteLine("O salário total é: R$" + salarioTotal);
	}
}
