using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OO
{
	public abstract class Celular {
		public abstract string Assistente();

		public string Tocar() {
			return "Trim trim trim...";
		}
	}

	public class Samsung : Celular {
		public override string Assistente() {
			return "Olá, meu nome é Bixby!";
		}
	}

	public class Iphone : Celular {
		public override string Assistente() {
			return "Olá! Meu nome é Siri!";
		}
	}

	class Abstract
	{
		public static void Executar() {
			var Celulares = new List<Celular> {
				new Iphone(),
				new Samsung()
			};

			foreach(var celular in Celulares) {
				Console.WriteLine(celular.Assistente());
			}
		}
	}
}
