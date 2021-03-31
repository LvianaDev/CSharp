﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Api
{
	class UsandoDateTime
	{
		public static void Executar() {		
			var dateTime = new DateTime(year: 2030, month: 2, day: 6);

			Console.WriteLine(dateTime.Day);
			Console.WriteLine(dateTime.Month);
			Console.WriteLine(dateTime.Month);

			// Sem horas
			var hoje = DateTime.Today;
			Console.WriteLine(hoje);

			// Com horas
			var diaAtual = DateTime.Now;
			Console.WriteLine(diaAtual);
			Console.WriteLine("Hora: " + diaAtual.Hour);
			Console.WriteLine("MInutes: " + diaAtual.Minute);
			Console.WriteLine("Hora: " + diaAtual.Hour);

			var amanha = diaAtual.AddDays(1);
			Console.WriteLine(amanha);

			var ontem = diaAtual.AddDays(-1);
			Console.WriteLine(ontem);

			Console.WriteLine(diaAtual.ToString("dd"));
			Console.WriteLine(diaAtual.ToString("dd"));
			Console.WriteLine(diaAtual.ToString("d"));
			Console.WriteLine(diaAtual.ToString("D"));
		}
	}
}
