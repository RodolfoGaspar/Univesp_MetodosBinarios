using System;

/* 
 * criar funções
 * int convertBinDec(char numStr[])
 * void convertDecBin(int numDec, char numBin[])
 */



namespace Aula2
{
	class Program
	{
		static void Main(string[] args)
		{

			PontoFixo(1997.01, 10);

			PontoFixo(110011, 10);
			PontoFixo(110011, 2);
			//ConvertBinDec();

			Console.ReadKey();
		}

		private static bool PontoFixo(double value, int _base)
		{
			Console.WriteLine(value);
			Console.WriteLine();

			if (value == 0) return false;

			var splitValue = value.ToString().Split(",");

			int positiveLength = splitValue[0].Length;
			int negativeLength = 0;
			if (splitValue.Length > 1) negativeLength = splitValue[1].Length;

			string[] positivePart = new string[positiveLength];
			string[] negativePart = new string[negativeLength];

			string p = "";

			#region Print
			for (var i = 0; i < positivePart.Length; i++)
			{ p += $"{GetExpoentPositiveValueForPrint(splitValue, positivePart.Length, i, _base)}+"; }

			for (var i = 0; i < negativePart.Length; i++)
			{ p += $"{GetExpoentNegativeValueForPrint(splitValue, i, _base)}+"; }

			p = p.Substring(0, p.Length - 1);

			Console.WriteLine(p);
			#endregion

			Console.WriteLine();

			#region Calc
			p = "";

			for (var i = 0; i < positivePart.Length; i++)
			{ p += $"{GetExpoentPositiveValueForCalc(splitValue, positivePart.Length, i, _base)}+"; }

			for (var i = 0; i < negativePart.Length; i++)
			{ p += $"{GetExpoentNegativeValueForCalc(splitValue, i, _base)}+"; }

			p = p.Substring(0, p.Length - 1);

			Console.WriteLine(p);
			#endregion

			Console.WriteLine();

			return true;
		}

		private static string GetExpoentPositiveValueForPrint(string[] splitValue, int length, int i, int _base)
		{ return $"{splitValue[0].ToString().Substring(i, 1)}x{_base}^{length - i - 1}"; }

		private static string GetExpoentNegativeValueForPrint(string[] splitValue, int i, int _base)
		{ return $"{splitValue[0].ToString().Substring(i, 1)}x{_base}^{(i + 1) * -1}"; }

		private static string GetExpoentPositiveValueForCalc(string[] splitValue, int length, int i, int _base)
		{ return $"{splitValue[0].ToString().Substring(i, 1)}*{Math.Pow(_base, length - i - 1)}"; }

		private static string GetExpoentNegativeValueForCalc(string[] splitValue, int i, int _base)
		{ return $"{splitValue[0].ToString().Substring(i, 1)}*{Math.Pow(_base, (i + 1) * -1)}"; }
	}
}
