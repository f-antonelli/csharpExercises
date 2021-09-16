using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysPractice
{
	class Empleados
	{
		private String nombre;
		private int edad;

		public Empleados(String nombre, int edad)
		{
			this.nombre = nombre;
			this.edad = edad;
		}

		public String getEmpleados() => "Nombre empleado: " + nombre + " Edad: " + edad;
	}
}
