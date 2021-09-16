using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
	class Gorila : Mamiferos, ITerrestres
	{
		public Gorila(String nombreGorila) : base(nombreGorila){ }

		public void Trepar() => Console.WriteLine("Puedo trepar mejor que todos");
		public override void Pensar() => Console.WriteLine("Pienso como un mono");
		public int numPatas()
		{
			return 4;
		}
	}
}
