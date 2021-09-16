using System;
//Prueba con interfaces, distintas formas de aplicarlo dentro de clases junto con herencias
namespace inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			var caballo = new Caballos("Peluche");
			var persona = new Humano("Simon");
			var kingKong = new Gorila("King kong");

			Mamiferos[] arrayMamiferos = new Mamiferos[3];

			arrayMamiferos[0] = caballo;
			arrayMamiferos[1] = persona;
			arrayMamiferos[2] = kingKong;

			Console.WriteLine("**Formas de pensar***");
			for (int i = 0; i < 3; i++)
			{
				arrayMamiferos[i].GetNombre();
				arrayMamiferos[i].Pensar();
			}

			Console.WriteLine("\n**Cualidades del caballo**");
			caballo.GetNombre();
			caballo.CuidarCrias();
			caballo.Galopar();

			//susticion con interfaces
			ITerrestres ImiCaballo = caballo;
			Console.WriteLine("Cantidad de patas: " + ImiCaballo.numPatas());

			Console.WriteLine("\n**Ballena**");
			var wally = new Ballena("Wally");
			wally.Nadar();


			Console.WriteLine("\n**Lagartija**");
			var lagartito = new Lagartija("Lagartito");
			lagartito.Respirar();
			Console.WriteLine("Cantidad de patas: {0}", lagartito.numPatas()); 
		}
	}	
}
