using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Avancados
{
	class LINQ2
	{
		public static void Executar()
		{
			var alunos = new List<Aluno>
			{
				new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
				new Aluno() { Nome = "Andre", Idade = 23, Nota = 4.3 },
				new Aluno() { Nome = "Ana", Idade = 22, Nota = 8.5 },
				new Aluno() { Nome = "Jose", Idade = 27, Nota = 7.7 },
				new Aluno() { Nome = "Tulio", Idade = 18, Nota = 6.8 },
				new Aluno() { Nome = "Marcio", Idade = 29, Nota = 8.7 }
			};

			var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
			Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

			var fulano = alunos.SingleOrDefault(
				aluno => aluno.Nome.Equals("Fulano"));
			if (fulano == null) {
				Console.WriteLine("Aluno Inexistente!");
			}

			var ana = alunos.First(Aluno => Aluno.Nome.Equals("Ana! "));
			Console.WriteLine(ana.Nota);

			var sicrano = alunos.FirstOrDefault(
				aluno => aluno.Nota.Equals("Sicrano"));
			if (sicrano == null) {
				Console.WriteLine("Aluno Inexistente");
			}

			var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
			Console.WriteLine(outraAna.Nota);

			var exemploSkip = alunos.Skip(1).Take(3);
			foreach (var item in exemploSkip) {
				Console.WriteLine(item.Nome);
			}

			var maiorNota = alunos.Max(aluno => aluno.Nota);
			Console.WriteLine(maiorNota);

			var menorNota = alunos.Min(aluno => aluno.Nota);
			Console.WriteLine(menorNota);

			var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
			Console.WriteLine(somatorioNotas);

			var mediaDaTurma = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
			Console.WriteLine(mediaDaTurma);
		}
	}
}