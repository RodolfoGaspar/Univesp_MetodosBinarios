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

			PontoFixo(1997.01);

			Console.ReadKey();
		}

		private static void PontoFixo(double v)
		{

			Console.WriteLine(v);
			Console.WriteLine();

			var s = v.ToString().Split(",");

			string[] cp = new string[s[0].ToString().Length];
			string[] cm = new string[s[1].ToString().Length];
			string[] dp = new string[s[0].ToString().Length];
			string[] dm = new string[s[1].ToString().Length];

			for (var i = 0; i < cp.Length; i++)
			{
				cp[i] = $"{s[0].ToString().Substring(i, 1)}x10^{cp.Length - i - 1}";
				//Console.WriteLine($"{i}:{cp[i]}");
			}


			for (var i = 0; i < cm.Length; i++)
			{
				cp[i] = $"{s[1].ToString().Substring(i, 1)}x10^{(i + 1) * -1}";
				//Console.WriteLine($"{i}:{cp[i]}");
			}

			string p = "";

			for (var i = 0; i < cp.Length; i++)
			{ p += $"{s[0].ToString().Substring(i, 1)}x10^{cp.Length - i - 1}+"; }

			for (var i = 0; i < cm.Length; i++)
			{ p += $"{s[1].ToString().Substring(i, 1)}x10^{(i + 1) * -1}+"; }

			p = p.Substring(0, p.Length - 1);

			Console.WriteLine(p);

			Console.WriteLine();

			for (var i = 0; i < dp.Length; i++)
			{
				dp[i] = $"{s[0].ToString().Substring(i, 1)}x{Math.Pow(10, dp.Length - i - 1)}";
				//Console.WriteLine($"{i}:{dp[i]}");
			}

			for (var i = 0; i < dm.Length; i++)
			{
				dp[i] = $"{s[1].ToString().Substring(i, 1)}x{Math.Pow(10, (i + 1) * -1)}";
				//Console.WriteLine($"{i}:{dp[i]}");
			}

			p = "";

			for (var i = 0; i < dp.Length; i++)
			{ p += $"{s[0].ToString().Substring(i, 1)}x{Math.Pow(10, dp.Length - i - 1)}+"; }

			for (var i = 0; i < cm.Length; i++)
			{ p += $"{s[1].ToString().Substring(i, 1)}x{Math.Pow(10, (i + 1) * -1)}+"; }

			p = p.Substring(0, p.Length - 1);

			Console.WriteLine(p);

			Console.WriteLine();

		}
	}
}
