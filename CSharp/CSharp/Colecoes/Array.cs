using System;

namespace CSharp.Colecoes
{
	class Array
	{
		public static void Executar() 
		{
			//estrutura homogenea (elementos do mesmos tipo = único tipo)
			//estrutura index - começa do 0
			string[] alunos = new string[5];
			alunos[0] = "Anderson";
			alunos[1] = "Lucas";
			alunos[2] = "Milena";
			alunos[3] = "Cris";
			alunos[4] = "João";
			alunos[5] = "Anderson";

			foreach (var aluno in alunos) {
				Console.WriteLine(aluno);
			}

			double somatorio = 0;
			double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

			//foreach (var nota in notas) {
			//	somatorio += nota;
			//}

			for(int i =0; i < notas.Length; i++) {
				somatorio += notas[i];
			}

			double media = somatorio / notas.Length;
			Console.WriteLine(media);

			char[] letras = { 'A', 'r', 'r', 'a', 'y' };
			string palavra = new string(letras);
			Console.WriteLine(palavra);
		}
	}
}
