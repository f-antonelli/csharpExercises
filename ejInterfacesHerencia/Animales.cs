using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
	abstract class Animales
	{
		public void Respirar() //Metodo
		{
			Console.WriteLine("Puedo respirar");
		}
		public abstract void GetNombre();
	}
}
