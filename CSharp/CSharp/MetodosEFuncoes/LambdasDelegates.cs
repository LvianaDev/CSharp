using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.MetodosEFuncoes
{
	delegate double Operacao(double x, double y);

	class LambdasDelegates
	{
		public static void Executar() {
			Operacao sum = (x, y) => x + y;
			Operacao sub = (x, y) => x - y;
			Operacao mult = (x, y) => x * y;

			Console.WriteLine(sum(3, 3));
			Console.WriteLine(sum(5, 2));
			Console.WriteLine(mult(12, 8));
		}
	}
}
