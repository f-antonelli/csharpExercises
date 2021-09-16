using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Uso de LinkedList ---> a diferencia de list, estan formadas por nodos, pero al borrar datos,
// sus enlaces se anexan al siguiente dato. No hace falta que esten seguidos los datos.
// Es mas eficiente para estar borrando y agregando datos que las List
namespace linkedList
{	class Program
	{
		static void Main(string[] args)
		{
			LinkedList<int> numeros = new LinkedList<int>(); //declarando una lista

			Console.WriteLine("Cuantos numeros desea ingresar?");
			int cantElem = Int32.Parse(Console.ReadLine());

			Console.WriteLine(" ");

			for (int i = 0; i < cantElem; i++)
			{
				Console.WriteLine("Ingrese numero ({0}): ", i + 1);
				numeros.AddLast(Int32.Parse(Console.ReadLine())); //Los datos se agregan abajo del ultimo
			}

			Console.WriteLine("\n***SUMA DE LOS NUMEROS***");
			Console.WriteLine(arraySum(numeros));
			Console.ReadLine();

			Console.WriteLine("***NUMEROS INGRESADOS***");
			Console.WriteLine("-Ordenados-");

			foreach (int elem in numeros)			
				Console.WriteLine(elem);
			

			Console.WriteLine("\nRemoviendo numeros.. Presione una tecla para continuar...");
			numeros.RemoveLast();
			numeros.RemoveFirst();
			Console.ReadLine();

			Console.WriteLine("\n***Nueva lista***");
			//Manejando los nodos de las linkedlist, si el nodo es distinto de nulo, lleno el nodo
			//a la siguiente posicion
			for (LinkedListNode<int> linkNodo = numeros.First; linkNodo != null; linkNodo = linkNodo.Next)
			{
				int numero = linkNodo.Value;

				Console.WriteLine(numero);
			}

		}
		public static int arraySum(LinkedList<int> ar) => ar.Sum();
	}
}