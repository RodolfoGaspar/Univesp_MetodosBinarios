using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MetodosNumericos
{
	public class Aula1 : Base
	{
		public int BaseNumerica { get; set; }

		internal bool PontoFixo()
		{
			Console.WriteLine($"Iniciando o cálculo de ponto fixo do número {Numero}\n");

			if (Numero == 0) return false;

			var splitValue = Numero.ToString().Split(",");

			int positiveLength = splitValue[0].Length;
			int negativeLength = 0;
			if (splitValue.Length > 1) negativeLength = splitValue[1].Length;

			string[] positivePart = new string[positiveLength];
			string[] negativePart = new string[negativeLength];

			for (var i = 0; i < positivePart.Length; i++)
			{ positivePart[i] = splitValue[0][i].ToString(); }

			for (var i = 0; i < negativePart.Length; i++)
			{ negativePart[i] = splitValue[1][i].ToString(); }

			Expression = "";

			Console.WriteLine("Montando a expressão...");

			#region Print
			for (var i = 0; i < positivePart.Length; i++)
			{ Expression += $"{GetExpoentPositiveValueForPrint(positivePart[i], positivePart.Length, i, BaseNumerica)}+"; }

			for (var i = 0; i < negativePart.Length; i++)
			{ Expression += $"{GetExpoentNegativeValueForPrint(negativePart[i], i, BaseNumerica)}+"; }

			Expression = Expression.Substring(0, Expression.Length - 1);

			Console.WriteLine($"Expressão: {Expression}");
			#endregion

			#region Calc Expression
			Expression = "";

			for (var i = 0; i < positivePart.Length; i++)
			{ Expression += $"{GetExpoentPositiveValueForCalc(positivePart[i], positivePart.Length, i, BaseNumerica)}+"; }

			for (var i = 0; i < negativePart.Length; i++)
			{ Expression += $"{GetExpoentNegativeValueForCalc(negativePart[i], i, BaseNumerica)}+"; }

			Expression = Expression.Substring(0, Expression.Length - 1);

			#endregion

			Console.WriteLine($"Calculando a expressão {Expression}");

			#region Calc
			for (var i = 0; i < positivePart.Length; i++)
			{ Result += GetExpoentPositiveValue(positivePart[i], positivePart.Length, i, BaseNumerica); }

			for (var i = 0; i < negativePart.Length; i++)
			{ Result += GetExpoentNegativeValue(negativePart[i], i, BaseNumerica); }

			//Console.WriteLine(Expression);
			#endregion

			Console.WriteLine("Ponto Fixo calculado.");

			return true;
		}

		private static string GetExpoentPositiveValueForPrint(string value, int length, int i, int _base)
		{ return $"{value}x{_base}^{length - i - 1}"; }

		private static string GetExpoentNegativeValueForPrint(string value, int i, int _base)
		{ return $"{value}x{_base}^{(i + 1) * -1}"; }

		private static string GetExpoentPositiveValueForCalc(string value, int length, int i, int _base)
		{ return $"{value}*{Math.Pow(_base, length - i - 1)}"; }

		private static string GetExpoentNegativeValueForCalc(string value, int i, int _base)
		{ return $"{value}*{Math.Pow(_base, (i + 1) * -1)}"; }

		private double GetExpoentPositiveValue(string value, int length, int i, int _base)
		{ return Convert.ToDouble(value) * Math.Pow(_base, length - i - 1); }

		private double GetExpoentNegativeValue(string value, int i, int _base)
		{ return Convert.ToDouble(value) * Math.Pow(_base, (i + 1) * -1); }
	}
}
