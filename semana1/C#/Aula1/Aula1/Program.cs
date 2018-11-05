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

			var a1 = new Aula1();
			a1.Numero = 1997.01;
			a1.BaseNumerica = 10;

			if (a1.PontoFixo())
			{
				Console.WriteLine(a1.Expression);

				a1.Compute();

				Console.WriteLine(a1.NumeroCalculado);
			}


			//string expression = string.Empty;

			//PontoFixo(1997.01, 10, out expression);

			//var dt = new DataTable();

			//Console.WriteLine(dt.Compute(expression.Replace(",", "."), string.Empty));

			//PontoFixo(110011, 10, out expression);
			//Console.WriteLine(dt.Compute(expression.Replace(",", "."), string.Empty));
			//PontoFixo(110011, 2, out expression);
			//Console.WriteLine(dt.Compute(expression.Replace(",", "."), string.Empty));
			////ConvertBinDec();

			Console.ReadKey();
		}
	}
}
