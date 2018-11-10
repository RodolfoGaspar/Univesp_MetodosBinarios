using System;
using System.Data;

/* 
 * criar funções
 * int convertBinDec(char numStr[])
 * void convertDecBin(int numDec, char numBin[])
 */



namespace MetodosNumericos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-=#=--=#=--=#=--=#=--=#=--=#=--=#=--=#=--=#=--=#=--=#=-");
			Console.WriteLine("Iniciando...");

			var a1 = new Aula1
			{
				Numero = 1997.01,
				BaseNumerica = 10
			};

			if (a1.PontoFixo())
			{
				Console.WriteLine($"Resultado: {a1.Result}\n");
			}

			var a2 = new Aula2
			{
				Numero = 110011
			};

			a2.ConvertBinDec();

			a2.Numero = a2.Result;

			a2.ConvertDecBin();

			Console.WriteLine("Pronto");
			Console.WriteLine("-=#=--=#=--=#=--=#=--=#=--=#=--=#=--=#=--=#=--=#=--=#=-");
			Console.ReadKey();
		}
	}
}
