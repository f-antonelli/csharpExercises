using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Prueba con arrays - objetos y funciones
namespace arraysPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			//Array de objetos
			Empleados Ana = new Empleados("Ana", 32); //Creacion obj

			Empleados[] arrayEmpleados = new Empleados[2];

			arrayEmpleados[0] = new Empleados("Fede", 22);

			arrayEmpleados[1] = Ana; //Lo almaceno en pos 1

			Console.WriteLine("***PRUEBA ARRAY DE OBJETOS***");
			for (int i = 0; i < arrayEmpleados.Length; i++)
			{
				Console.WriteLine(arrayEmpleados[i].getEmpleados());				
			}

			Console.WriteLine("__________________________"); //separador
			int[] arrElem = LeerDatos();

			Console.WriteLine("\n***DATOS INGRESADOS***");
			VerDatos(arrElem);
			
		}
		
		static int[] LeerDatos() //Funcion solicitar datos
		{
			Console.WriteLine("\nCuantos elementos debe tener el array?");

			string resp = Console.ReadLine();

			int numElem = int.Parse(resp);

			int[] datos = new int[numElem];

			for (int i = 0; i < numElem; i++)
			{
				Console.WriteLine($"Introduce dato para la posicion {i+1}");
				resp = Console.ReadLine();

				int datoElem = Int32.Parse(resp);

				datos[i] = datoElem;
			}
			return datos;
		}

		static void VerDatos(int[] arrElem)
		{
			foreach (int i in arrElem)
				Console.WriteLine(i);
		}
	}
}
