using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
	class Lagartija : Animales, ITerrestres //Deriva de la clase animales ya que no es mamifero
	{
		private String nombreReptil;
		public Lagartija(String nombre) => nombreReptil = nombre;
		public override void GetNombre() => Console.WriteLine("El nombre del reptil es: " + nombreReptil);
		public int numPatas() => 4;
	}
}
