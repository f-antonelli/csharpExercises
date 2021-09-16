using System;
using System.Collections.Generic;
using System.Text;

namespace ejVehiculos
{
	class Vehiculo //superclase
	{
		private String nombreVehiculo;

		public Vehiculo(String nombre) => nombreVehiculo = nombre;

		public void ArrancarMotor() => Console.WriteLine("El vehiculo se ha prendido");
		public void PararMotor() => Console.WriteLine("El vehiculo esta apagado");
		public void GetName() => Console.WriteLine($"La marca es: {nombreVehiculo}");

		//Este metodo lo van heredar tanto coche como avion, pero al aplicar virtual puedo reescribir
		//el metodo en las subclases o modificarlo
		public virtual void Conducir() => Console.WriteLine("El vehiculo esta en movimiento");

		//Ya que tienen el mismo nombre, pero en el caso de que existan 2 metodos con el mismo nombre,
		//pero distinto numero de parametros, en ese caso solamente habria sobrecarga y no haria falta
		//usar virtual
	}
}

