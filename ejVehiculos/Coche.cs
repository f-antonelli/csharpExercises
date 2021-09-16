using System;
using System.Collections.Generic;
using System.Text;

namespace ejVehiculos
{
	class Coche : Vehiculo
	{
		public Coche(String nombreCoche) : base(nombreCoche){ }
		//Metodo modificado
		public override void Conducir() => Console.WriteLine("El coche esta en movimiento");
	}
}

