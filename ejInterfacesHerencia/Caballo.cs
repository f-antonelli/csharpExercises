using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
	//Hereda la clase mamiferos y la interfaz
	class Caballos : Mamiferos, ITerrestres, ISaltar
	{
		//base le pasa al constructor de la superclase el dato
		public Caballos(String nombreCaballo) : base(nombreCaballo){ }

		public void Galopar() => Console.WriteLine("Puedo galopar");

		//Distintas formas de aplicar interfaz
		int ITerrestres.numPatas() => 4;
		public int NumPatas() => 2;
	}
}
