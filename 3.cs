using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite uma temperatura em Fahrenheit:");
		string fahrenheit = Console.ReadLine();
		
		double fahrenheitDouble = double.Parse(fahrenheit);
		
		double celsius = (fahrenheitDouble - 32) / 1.8;
		
		Console.WriteLine("Temperatura em Fahrenheit:" + celsius + "°C");
	}
}
