using System;

namespace CSharp.ClassesEMetodos
{
	public enum Genero {Acao, Aventura, Terror, Animacao, Comedia};

	public class Filme {
		public string Titulo;
		public Genero GeneroDoFilme;
	}


	class ExempEnums
	{
		public static void Executar() 
		{
			int id = (int)Genero.Animacao;
			Console.WriteLine(id);

			var filmeParaFamilia = new Filme();
			filmeParaFamilia.Titulo = "Pelé";
			filmeParaFamilia.GeneroDoFilme = Genero.Aventura;

			Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, 
				filmeParaFamilia.GeneroDoFilme);
		}
	}
}
