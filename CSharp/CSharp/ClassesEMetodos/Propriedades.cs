﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ClassesEMetodos
{
	public class CarroOpcional 
	{
		double desconto = 0.1;

		string nome;
		public string Nome {
			get { return "Opcional" + nome; 
			}
			set {
				nome = value;
			}
		}

		// Propriedade autoimplementada
		public double Preco { get; set; }

		//Somente Leitura
		public double PrecoComDesconto {
			get => Preco - (desconto * Preco); // Lambda
		}

		public CarroOpcional() { }

		public CarroOpcional(string nome, double preco) {
			Nome = nome;
			Preco = preco;
		}

	}

	class Propriedades
	{
		public static void Executar() {
			var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
			Console.WriteLine(op1.PrecoComDesconto);

			// op1.PrecoComDesconto = 3000;

			var op2 = new CarroOpcional();
			op2.Nome = "Direção Eletrica";
			op2.Preco = 2349.9;

			Console.WriteLine(op1.Nome);
			Console.WriteLine(op1.Preco);

			Console.WriteLine(op2.Nome);
			Console.WriteLine(op2.Preco);
			Console.WriteLine(op2.PrecoComDesconto);

		}
	}
}
