using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Avancados
{
	public class Aluno {
		public string Nome;
		public int Idade;
		public double Nota;
	}

	class LINQ1
	{
		public static void Executar() {
			var alunos = new List<Aluno> {
				new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
				new Aluno() {Nome = "Andre", Idade = 23, Nota = 4.3},
				new Aluno() {Nome = "Ana", Idade = 22, Nota = 8.5},
				new Aluno() {Nome = "Jose", Idade = 27, Nota = 7.7},
				new Aluno() {Nome = "Tulio", Idade = 18, Nota = 6.8},
				new Aluno() {Nome = "Marcio", Idade = 29, Nota = 8.7}
			};

			Console.WriteLine("==== APROVADOS =================");
			var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
			foreach (var aluno in aprovados) {
				Console.WriteLine(aluno.Nome);
			}

			Console.WriteLine("\n== CHAMADA ===================");
			var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
			foreach (var aluno in chamada) {
				Console.WriteLine(aluno);
			}

			Console.WriteLine("\n== Aprovados (por idade) ==========");
			var alunosAprovados =
				from aluno in alunos
				where aluno.Nota >= 7
				orderby aluno.Idade
				select aluno.Nome;

			foreach (var aluno in alunosAprovados) {
				Console.WriteLine(aluno);
			}
		}
	}
}
