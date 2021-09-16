using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
	class Ballena : Mamiferos
	{
		public Ballena(String nombreBallena) : base(nombreBallena){	}
		public void Nadar() => Console.WriteLine("Puedo nadar muy profundo");
	}
}
