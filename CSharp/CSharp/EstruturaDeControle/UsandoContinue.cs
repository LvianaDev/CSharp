using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.EstruturaDeControle
{
	class UsandoContinue
	{
		public static void Executar() {
			int intervalo = 12;
			Console.WriteLine("Números pares entre 1 e {0}", intervalo);

			for(int i = 1; i <= intervalo; i++) {
				if(i % 2 == 1) {
					continue;
				}

				Console.WriteLine(i + " ");
			}
		}
	}
}
