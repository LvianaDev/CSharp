using System;
using System.Collections.Generic;

namespace CSharp.Colecoes
{
	class ColecoesSet2
	{
		public static void Executar()
		{
			var livro = new Produto("Game of Throne", 49.9);

			var carrinho = new HashSet<Produto>();
			carrinho.Add(livro);

			var combo = new HashSet<Produto> {
				new Produto("Camisa", 29.90),
				new Produto("8° Temporada Game of Thrones", 29.90),
				new Produto("Poster", 10)
			};

			Console.WriteLine(carrinho.Count);

			foreach (var item in carrinho)
			{
				Console.WriteLine($"{item.Nome} {item.Preco}");
			}

			Console.WriteLine(carrinho.Count);
			carrinho.Add(livro);
		}
	}
}
