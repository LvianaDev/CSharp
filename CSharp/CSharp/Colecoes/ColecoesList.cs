using System;
using System.Collections.Generic;

namespace CSharp.Colecoes
{
	public class Produto {
		public string Nome;
		public double Preco;

		public Produto(string nome, double preco) {
			Nome = nome;
			Preco = preco;
		}

		public override bool Equals(object obj) {
			Produto outroProduto = (Produto)obj;
			bool mesmoNome = Nome == outroProduto.Nome;
			bool mesmoPreco = Preco == outroProduto.Preco;
			return mesmoNome && mesmoPreco;
		}
	}

	class ColecoesList
	{
		public static void Executar() {
			var livro = new Produto("Game of Throne", 49.9);

			var carrinho = new List<Produto>();
			carrinho.Add(livro);

			var combo = new List<Produto> {
				new Produto("Camisa", 29.90),
				new Produto("8° Temporada Game of Thrones", 29.90),
				new Produto("Poster", 10)
			};

			carrinho.AddRange(combo);
			Console.WriteLine(carrinho.Count);
			carrinho.RemoveAt(3);

			foreach (var item in carrinho) {
				Console.WriteLine(carrinho.IndexOf(item));
				Console.WriteLine($"{item.Nome} {item.Preco}");
			}

			Console.WriteLine(carrinho.Count);
			carrinho.Add(livro);
			Console.WriteLine(carrinho.LastIndexOf(livro));
		}
	}
}
