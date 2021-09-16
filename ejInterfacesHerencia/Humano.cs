using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
	sealed class Humano : Mamiferos, ISaltar, ITerrestres //clase sellada, no puede extenderse mas
	{
		public Humano(String nombreHumano) : base(nombreHumano){ }
		public override void Pensar() => Console.WriteLine("Pienso como una persona"); //Metodo modificado

		//Interfaces aplicadas
		public int NumPatas() => 2;
		public int numPatas() => 2;

	}
}
