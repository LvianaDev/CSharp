using System;

namespace CSharp.Colecoes
{
	class Igualdade
	{
		public static void Executar() 
		{
			var p1 = new Produto("Caneta", 1.98);
			var p2 = new Produto("Caneta", 1.98);
			var p3 = p2;

			Console.WriteLine(p1 == p2);
			Console.WriteLine(p3 == p2);

			Console.WriteLine(p1.Equals(p2));
		}
	}
}
