using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosNumericos
{
	public class Aula2 : Base
	{
		internal bool ConvertBinDec()
		{
			Console.WriteLine($"Iniciando a conversão do número binário {Numero} para decimal\n");

			var a1 = new Aula1
			{
				Numero = Numero,
				BaseNumerica = 2
			};

			if (a1.PontoFixo())
			{
				Console.WriteLine($"Decimal: {a1.Result}\n");
			}

			Result = a1.Result;
			return true;
		}

		internal void ConvertDecBin()
		{
			Console.WriteLine($"Iniciando a conversão do número decimal {Numero} para binário\n");

			var value = Numero;
			string result = string.Empty;

			while (value != 1 && value != 0)
			{
				value = (int)value / 2;
				var mod = value % 2;

				result = $"{mod.ToString()}{result}";
			}

			result = $"{result}{value}";

			Console.WriteLine($"Binário: {result}");


		}
	}
}
