using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
	class Mamiferos : Animales  
	{
		private String nombreSerVivo;

		public Mamiferos(String nombre) => nombreSerVivo = nombre; //constructor


		public void CuidarCrias() => Console.WriteLine("Cuido a mis crias");
		public virtual void Pensar() => Console.WriteLine("Pensamiento");
		public override void GetNombre() => Console.WriteLine($"El nombre del mamifero es: {nombreSerVivo}");
	}
}
