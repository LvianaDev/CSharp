using System;
using System.Globalization;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Text;

namespace CSharp.Fundamentos
{
	class LendoDados
	{
		public static void Executar()
		{
			Console.WriteLine("Qual é o seu nome? ");
			string nome = Console.ReadLine();

			Console.WriteLine("Qual é a sua idade? ");
			int idade = int.Parse(Console.ReadLine());

			Console.WriteLine("Qual é o seu salário? ");
			double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine($"{nome} {idade} R$ {salario}");
		}
	}
}
