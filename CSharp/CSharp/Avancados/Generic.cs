using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Avancados
{
	public class Caixa<T> {
		T valorPrivado;
		public T COISA { get; set; }

		public Caixa(T coisa) {
			coisa = coisa;
		}

		public T metodoGenerico(T valor) {
			return new Random().Next(0, 2) == 0 ? COISA : valor;
		}

		public T GetValor() {
			return valorPrivado;
		}
	}

	class CaixaInt : Caixa<int> {
		public CaixaInt() : base(0) {

		}

	}


		class Generic
	{
		public static void Executar() {
			var caixa1 = new Caixa<int>(1000);

			Console.WriteLine(caixa1.metodoGenerico(33));
			Console.WriteLine(caixa1.COISA.GetType());

			var caixa2 = new Caixa<string>("Construtor");
			Console.WriteLine(caixa2.metodoGenerico("Método"));
			Console.WriteLine(caixa2.COISA.GetType());
		}
	}
}
