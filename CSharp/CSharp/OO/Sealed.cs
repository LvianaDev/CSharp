using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OO
{
	sealed class SemFilho {
		public double ValorDaFortuna() {
			return 1_407_033.65;
		}
	}

	class Avo {
		public virtual bool HonrarNomeFamilia() {
			return true;
		}
	}

	class  Pai : Avo
	{
		public override sealed bool HonrarNomeFamilia()
		{
			return true;
		}
	}

	class FilhoRebelde : Pai {
		//public new bool HonrarNomeFamilia() {
		//	return false;
		//}
	}


	class Sealed
	{
		public static void Executar() 
		{
			SemFilho semFilho = new SemFilho();
			Console.WriteLine(semFilho.ValorDaFortuna());

			FilhoRebelde filho = new FilhoRebelde();
			Console.WriteLine(filho.HonrarNomeFamilia());
		}
	}
}
