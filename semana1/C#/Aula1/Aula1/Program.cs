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

			var a1 = new Aula1
			{
				Numero = 1997.01,
				BaseNumerica = 10
			};

			if (a1.PontoFixo())
			{
				Console.WriteLine(a1.Expression);

				a1.Compute();

				Console.WriteLine(a1.NumeroCalculado);
			}

			var a2 = new Aula2
			{
				Numero = 110011
			};

			a2.ConvertBinDec();

			Console.ReadKey();
		}
	}
}
