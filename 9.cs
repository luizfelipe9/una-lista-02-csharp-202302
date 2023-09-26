using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite um número inteiro de segundos:");
		int segundosTotal = int.Parse(Console.ReadLine());

        int horas = segundosTotal / 3600;
        int minutos = (segundosTotal % 3600) / 60;
        int segundos = segundosTotal % 60;
		
		Console.WriteLine($"Esses segundos dão um total de {horas} hora(s), {minutos} minuto(s) e {segundos} segundo(s).");
	}
}
