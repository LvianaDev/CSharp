using System;
using System.Globalization;

namespace CSharp.Fundamentos
{
	class FormatandoNumero
	{
		public static void Executar()
		{
			double valor = 15.175;
			Console.WriteLine(valor.ToString("F1"));	//Uma única casa decimal
			Console.WriteLine(valor.ToString("C"));		//Current - Moeda
			Console.WriteLine(valor.ToString("P"));		//Percentual
			Console.WriteLine(valor.ToString("#.##"));

			CultureInfo cultura = new CultureInfo("en-USA");
			Console.WriteLine(valor.ToString("C3", cultura));

			int inteiro = 256;
			Console.WriteLine(inteiro.ToString("D10"));
		}

	}
}
