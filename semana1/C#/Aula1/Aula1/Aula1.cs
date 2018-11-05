using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MetodosNumericos
{
	public class Aula1 
	{
		public double Numero { get; internal set; }
		public object NumeroCalculado { get; internal set; }
		public string Expression { get; internal set; }
		public int BaseNumerica { get; set; }

		internal bool PontoFixo()
		{
			Console.WriteLine(Numero);
			Console.WriteLine();

			if (Numero == 0) return false;

			var splitValue = Numero.ToString().Split(",");

			int positiveLength = splitValue[0].Length;
			int negativeLength = 0;
			if (splitValue.Length > 1) negativeLength = splitValue[1].Length;

			string[] positivePart = new string[positiveLength];
			string[] negativePart = new string[negativeLength];

			Expression = "";

			#region Print
			for (var i = 0; i < positivePart.Length; i++)
			{ Expression += $"{GetExpoentPositiveValueForPrint(splitValue, positivePart.Length, i, BaseNumerica)}+"; }

			for (var i = 0; i < negativePart.Length; i++)
			{ Expression += $"{GetExpoentNegativeValueForPrint(splitValue, i, BaseNumerica)}+"; }

			Expression = Expression.Substring(0, Expression.Length - 1);

			Console.WriteLine(Expression);
			#endregion

			Console.WriteLine();

			#region Calc
			Expression = "";

			for (var i = 0; i < positivePart.Length; i++)
			{ Expression += $"{GetExpoentPositiveValueForCalc(splitValue, positivePart.Length, i, BaseNumerica)}+"; }

			for (var i = 0; i < negativePart.Length; i++)
			{ Expression += $"{GetExpoentNegativeValueForCalc(splitValue, i, BaseNumerica)}+"; }

			Expression = Expression.Substring(0, Expression.Length - 1);

			Console.WriteLine(Expression);
			#endregion

			Console.WriteLine();

			return true;
		}

		internal void Compute()
		{
			var dt = new DataTable();
			NumeroCalculado = dt.Compute(Expression, string.Empty);
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
