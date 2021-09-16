using System;
using System.Collections.Generic;
using System.Text;

namespace ejVehiculos
{
	class Avion : Vehiculo
	{
		public Avion(String nombreAvion) : base(nombreAvion){ }
		//Metodo modificado
		public override void Conducir() => Console.WriteLine("El avion esta en el aire");
	}
}
