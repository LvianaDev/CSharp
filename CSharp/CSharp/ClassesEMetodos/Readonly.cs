using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ClassesEMetodos
{
	public class Cliente {
		public string Nome;
		readonly DateTime Nascimento;

		public Cliente(string nome, DateTime nascimento) {
			Nome = nome;
			Nascimento = nascimento;
		}

		public string GetDataDeNascimento() {
			return String.Format("{0}/{1}/{2}", Nascimento.Day,
				Nascimento.Month, Nascimento.Year);
		}
	}

	class Readonly
	{
		public static void Executar() {
			var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 4, 11));
			Console.WriteLine(novoCliente.Nome);

			// novoCliente.Nascimento = new DateTime(2020, 10, 10)
		}
	}
}
