using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosNumericos
{
	public class Aula2 : Base
	{
		internal bool ConvertBinDec()
		{
			var a1 = new Aula1
			{
				Numero = Numero,
				BaseNumerica = 2
			};

			if (a1.PontoFixo())
			{
				Console.WriteLine(a1.Expression);
				a1.Compute();
				Console.WriteLine(a1.NumeroCalculado);
			}

			return true;
		}
	}
}
